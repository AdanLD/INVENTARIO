using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CAPA_DATOS;
using CAPA_ENTIDAD;

namespace CAPA_PRESENTACION
{
    public partial class FormCompras : PADRE
    {
        private DataTable detallesCompra = new DataTable();
        private decimal totalCompra = 0;
        private int proveedorID = 0;
        private int usuarioID;

        public FormCompras(int usuarioID)
        {
            InitializeComponent();
            this.usuarioID = usuarioID;
            InicializarTablaDetalles();
            ConfigurarEncabezadosDataGridView();
            ConfigurarInterfaz();
        }

        private void ConfigurarInterfaz()
        {
            // Cambiar etiquetas para reflejar búsqueda por documento
            //lbl_NumeroDocumento_FormCompras.Text = "Documento Proveedor:";
            //txt_NumeroDocumento_FormCompras.PlaceholderText = "Ingrese documento del proveedor";
        }

        private void VerificarEsquemaDetalleCompra()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();
                    string query = "PRAGMA table_info(TB_Detalle_Compra);";
                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    bool compraIDExiste = false;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (dr["name"].ToString().Equals("compra_ID", StringComparison.OrdinalIgnoreCase))
                            {
                                compraIDExiste = true;
                                break;
                            }
                        }
                    }

                    if (!compraIDExiste)
                    {
                        query = "ALTER TABLE TB_Detalle_Compra ADD COLUMN compra_ID INTEGER;";
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

        private void InicializarTablaDetalles()
        {
            detallesCompra.Columns.Add("articulo_ID", typeof(int));
            detallesCompra.Columns.Add("codigo", typeof(string));
            detallesCompra.Columns.Add("nombre", typeof(string));
            detallesCompra.Columns.Add("precio_compra", typeof(decimal));
            detallesCompra.Columns.Add("precio_venta", typeof(decimal));
            detallesCompra.Columns.Add("cantidad", typeof(int));
            detallesCompra.Columns.Add("subtotal", typeof(decimal));
            dgv_Data_FormCompras.DataSource = detallesCompra;
        }

        private void ConfigurarEncabezadosDataGridView()
        {
            var encabezadosEspanol = new Dictionary<string, string>
            {
                { "articulo_ID", "ID PRODUCTO" },
                { "codigo", "CÓDIGO" },
                { "nombre", "NOMBRE PRODUCTO" },
                { "precio_compra", "PRECIO COMPRA" },
                { "precio_venta", "PRECIO VENTA" },
                { "cantidad", "CANTIDAD" },
                { "subtotal", "SUBTOTAL" }
            };

            foreach (DataGridViewColumn columna in dgv_Data_FormCompras.Columns)
            {
                if (columna.DataPropertyName != null &&
                    encabezadosEspanol.TryGetValue(columna.DataPropertyName, out string nombreColumna))
                {
                    columna.HeaderText = nombreColumna;
                }

                // Ocultar columna ID
                if (columna.DataPropertyName == "articulo_ID")
                {
                    columna.Visible = false;
                }
            }

            dgv_Data_FormCompras.Columns["subtotal"].DefaultCellStyle.Format = "C2";
        }

        private void LimpiarControlesProducto()
        {
            txt_ArticuloID_FormCompras.Clear();
            txt_CodigoProducto_FormCompras.Clear();
            txt_NombreProducto_FormCompras.Clear();
            txt_PrecioCompra_FormCompras.Clear();
            txt_PrecioVenta_FormCompras.Clear();
            numericUpDown_Cantidad_FormCompras.Value = 1;
        }

        private void LimpiarFormulario()
        {
            detallesCompra.Rows.Clear();
            totalCompra = 0;
            txt_TotalAPagar_FormCompras.Clear();
            txt_NumeroDocumento_FormCompras.Clear();
            txt_RazonSocial_FormCompras.Clear();
            proveedorID = 0;
            LimpiarControlesProducto();
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            VerificarEsquemaDetalleCompra();
            txt_Fecha_FormCompras.Text = DateTime.Now.ToString("dd/MM/yyyy");
            List<string> TiposDoc = new List<string> { "BOLETA", "FACTURA" };
            cmb_TipoDoc_FormCompras.DataSource = TiposDoc;
            cmb_TipoDoc_FormCompras.SelectedIndex = 0;
        }



        private void iconButton_BuscarCodigoProducto_FormCompras_Click(object sender, EventArgs e)
        {
            string codigo = txt_CodigoProducto_FormCompras.Text.Trim();
            if (string.IsNullOrEmpty(codigo))
            {
                MessageBox.Show("Ingrese código de producto");
                return;
            }

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();
                    string query = @"SELECT articulo_ID, nombre_Articulo, 
                                    precio_Compra_Articulo, precio_Venta_Articulo
                                    FROM TB_Articulo 
                                    WHERE TRIM(codigo_Articulo) = @codigo COLLATE NOCASE";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@codigo", codigo);

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txt_ArticuloID_FormCompras.Text = dr["articulo_ID"].ToString();
                            txt_NombreProducto_FormCompras.Text = dr["nombre_Articulo"].ToString();
                            txt_PrecioCompra_FormCompras.Text = dr["precio_Compra_Articulo"].ToString();
                            txt_PrecioVenta_FormCompras.Text = dr["precio_Venta_Articulo"].ToString();
                        }
                        else
                        {
                            MessageBox.Show($"Producto con código '{codigo}' no encontrado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en búsqueda: {ex.Message}");
            }
        }



        private void ActualizarTotal()
        {
            totalCompra = 0;
            foreach (DataRow row in detallesCompra.Rows)
            {
                totalCompra += Convert.ToDecimal(row["subtotal"]);
            }
            txt_TotalAPagar_FormCompras.Text = totalCompra.ToString("C2");
        }



        //private void btn_Limpiar_FormCompras_Click(object sender, EventArgs e)
        //{
        //    LimpiarFormulario();
        //}



        //private void btn_EliminarProducto_Click(object sender, EventArgs e)
        //{
        //    if (dgv_Data_FormCompras.CurrentRow != null)
        //    {
        //        decimal subtotal = Convert.ToDecimal(dgv_Data_FormCompras.CurrentRow.Cells["subtotal"].Value);
        //        detallesCompra.Rows.RemoveAt(dgv_Data_FormCompras.CurrentRow.Index);
        //        totalCompra -= subtotal;
        //        txt_TotalAPagar_FormCompras.Text = totalCompra.ToString("C2");
        //    }
        //}

        private void txt_RazonSocial_FormCompras_TextChanged(object sender, EventArgs e) { }
        private void txt_NumeroDocumento_FormCompras_TextChanged(object sender, EventArgs e) { }
        private void txt_TotalAPagar_FormCompras_TextChanged(object sender, EventArgs e) { }

        private void iconButton_NumeroDocumento_FormCompras_Click(object sender, EventArgs e)
        {
            string documento = txt_NumeroDocumento_FormCompras.Text.Trim();
            if (string.IsNullOrEmpty(documento))
            {
                MessageBox.Show("Ingrese documento del proveedor");
                return;
            }

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();
                    string query = @"SELECT proveedor_ID, razonSocial_Proveedor 
                                 FROM TB_Proveedor 
                                 WHERE documento_Proveedor = @documento";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@documento", documento);

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            proveedorID = Convert.ToInt32(dr["proveedor_ID"]);
                            txt_RazonSocial_FormCompras.Text = dr["razonSocial_Proveedor"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Proveedor no encontrado");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error buscando proveedor: {ex.Message}");
            }
        }

        private void iconButton_AgregarProductos_FormCompras_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_ArticuloID_FormCompras.Text) ||
                numericUpDown_Cantidad_FormCompras.Value <= 0)
            {
                MessageBox.Show("Complete los datos del producto");
                return;
            }

            if (!decimal.TryParse(txt_PrecioCompra_FormCompras.Text, out decimal precioCompra) ||
                !decimal.TryParse(txt_PrecioVenta_FormCompras.Text, out decimal precioVenta))
            {
                MessageBox.Show("Valores numéricos inválidos");
                return;
            }

            int articuloID = Convert.ToInt32(txt_ArticuloID_FormCompras.Text);
            string codigo = txt_CodigoProducto_FormCompras.Text;
            string nombre = txt_NombreProducto_FormCompras.Text;
            int cantidad = (int)numericUpDown_Cantidad_FormCompras.Value;

            // Verificar si el producto ya existe en la compra
            foreach (DataRow row in detallesCompra.Rows)
            {
                if (Convert.ToInt32(row["articulo_ID"]) == articuloID)
                {
                    row["cantidad"] = Convert.ToInt32(row["cantidad"]) + cantidad;
                    row["subtotal"] = Convert.ToDecimal(row["precio_compra"]) * Convert.ToInt32(row["cantidad"]);
                    ActualizarTotal();
                    LimpiarControlesProducto();
                    return;
                }
            }

            // Agregar nuevo producto
            decimal subtotal = precioCompra * cantidad;
            detallesCompra.Rows.Add(articuloID, codigo, nombre, precioCompra, precioVenta, cantidad, subtotal);
            totalCompra += subtotal;
            txt_TotalAPagar_FormCompras.Text = totalCompra.ToString("C2");

            LimpiarControlesProducto();
        }

        private void iconButton_CrearCompra_FormCompras_Click(object sender, EventArgs e)
        {
            if (detallesCompra.Rows.Count == 0)
            {
                MessageBox.Show("Agregue productos a la compra");
                return;
            }

            if (proveedorID == 0)
            {
                MessageBox.Show("Seleccione un proveedor");
                return;
            }

            using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
            {
                cn.Open();
                SQLiteTransaction transaction = cn.BeginTransaction();

                try
                {
                    string numeroDocumento = "C-" + DateTime.Now.ToString("yyyyMMddHHmmss");

                    // Registrar cabecera de compra
                    string queryCompra = @"INSERT INTO TB_Compra (
                        tipo_Documento_Compra,
                        numero_Documento_Compra,
                        monto_Total_Compra,
                        moneda_Compra,
                        fecha_Creacion_Compra,
                        hora_Creacion_Compra,
                        proveedor_ID,
                        usuario_ID
                    ) VALUES (
                        @tipoDoc, @numDoc, @total, 'MXN',
                        DATE('now'), TIME('now'), @proveedorID, @usuarioID
                    )";

                    SQLiteCommand cmdCompra = new SQLiteCommand(queryCompra, cn);
                    cmdCompra.Parameters.AddWithValue("@tipoDoc", cmb_TipoDoc_FormCompras.SelectedItem?.ToString() ?? "");
                    cmdCompra.Parameters.AddWithValue("@numDoc", numeroDocumento);
                    cmdCompra.Parameters.AddWithValue("@total", totalCompra);
                    cmdCompra.Parameters.AddWithValue("@proveedorID", proveedorID);
                    cmdCompra.Parameters.AddWithValue("@usuarioID", usuarioID);
                    cmdCompra.ExecuteNonQuery();

                    // Obtener ID de la compra
                    cmdCompra.CommandText = "SELECT last_insert_rowid()";
                    int compraID = Convert.ToInt32(cmdCompra.ExecuteScalar());

                    // Registrar detalles
                    foreach (DataRow row in detallesCompra.Rows)
                    {
                        string queryDetalle = @"INSERT INTO TB_Detalle_Compra (
                            precio_Compra_Detalle_Compra,
                            precio_Venta_Detalle_Compra,
                            cantidad_Detalle_Compra,
                            monto_Total_Detalle_Compra,
                            moneda_Compra,
                            compra_ID,
                            articulo_ID
                        ) VALUES (
                            @precioCompra, @precioVenta, @cantidad, @subtotal,
                            'MXN', @compraID, @articuloID
                        )";

                        SQLiteCommand cmdDetalle = new SQLiteCommand(queryDetalle, cn);
                        cmdDetalle.Parameters.AddWithValue("@precioCompra", row["precio_compra"]);
                        cmdDetalle.Parameters.AddWithValue("@precioVenta", row["precio_venta"]);
                        cmdDetalle.Parameters.AddWithValue("@cantidad", row["cantidad"]);
                        cmdDetalle.Parameters.AddWithValue("@subtotal", row["subtotal"]);
                        cmdDetalle.Parameters.AddWithValue("@compraID", compraID);
                        cmdDetalle.Parameters.AddWithValue("@articuloID", row["articulo_ID"]);
                        cmdDetalle.ExecuteNonQuery();

                        // Actualizar inventario
                        string updateInventario = @"INSERT OR REPLACE INTO TB_Inventario (articulo_ID, almacen_ID, cantidad_inventario)
                            SELECT @articuloID, 1, COALESCE(SUM(cantidad_inventario), 0) + @cantidad
                            FROM TB_Inventario 
                            WHERE articulo_ID = @articuloID";

                        SQLiteCommand cmdInventario = new SQLiteCommand(updateInventario, cn);
                        cmdInventario.Parameters.AddWithValue("@articuloID", row["articulo_ID"]);
                        cmdInventario.Parameters.AddWithValue("@cantidad", row["cantidad"]);
                        cmdInventario.ExecuteNonQuery();
                    }

                    transaction.Commit();

                    MessageBox.Show("¡Compra registrada exitosamente!\n\n" +
                                    $"Número de documento: {numeroDocumento}\n" +
                                    $"Total: {totalCompra:C}",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    LimpiarFormulario();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    MessageBox.Show($"Error al registrar compra: {ex.Message}", "Error",
                                   MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dgv_Data_FormCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex == dgv_Data_FormCompras.Columns["Eliminar"].Index)
            {
                decimal subtotal = Convert.ToDecimal(dgv_Data_FormCompras.Rows[e.RowIndex].Cells["subtotal"].Value);
                detallesCompra.Rows.RemoveAt(e.RowIndex);
                totalCompra -= subtotal;
                txt_TotalAPagar_FormCompras.Text = totalCompra.ToString("C2");
            }
        }

        private void txt_Cambio_FormCompras_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MetodoPago_FormCompras_TextChanged(object sender, EventArgs e)
        {

        }
    }
}