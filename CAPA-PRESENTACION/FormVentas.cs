using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDAD;

namespace CAPA_PRESENTACION
{
    public partial class FormVentas : PADRE
    {
        private DataTable detallesVenta = new DataTable();
        private decimal totalVenta = 0;
        private int clienteID = 0;
        private string tipoDocumentoCliente = "";
        private int usuarioID;

        public FormVentas(int usuarioID)
        {
            InitializeComponent();
            this.usuarioID = usuarioID;
            InicializarTablaDetalles();
            ConfigurarEncabezadosDataGridView();
        }

        private void VerificarEsquemaDetalleVenta()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();
                    string query = "PRAGMA table_info(TB_Detalle_Venta);";
                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    bool ventaIDExiste = false;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (dr["name"].ToString().Equals("venta_ID", StringComparison.OrdinalIgnoreCase))
                            {
                                ventaIDExiste = true;
                                break;
                            }
                        }
                    }

                    if (!ventaIDExiste)
                    {
                        query = "ALTER TABLE TB_Detalle_Venta ADD COLUMN venta_ID INTEGER;";
                        cmd = new SQLiteCommand(query, cn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verificando esquema: {ex.Message}");
            }
        }

        // NUEVO MÉTODO PARA VERIFICAR ESQUEMA DE COMPRA
        private void VerificarEsquemaCompra()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();
                    string query = "PRAGMA table_info(TB_Compra);";
                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    bool provedorIDExiste = false;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (dr["name"].ToString().Equals("provedor_ID", StringComparison.OrdinalIgnoreCase))
                            {
                                provedorIDExiste = true;
                                break;
                            }
                        }
                    }

                    if (!provedorIDExiste)
                    {
                        query = "ALTER TABLE TB_Compra ADD COLUMN provedor_ID INTEGER;";
                        cmd = new SQLiteCommand(query, cn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verificando esquema de compra: {ex.Message}");
            }
        }

        private void LimpiarControlesProducto()
        {
            txt_ProductoID_FormCompras.Clear();
            txt_CodigoProducto_FormVentas.Clear();
            txt_NombreProducto_FormVentas.Clear();
            txt_PrecioVenta_FormVentas.Clear();
            txt_PrecioStock_FormVentas.Clear();
            numericUpDown_Cantidad_FormVentas.Value = 1;

            txt_ProductoID_FormCompras.BackColor = SystemColors.Window;
            txt_NombreProducto_FormVentas.BackColor = SystemColors.Window;
        }

        private void LimpiarFormulario()
        {
            detallesVenta.Rows.Clear();
            totalVenta = 0;
            txt_Total_FormVentas.Clear();
            txt_NumeorDocumento_FormVentas.Clear();
            txt_NombreCliente_FormCompras.Clear();
            txt_ApellidoPaterno_FormCompras.Clear();
            txt_ApellidoMaterno_FormCompras.Clear();
            clienteID = 0;
            tipoDocumentoCliente = "";
            txt_MetodoPago_FormVentas.Clear();
            LimpiarControlesProducto();
        }

        private void InicializarTablaDetalles()
        {
            detallesVenta.Columns.Add("articulo_ID", typeof(int));
            detallesVenta.Columns.Add("codigo", typeof(string));
            detallesVenta.Columns.Add("nombre", typeof(string));
            detallesVenta.Columns.Add("precio_venta", typeof(decimal));
            detallesVenta.Columns.Add("cantidad", typeof(int));
            detallesVenta.Columns.Add("subtotal", typeof(decimal));
            dgv_Data_FormVentas.DataSource = detallesVenta;
        }

        private void ConfigurarEncabezadosDataGridView()
        {
            var encabezadosEspanol = new Dictionary<string, string>
            {
                { "articulo_ID", "ID PRODUCTO" },
                { "codigo", "CÓDIGO" },
                { "nombre", "NOMBRE PRODUCTO" },
                { "precio_venta", "PRECIO UNITARIO" },
                { "cantidad", "CANTIDAD" },
                { "subtotal", "SUBTOTAL" }
            };

            foreach (DataGridViewColumn columna in dgv_Data_FormVentas.Columns)
            {
                if (columna.DataPropertyName != null &&
                    encabezadosEspanol.TryGetValue(columna.DataPropertyName, out string nombreColumna))
                {
                    columna.HeaderText = nombreColumna;
                }
            }
        }

        private void cmb_TipoDoc_FormVenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<string> TiposDoc = new List<string> { "BOLETA", "FACTURA" };
            cmb_TipoDoc_FormCompras.DataSource = TiposDoc;
        }

        private void FormVentas_Load(object sender, EventArgs e)
        {
            VerificarEsquemaDetalleVenta();
            VerificarEsquemaCompra(); // LLAMADA AL NUEVO MÉTODO
            txt_Fecha_FormCompras.Text = DateTime.Now.ToString("dd/MM/yyyy");
            List<string> TiposDoc = new List<string> { "BOLETA", "FACTURA" };
            cmb_TipoDoc_FormCompras.DataSource = TiposDoc;
        }

        private void iconButton_BuscarNumDoc_FormVentas_Click(object sender, EventArgs e)
        {
            string codigo = txt_CodigoProducto_FormVentas.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese código de producto");
                return;
            }

            using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
            {
                cn.Open();
                try
                {
                    string query = @"SELECT a.articulo_ID, a.nombre_Articulo, a.precio_Venta_Articulo, 
                                    COALESCE(SUM(i.cantidad_Inventario), 0) AS cantidad_inventario
                                    FROM TB_Articulo a
                                    LEFT JOIN TB_Inventario i ON a.articulo_ID = i.articulo_ID
                                    WHERE TRIM(a.codigo_Articulo) = @codigo COLLATE NOCASE
                                    GROUP BY a.articulo_ID";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txt_ProductoID_FormCompras.Text = dr["articulo_ID"].ToString();
                            txt_NombreProducto_FormVentas.Text = dr["nombre_Articulo"].ToString();
                            txt_PrecioVenta_FormVentas.Text = dr["precio_Venta_Articulo"].ToString();
                            txt_PrecioStock_FormVentas.Text = dr["cantidad_inventario"].ToString();

                            txt_ProductoID_FormCompras.BackColor = Color.LightGreen;
                            txt_NombreProducto_FormVentas.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            MessageBox.Show($"Producto con código '{codigo}' no encontrado");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error en búsqueda: {ex.Message}");
                }
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            string documento = txt_NumeorDocumento_FormVentas.Text.Trim();
            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Ingrese documento del cliente");
                return;
            }

            using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
            {
                cn.Open();
                string query = @"SELECT cliente_ID, nombre_Cliente, apellido_Paterno_Cliente, 
                                apellido_Materno_Cliente, documento_Cliente 
                                FROM TB_Cliente 
                                WHERE documento_Cliente = @doc";

                SQLiteCommand cmd = new SQLiteCommand(query, cn);
                cmd.Parameters.AddWithValue("@doc", documento);

                using (SQLiteDataReader dr = cmd.ExecuteReader())
                {
                    if (dr.Read())
                    {
                        clienteID = Convert.ToInt32(dr["cliente_ID"]);
                        tipoDocumentoCliente = dr["documento_Cliente"].ToString();
                        txt_NombreCliente_FormCompras.Text = dr["nombre_Cliente"].ToString();
                        txt_ApellidoPaterno_FormCompras.Text = dr["apellido_Paterno_Cliente"].ToString();
                        txt_ApellidoMaterno_FormCompras.Text = dr["apellido_Materno_Cliente"].ToString();
                    }
                    else
                    {
                        MessageBox.Show("Cliente no encontrado");
                    }
                }
            }
        }

        private void iconButton_AgregarProductos_FormVentas_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(txt_ProductoID_FormCompras.Text) ||
                numericUpDown_Cantidad_FormVentas.Value <= 0)
            {
                MessageBox.Show("Complete los datos del producto");
                return;
            }

            if (!decimal.TryParse(txt_PrecioVenta_FormVentas.Text, out decimal precioVenta) ||
                !int.TryParse(txt_PrecioStock_FormVentas.Text, out int stock))
            {
                MessageBox.Show("Valores numéricos inválidos");
                return;
            }

            int articuloID = Convert.ToInt32(txt_ProductoID_FormCompras.Text);
            string codigo = txt_CodigoProducto_FormVentas.Text;
            string nombre = txt_NombreProducto_FormVentas.Text;
            int cantidad = (int)numericUpDown_Cantidad_FormVentas.Value;

            if (cantidad > stock)
            {
                MessageBox.Show($"Stock insuficiente. Disponible: {stock}");
                return;
            }

            decimal subtotal = precioVenta * cantidad;
            detallesVenta.Rows.Add(articuloID, codigo, nombre, precioVenta, cantidad, subtotal);
            totalVenta += subtotal;
            txt_Total_FormVentas.Text = totalVenta.ToString("0.00");

            LimpiarControlesProducto();
        }

        private void iconButton_CrearVenta_FormVentas_Click(object sender, EventArgs e)
        {
            if (detallesVenta.Rows.Count == 0 || clienteID == 0)
            {
                MessageBox.Show("Complete los datos de la venta");
                return;
            }

            if (!decimal.TryParse(txt_MetodoPago_FormVentas.Text, out decimal pago))
            {
                MessageBox.Show("Ingrese un monto válido");
                return;
            }

            if (pago < totalVenta)
            {
                MessageBox.Show($"El pago es menor al total. Total: {totalVenta:C}");
                return;
            }

            decimal cambio = pago - totalVenta;

            using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
            {
                cn.Open();
                SQLiteTransaction transaction = cn.BeginTransaction();

                try
                {
                    string numeroDocumento = "V-" + DateTime.Now.ToString("yyyyMMddHHmmss");

                    string queryVenta = @"INSERT INTO TB_Venta 
                        (tipo_Documento_Venta, 
                        numero_Documento_Venta,
                        tipo_Documento_Cliente_Venta,
                        nombre_Cliente_Venta,
                        apellido_Paterno_Cliente_Venta,
                        apellido_Materno_Cliente_Venta,
                        monto_Pago_Venta,
                        monto_Cambio_Venta,
                        monto_Total_Venta,
                        fecha_Creacion_Compra,
                        hora_Creacion_Compra,
                        usuario_ID)
                     VALUES (
                        @tipoDoc, @numDoc, @tipoDocCliente, 
                        @nombreCliente, @apellidoPaterno, @apellidoMaterno,
                        @pago, @cambio, @total,
                        DATE('now'), TIME('now'), @usuarioID
                    )";

                    SQLiteCommand cmdVenta = new SQLiteCommand(queryVenta, cn);
                    cmdVenta.Parameters.AddWithValue("@tipoDoc", cmb_TipoDoc_FormCompras.SelectedItem?.ToString() ?? "");
                    cmdVenta.Parameters.AddWithValue("@numDoc", numeroDocumento);
                    cmdVenta.Parameters.AddWithValue("@tipoDocCliente", tipoDocumentoCliente);
                    cmdVenta.Parameters.AddWithValue("@nombreCliente", txt_NombreCliente_FormCompras.Text);
                    cmdVenta.Parameters.AddWithValue("@apellidoPaterno", txt_ApellidoPaterno_FormCompras.Text);
                    cmdVenta.Parameters.AddWithValue("@apellidoMaterno", txt_ApellidoMaterno_FormCompras.Text);
                    cmdVenta.Parameters.AddWithValue("@pago", pago);
                    cmdVenta.Parameters.AddWithValue("@cambio", cambio);
                    cmdVenta.Parameters.AddWithValue("@total", totalVenta);
                    cmdVenta.Parameters.AddWithValue("@usuarioID", usuarioID);

                    cmdVenta.ExecuteNonQuery();

                    cmdVenta.CommandText = "SELECT last_insert_rowid()";
                    int ventaID = Convert.ToInt32(cmdVenta.ExecuteScalar());

                    foreach (DataRow row in detallesVenta.Rows)
                    {
                        string queryDetalle = @"INSERT INTO TB_Detalle_Venta (
                            precio_Venta_Detalle_Venta,
                            cantidad_Detalle_Venta,
                            subtotal_Detalle_Venta,
                            moneda_Venta,
                            venta_ID,
                            articulo_ID
                        ) VALUES (
                            @precioVenta, @cantidad, @subtotal,
                            0, @ventaID, @articuloID
                        )";

                        SQLiteCommand cmdDetalle = new SQLiteCommand(queryDetalle, cn);
                        cmdDetalle.Parameters.AddWithValue("@precioVenta", row["precio_venta"]);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", row["cantidad"]);
                        cmdDetalle.Parameters.AddWithValue("@subtotal", row["subtotal"]);
                        cmdDetalle.Parameters.AddWithValue("@ventaID", ventaID);
                        cmdDetalle.Parameters.AddWithValue("@articuloID", row["articulo_ID"]);
                        cmdDetalle.ExecuteNonQuery();

                        string updateInventario = @"UPDATE TB_Inventario SET 
                            cantidad_Inventario = cantidad_Inventario - @cantidad
                            WHERE articulo_ID = @articuloID";

                        SQLiteCommand cmdInventario = new SQLiteCommand(updateInventario, cn);
                        cmdInventario.Parameters.AddWithValue("@cantidad", row["cantidad"]);
                        cmdInventario.Parameters.AddWithValue("@articuloID", row["articulo_ID"]);
                        cmdInventario.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show($"Venta registrada exitosamente\n\n" +
                                    $"Total: {totalVenta:C}\n" +
                                    $"Pago: {pago:C}\n" +
                                    $"Cambio: {cambio:C}",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error al registrar venta: {ex.Message}");
                }
            }
        }

        private void btn_Limpiar_FormVenta_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }
    }
}