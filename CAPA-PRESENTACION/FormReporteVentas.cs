using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class FormReporteVentas : Form
    {
        public FormReporteVentas()
        {
            InitializeComponent();
        }

        private void OpcionesComboBox()
        {
            var headersReportesCompras = new Dictionary<string, string>
            {
                { "venta_ID", "IDENTIFICADOR DE VENTA" },
                { "tipo_Documento_Venta", "TIPO DE DOCUMENTO" },
                { "numero_Documento_Venta", "NUMERO DE DOCUMENTO" },
                { "tipo_Documento_Cliente_Venta", "DOCUMENTO DEL CLIENTE" },
                { "nombre_Cliente_Venta", "CLIENTE" },
                { "apellido_Paterno_Cliente_Venta", "APELLIDO PATERNO" },
                { "apellido_Materno_Cliente_Venta", "APELLIDO MATERNO" },
                { "monto_Pago_Venta", "PAGO" },
                { "monto_Cambio_Venta", "CAMBIO" },
                { "monto_Total_Venta", "TOTAL" },
                { "fecha_Creacion_Compra", "FECHA" }, 
                { "hora_Creacion_Compra", "HORA" },    
                { "usuario_ID", "IDENTIFICADOR DE USUARIO" }
            };

            cmb_Buscar_FormReporteCompras.DisplayMember = "Value";
            cmb_Buscar_FormReporteCompras.ValueMember = "Key";
            cmb_Buscar_FormReporteCompras.DataSource = new BindingSource(headersReportesCompras, null);
        }

        private void CargarVentasPorFechas(DateTime fechaInicio, DateTime fechaFin)
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT * FROM TB_Venta 
                                    WHERE fecha_Creacion_Compra BETWEEN @fechaInicio AND @fechaFin";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin.ToString("yyyy-MM-dd"));

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);
                    dgv_Data_FormReporteVentas.DataSource = tabla;
                }

                ConfigurarHeadersGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ventas: {ex.Message}");
            }
        }

        private void ConfigurarHeadersGrid()
        {
            var headersEspanol = new Dictionary<string, string>
            {
                { "venta_ID", "IDENTIFICADOR DE VENTA" },
                { "tipo_Documento_Venta", "TIPO DE DOCUMENTO" },
                { "numero_Documento_Venta", "NUMERO DE DOCUMENTO" },
                { "tipo_Documento_Cliente_Venta", "DOCUMENTO DEL CLIENTE" },
                { "nombre_Cliente_Venta", "CLIENTE" },
                { "apellido_Paterno_Cliente_Venta", "APELLIDO PATERNO" },
                { "apellido_Materno_Cliente_Venta", "APELLIDO MATERNO" },
                { "monto_Pago_Venta", "PAGO" },
                { "monto_Cambio_Venta", "CAMBIO" },
                { "monto_Total_Venta", "TOTAL" },
                { "fecha_Creacion_Compra", "FECHA" },
                { "hora_Creacion_Compra", "HORA" },
                { "usuario_ID", "IDENTIFICADOR DE USUARIO" }
            };

            foreach (DataGridViewColumn col in dgv_Data_FormReporteVentas.Columns)
            {
                if (headersEspanol.TryGetValue(col.DataPropertyName, out string nombreColumna))
                {
                    col.HeaderText = nombreColumna;
                }
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void btn_Buscar_FormReporteVentas_Click(object sender, EventArgs e)
        {
            CargarVentasPorFechas(dateTimePicker_Inicio.Value, dateTimePicker_Final.Value);
        }

        private void FormReporteVentas_Load(object sender, EventArgs e)
        {
            dateTimePicker_Inicio.Value = DateTime.Today.AddDays(-30);
            dateTimePicker_Final.Value = DateTime.Today;
            OpcionesComboBox();
            CargarVentasPorFechas(dateTimePicker_Inicio.Value, dateTimePicker_Final.Value);
        }

        private void iconButton_Buscar_FormReporteVentas_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Buscar_FormReporteCompras.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona una columna para buscar", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                string columna = ((KeyValuePair<string, string>)cmb_Buscar_FormReporteCompras.SelectedItem).Key;
                string texto = txt_Buscar_FormReporteVentas.Text.Trim();

                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT * FROM TB_Venta 
                                    WHERE fecha_Creacion_Compra BETWEEN @fechaInicio AND @fechaFin";

                    if (!string.IsNullOrEmpty(texto))
                    {
                        query += $" AND [{columna}] LIKE @busqueda";
                    }

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@fechaInicio", dateTimePicker_Inicio.Value.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@fechaFin", dateTimePicker_Final.Value.ToString("yyyy-MM-dd"));

                    if (!string.IsNullOrEmpty(texto))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", $"%{texto}%");
                    }

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgv_Data_FormReporteVentas.DataSource = dt;

                    ConfigurarHeadersGrid();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}");
            }
        }

        private void iconButton_Vaciar_FormReporteVentas_Click(object sender, EventArgs e)
        {
            txt_Buscar_FormReporteVentas.Clear();
            CargarVentasPorFechas(dateTimePicker_Inicio.Value, dateTimePicker_Final.Value);
        }

        private void dateTimePicker_Inicio_ValueChanged(object sender, EventArgs e) { }
        private void cmb_BuscarClientes_FormReporteVentas_SelectedIndexChanged(object sender, EventArgs e) { }
        private void dateTimePicker_Final_ValueChanged(object sender, EventArgs e) { }
        private void cmb_Buscar_FormReporteCompras_SelectedIndexChanged(object sender, EventArgs e) { }
        private void txt_Buscar_FormReporteVentas_TextChanged(object sender, EventArgs e) { }
    }
}