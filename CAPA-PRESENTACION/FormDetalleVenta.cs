using CAPA_DATOS;
using System;
using System.Data;
using System.Data.SQLite;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class FormDetalleVenta : PADRE
    {
        public FormDetalleVenta()
        {
            InitializeComponent();
        }

        private void CargarDetalleVenta(string numeroDocumento)
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();

                    // CONSULTA CABECERA VENTA CORREGIDA
                    string queryCabecera = @"
                    SELECT
                        v.tipo_Documento_Venta,
                        v.numero_Documento_Venta,
                        v.fecha_Creacion_Compra AS fecha_Creacion_Venta,  -- Alias corregido
                        v.hora_Creacion_Compra AS hora_Creacion_Venta,    -- Alias corregido
                        v.monto_Total_Venta,
                        v.monto_Pago_Venta,
                        v.monto_Cambio_Venta,
                        v.nombre_Cliente_Venta || ' ' || 
                        v.apellido_Paterno_Cliente_Venta || ' ' || 
                        v.apellido_Materno_Cliente_Venta AS Cliente,      -- Datos directos de TB_Venta
                        u.nombre_Usuario || ' ' || 
                        u.nombre_paterno_Usuario || ' ' || 
                        u.nombre_Materno_Usuario AS Usuario,
                        v.tipo_Documento_Cliente_Venta AS Documento_Cliente, -- Usar columna existente
                        '' AS cliente_ID  -- No existe en TB_Venta
                    FROM TB_Venta v
                    JOIN TB_Usuario u ON v.usuario_ID = u.usuario_ID  -- Solo JOIN necesario
                    WHERE v.numero_Documento_Venta = @numeroDocumento";

                    SQLiteCommand cmdCabecera = new SQLiteCommand(queryCabecera, cn);
                    cmdCabecera.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);

                    using (SQLiteDataReader dr = cmdCabecera.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            txt_TipoDocumento_FormDetallesVenta.Text = dr["tipo_Documento_Venta"].ToString();
                            txt_NumeroDocumentoVenta_DetallesVenta.Text = dr["numero_Documento_Venta"].ToString();
                            txt_FechaCreacionVenta_FormDetallesVenta.Text = dr["fecha_Creacion_Venta"].ToString();
                            txt_HoraCreacion_FormDetallesVenta.Text = dr["hora_Creacion_Venta"].ToString();
                            txt_MontoTotal_FormDetallesVenta.Text = dr["monto_Total_Venta"].ToString();
                            txt_MontoPago_FormDetallesVenta.Text = dr["monto_Pago_Venta"].ToString();
                            txt_MontoCambio_FormDetallesVenta.Text = dr["monto_Cambio_Venta"].ToString();
                            txt_NombreCliente_FormDetallesVenta.Text = dr["Cliente"].ToString();
                            txt_Usuario_FormDetallesVenta.Text = dr["Usuario"].ToString();
                            txt_NumeroDocumentoCliente_FormDetallesVenta.Text = dr["Documento_Cliente"].ToString();
                            txt_ProveedorID_FormDetalleVentas.Text = dr["cliente_ID"].ToString(); // Vacío por diseño
                        }
                        else
                        {
                            MessageBox.Show("Venta no encontrada");
                            return;
                        }
                    }

                    // CONSULTA DETALLES (sin cambios)
                    string queryDetalle = @"
                    SELECT
                        a.codigo_Articulo AS Codigo,
                        a.nombre_Articulo AS Producto,
                        dv.precio_Venta_Detalle_Venta AS PrecioUnitario,
                        dv.cantidad_Detalle_Venta AS Cantidad,
                        dv.subtotal_Detalle_Venta AS Subtotal
                    FROM TB_Detalle_Venta dv
                    JOIN TB_Articulo a ON dv.articulo_ID = a.articulo_ID
                    WHERE dv.venta_ID = (
                        SELECT venta_ID FROM TB_Venta 
                        WHERE numero_Documento_Venta = @numeroDocumento
                    )";

                    SQLiteDataAdapter da = new SQLiteDataAdapter(queryDetalle, cn);
                    da.SelectCommand.Parameters.AddWithValue("@numeroDocumento", numeroDocumento);

                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    dgv_Data_FormDetalleVenta.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar detalles: {ex.Message}");
            }
        }

        private void LimpiarFormulario()
        {
            txt_NumeroDocumentoVenta_DetallesVenta.Clear();
            txt_TipoDocumento_FormDetallesVenta.Clear();
            txt_FechaCreacionVenta_FormDetallesVenta.Clear();
            txt_HoraCreacion_FormDetallesVenta.Clear();
            txt_MontoTotal_FormDetallesVenta.Clear();
            txt_MontoPago_FormDetallesVenta.Clear();
            txt_MontoCambio_FormDetallesVenta.Clear();
            txt_NombreCliente_FormDetallesVenta.Clear();
            txt_Usuario_FormDetallesVenta.Clear();
            txt_NumeroDocumentoCliente_FormDetallesVenta.Clear();
            txt_ProveedorID_FormDetalleVentas.Clear();
            dgv_Data_FormDetalleVenta.DataSource = null;
        }

        private void iconButton_LimpiarFormulario_FormDetallesVenta_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        private void FormDetalleVenta_Load(object sender, EventArgs e)
        {
            dgv_Data_FormDetalleVenta.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv_Data_FormDetalleVenta.ReadOnly = true;
        }

        private void iconButton_BuscarNumeroDocumeto_FormDetallesVenta_Click(object sender, EventArgs e)
        {
            string numeroDocumento = txt_NumeroDocumentoVenta_DetallesVenta.Text.Trim();
            if (string.IsNullOrEmpty(numeroDocumento))
            {
                MessageBox.Show("Ingrese número de documento de venta");
                return;
            }
            CargarDetalleVenta(numeroDocumento);
        }
    }
}