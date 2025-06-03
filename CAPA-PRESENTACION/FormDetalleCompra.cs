using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;
using CAPA_DATOS;

namespace CAPA_PRESENTACION
{
    public partial class FormDetalleCompra : PADRE
    {
        public FormDetalleCompra()
        {
            InitializeComponent();
        }

        private void CargarDetalleCompra(string numeroDocumento)
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();

                    string queryCabecera = @"
                        SELECT 
                            c.tipo_Documento_Compra,
                            c.numero_Documento_Compra,
                            c.fecha_Creacion_Compra,
                            c.hora_Creacion_Compra,
                            c.monto_Total_Compra,
                            p.razonSocial_Proveedor,
                            c.proveedor_ID,
                            u.nombre_Usuario || ' ' || u.nombre_Paterno_Usuario || ' ' || u.nombre_Materno_Usuario AS Usuario
                        FROM TB_Compra c
                        JOIN TB_Proveedor p ON c.proveedor_ID = p.proveedor_ID
                        JOIN TB_Usuario u ON c.usuario_ID = u.usuario_ID
                        WHERE c.numero_Documento_Compra = @numeroDocumento";

                    SQLiteCommand cmdCabecera = new SQLiteCommand(queryCabecera, cn);
                    cmdCabecera.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);

                    using (SQLiteDataReader dr = cmdCabecera.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txt_TipoDocumento_FormDetallesCompra.Text = dr["tipo_Documento_Compra"].ToString();
                            txt_NumeroDocumento_FormDetalleCompras.Text = dr["numero_Documento_Compra"].ToString();
                            txt_FechaCreacion_FormDetallesCompra.Text = dr["fecha_Creacion_Compra"].ToString();
                            txt_Hora_FormDetallesCompra.Text = dr["hora_Creacion_Compra"].ToString();
                            txt_MontoTotal_FormDetalleCompras.Text = dr["monto_Total_Compra"].ToString();
                            txt_RazonSocial_FormDetallesCompra.Text = dr["razonSocial_Proveedor"].ToString();
                            txt_ProveedorID_FormCompras.Text = dr["proveedor_ID"].ToString();
                            txt_Usuario_FormReporteCompras.Text = dr["Usuario"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("Compra no encontrada");
                            return;
                        }
                    }

                    string queryDetalle = @"
                        SELECT 
                            a.codigo_Articulo AS Codigo,
                            a.nombre_Articulo AS Producto,
                            dc.precio_Compra_Detalle_Compra AS PrecioCompra,
                            dc.cantidad_Detalle_Compra AS Cantidad,
                            dc.monto_Total_Detalle_Compra AS Subtotal
                        FROM TB_Detalle_Compra dc
                        JOIN TB_Articulo a ON dc.articulo_ID = a.articulo_ID
                        WHERE dc.compra_ID = (SELECT compra_ID FROM TB_Compra WHERE numero_Documento_Compra = @numeroDocumento)";

                    SQLiteDataAdapter da = new SQLiteDataAdapter(queryDetalle, cn);
                    da.SelectCommand.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_Data_FormDetalleCompras.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar detalles: " + ex.Message);
            }
        }

        private void iconButton_BuscarInformation_FormDetalleCompras_Click(object sender, EventArgs e)
        {
            string numeroDocumento = txt_NumeroDocumentoCompra_FormDetallesCompra.Text.Trim();
            if (string.IsNullOrEmpty(numeroDocumento))
            {
                MessageBox.Show("Ingrese número de documento");
                return;
            }

            CargarDetalleCompra(numeroDocumento);
        }

        private void iconButton_VaciarFormulario_FormDetalleCompras_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void LimpiarFormulario()
        {
            txt_NumeroDocumentoCompra_FormDetallesCompra.Clear();
            txt_TipoDocumento_FormDetallesCompra.Clear();
            txt_NumeroDocumento_FormDetalleCompras.Clear();
            txt_FechaCreacion_FormDetallesCompra.Clear();
            txt_Hora_FormDetallesCompra.Clear();
            txt_MontoTotal_FormDetalleCompras.Clear();
            txt_RazonSocial_FormDetallesCompra.Clear();
            txt_ProveedorID_FormCompras.Clear();
            txt_Usuario_FormReporteCompras.Clear();
            dgv_Data_FormDetalleCompras.DataSource = null;
        }

        private void FormDetalleCompra_Load(object sender, EventArgs e) { }
        private void txt_NumeroDocumentoCompra_FormDetallesCompra_TextChanged(object sender, EventArgs e) { }
        private void txt_FechaCreacion_FormDetallesCompra_TextChanged(object sender, EventArgs e) { }
        private void txt_Hora_FormDetallesCompra_TextChanged(object sender, EventArgs e) { }
        private void txt_TipoDocumento_FormDetallesCompra_TextChanged(object sender, EventArgs e) { }
        private void txt_Usuario_FormReporteCompras_TextChanged(object sender, EventArgs e) { }
        private void txt_NumeroDocumento_FormDetalleCompras_TextChanged(object sender, EventArgs e) { }
        private void txt_RazonSocial_FormDetallesCompra_TextChanged(object sender, EventArgs e) { }
        private void txt_MontoTotal_FormDetalleCompras_TextChanged(object sender, EventArgs e) { }
        private void txt_ProveedorID_FormCompras_TextChanged(object sender, EventArgs e) { }
        private void dgv_Data_FormDetalleCompras_CellContentClick(object sender, DataGridViewCellEventArgs e) { }

        private void iconButton_BuscarInformacion_FormDetalleCompras_Click(object sender, EventArgs e)
        {
            string numeroDocumento = txt_NumeroDocumentoCompra_FormDetallesCompra.Text.Trim();
            if (string.IsNullOrEmpty(numeroDocumento))
            {
                MessageBox.Show("Ingrese número de documento");
                return;
            }

            CargarDetalleCompra(numeroDocumento);
        }
    }
}