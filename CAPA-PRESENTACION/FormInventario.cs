using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;
using CAPA_DATOS;
using CAPA_ENTIDAD;

namespace CAPA_PRESENTACION
{

    public partial class FormInventario : PADRE
    {
        public FormInventario()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarAlmacenes();
            CargarProductos();
            CargarInventario();
            rb_Transferencia.Checked = true;
        }
        public static class Global
        {
            public static int UsuarioActualID { get; set; }
        }
        private void CargarAlmacenes()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();
                    string query = "SELECT almacen_ID, nombre_Almacen FROM TB_Almacen";
                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    SQLiteDataReader dr = cmd.ExecuteReader();

                    cmb_AlmacenOrigen.Items.Clear();
                    cmb_Destino.Items.Clear();

                    while (dr.Read())
                    {
                        cmb_AlmacenOrigen.Items.Add(new Almacen
                        {
                            almacen_ID = Convert.ToInt32(dr["almacen_ID"]),
                            nombre_Almacen = dr["nombre_Almacen"].ToString()
                        });
                        cmb_Destino.Items.Add(new Almacen
                        {
                            almacen_ID = Convert.ToInt32(dr["almacen_ID"]),
                            nombre_Almacen = dr["nombre_Almacen"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar almacenes: " + ex.Message);
            }
        }

        private void CargarProductos()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();
                    string query = "SELECT articulo_ID, nombre_Articulo FROM TB_Articulo";
                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    SQLiteDataReader dr = cmd.ExecuteReader();

                    cmb_Producto.Items.Clear();

                    while (dr.Read())
                    {
                        cmb_Producto.Items.Add(new Producto
                        {
                            articulo_ID = Convert.ToInt32(dr["articulo_ID"]),
                            nombre_Articulo = dr["nombre_Articulo"].ToString()
                        });
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void CargarInventario()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"
                        SELECT 
                            a.nombre_Almacen AS Almacen,
                            p.nombre_Articulo AS Producto,
                            i.cantidad_inventario AS Cantidad
                        FROM TB_Inventario i
                        INNER JOIN TB_Almacen a ON i.almacen_ID = a.almacen_ID
                        INNER JOIN TB_Articulo p ON i.articulo_ID = p.articulo_ID";

                    SQLiteDataAdapter da = new SQLiteDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_Inventario.DataSource = dt;
                    dgv_Inventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar inventario: " + ex.Message);
            }
        }


        private void RealizarTransferencia()
        {
            Almacen origen = (Almacen)cmb_AlmacenOrigen.SelectedItem;
            Almacen destino = (Almacen)cmb_Destino.SelectedItem;
            Producto producto = (Producto)cmb_Producto.SelectedItem;
            int cantidad = (int)num_Cantidad.Value;

            if (origen.almacen_ID == destino.almacen_ID)
            {
                MessageBox.Show("El almacén origen y destino no pueden ser iguales");
                return;
            }

            using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
            {
                cn.Open();
                SQLiteTransaction transaction = cn.BeginTransaction();

                try
                {
                    // Verificar stock en origen
                    string checkStock = @"
                        SELECT cantidad_inventario 
                        FROM TB_Inventario 
                        WHERE almacen_ID = @origenId 
                        AND articulo_ID = @articuloId";

                    SQLiteCommand cmdCheck = new SQLiteCommand(checkStock, cn);
                    cmdCheck.Parameters.AddWithValue("@origenId", origen.almacen_ID);
                    cmdCheck.Parameters.AddWithValue("@articuloId", producto.articulo_ID);

                    int stockActual = Convert.ToInt32(cmdCheck.ExecuteScalar());

                    if (stockActual < cantidad)
                    {
                        throw new Exception("Stock insuficiente en almacén origen");
                    }

                    // Restar de origen
                    string updateOrigen = @"
                        UPDATE TB_Inventario 
                        SET cantidad_inventario = cantidad_inventario - @cantidad 
                        WHERE almacen_ID = @origenId 
                        AND articulo_ID = @articuloId";

                    SQLiteCommand cmdOrigen = new SQLiteCommand(updateOrigen, cn);
                    cmdOrigen.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdOrigen.Parameters.AddWithValue("@origenId", origen.almacen_ID);
                    cmdOrigen.Parameters.AddWithValue("@articuloId", producto.articulo_ID);
                    cmdOrigen.ExecuteNonQuery();

                    // Sumar a destino (insertar si no existe)
                    string updateDestino = @"
                        INSERT OR REPLACE INTO TB_Inventario (articulo_ID, almacen_ID, cantidad_inventario)
                        VALUES (
                            @articuloId, 
                            @destinoId, 
                            COALESCE(
                                (SELECT cantidad_inventario FROM TB_Inventario 
                                 WHERE articulo_ID = @articuloId AND almacen_ID = @destinoId), 
                                0
                            ) + @cantidad
                        )";

                    SQLiteCommand cmdDestino = new SQLiteCommand(updateDestino, cn);
                    cmdDestino.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdDestino.Parameters.AddWithValue("@destinoId", destino.almacen_ID);
                    cmdDestino.Parameters.AddWithValue("@articuloId", producto.articulo_ID);
                    cmdDestino.ExecuteNonQuery();

                    // Registrar movimiento
                    string insertMovimiento = @"
                        INSERT INTO TB_Movimiento (
                            articulo_ID, 
                            almacen_Origen_ID, 
                            almacen_Destino_ID, 
                            cantidad_Movimiento,
                            usuario_ID
                        ) VALUES (
                            @articuloId, 
                            @origenId, 
                            @destinoId, 
                            @cantidad,
                            @usuarioId
                        )";

                    SQLiteCommand cmdMovimiento = new SQLiteCommand(insertMovimiento, cn);
                    cmdMovimiento.Parameters.AddWithValue("@articuloId", producto.articulo_ID);
                    cmdMovimiento.Parameters.AddWithValue("@origenId", origen.almacen_ID);
                    cmdMovimiento.Parameters.AddWithValue("@destinoId", destino.almacen_ID);
                    cmdMovimiento.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdMovimiento.Parameters.AddWithValue("@usuarioId", Global.UsuarioActualID);
                    cmdMovimiento.ExecuteNonQuery();

                    transaction.Commit();
                    lbl_Info.Text = "Transferencia realizada con éxito";
                    lbl_Info.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    lbl_Info.Text = "Error: " + ex.Message;
                    lbl_Info.ForeColor = Color.Red;
                }
            }
        }

        private void RealizarAjuste()
        {
            Almacen almacen = (Almacen)cmb_AlmacenOrigen.SelectedItem;
            Producto producto = (Producto)cmb_Producto.SelectedItem;
            int cantidad = (int)num_Cantidad.Value;

            using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
            {
                cn.Open();
                SQLiteTransaction transaction = cn.BeginTransaction();

                try
                {
                    // Actualizar inventario
                    string updateInventario = @"
                        INSERT OR REPLACE INTO TB_Inventario (articulo_ID, almacen_ID, cantidad_inventario)
                        VALUES (
                            @articuloId, 
                            @almacenId, 
                            COALESCE(
                                (SELECT cantidad_inventario FROM TB_Inventario 
                                 WHERE articulo_ID = @articuloId AND almacen_ID = @almacenId), 
                                0
                            ) + @cantidad
                        )";

                    SQLiteCommand cmdInventario = new SQLiteCommand(updateInventario, cn);
                    cmdInventario.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdInventario.Parameters.AddWithValue("@almacenId", almacen.almacen_ID);
                    cmdInventario.Parameters.AddWithValue("@articuloId", producto.articulo_ID);
                    cmdInventario.ExecuteNonQuery();

                    // Registrar movimiento (ajuste)
                    string insertMovimiento = @"
                        INSERT INTO TB_Movimiento (
                            articulo_ID, 
                            almacen_Destino_ID, 
                            cantidad_Movimiento,
                            usuario_ID
                        ) VALUES (
                            @articuloId, 
                            @almacenId, 
                            @cantidad,
                            @usuarioId
                        )";

                    SQLiteCommand cmdMovimiento = new SQLiteCommand(insertMovimiento, cn);
                    cmdMovimiento.Parameters.AddWithValue("@articuloId", producto.articulo_ID);
                    cmdMovimiento.Parameters.AddWithValue("@almacenId", almacen.almacen_ID);
                    cmdMovimiento.Parameters.AddWithValue("@cantidad", cantidad);
                    cmdMovimiento.Parameters.AddWithValue("@usuarioId", Global.UsuarioActualID);
                    cmdMovimiento.ExecuteNonQuery();

                    transaction.Commit();
                    lbl_Info.Text = "Ajuste realizado con éxito";
                    lbl_Info.ForeColor = Color.Green;
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    lbl_Info.Text = "Error: " + ex.Message;
                    lbl_Info.ForeColor = Color.Red;
                }
            }
        }

     


        private class Almacen
        {
            public int almacen_ID { get; set; }
            public string nombre_Almacen { get; set; }
            public override string ToString() => nombre_Almacen;
        }

        private class Producto
        {
            public int articulo_ID { get; set; }
            public string nombre_Articulo { get; set; }
            public override string ToString() => nombre_Articulo;
        }

        private void rb_Transferencia_CheckedChanged(object sender, EventArgs e)
        {
            cmb_Destino.Enabled = rb_Transferencia.Checked;

        }

        private void btn_RealizarMovimiento_Click(object sender, EventArgs e)
        {
            if (cmb_AlmacenOrigen.SelectedItem == null ||
               cmb_Producto.SelectedItem == null ||
               num_Cantidad.Value <= 0)
            {
                MessageBox.Show("Complete todos los campos obligatorios");
                return;
            }

            if (rb_Transferencia.Checked)
            {
                if (cmb_Destino.SelectedItem == null)
                {
                    MessageBox.Show("Seleccione un almacén destino");
                    return;
                }

                RealizarTransferencia();
            }
            else
            {
                RealizarAjuste();
            }

            CargarInventario();
        }

        private void btn_Actualizar_Click(object sender, EventArgs e)
        {
            CargarInventario();
            lbl_Info.Text = "Datos actualizados";
        }
    }
}