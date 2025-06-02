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

namespace CAPA_PRESENTACION
{
    public partial class FormReportesVentasF : PADRE
    {
        public FormReportesVentasF()
        {
            InitializeComponent();
        }

        private void FormReportesVentasF_Load(object sender, EventArgs e)
        {
            dateTimePicker_Inicio.Value = DateTime.Today.AddDays(-30);
            dateTimePicker_Final.Value = DateTime.Today;

            // Configurar combobox de búsqueda
            ConfigurarComboBoxBusqueda();

            // Cargar datos iniciales
            CargarVentas();
        }

        private void ConfigurarComboBoxBusqueda()
        {
            cmb_Buscar_FormReporteCompras.Items.Clear();
            cmb_Buscar_FormReporteCompras.DisplayMember = "Text";
            cmb_Buscar_FormReporteCompras.ValueMember = "Value";

            // Agregar opciones de búsqueda relevantes
            cmb_Buscar_FormReporteCompras.Items.Add(new { Text = "Número Documento", Value = "numero_Documento_Venta" });
            cmb_Buscar_FormReporteCompras.Items.Add(new { Text = "Nombre Cliente", Value = "nombre_Cliente_Venta" });
            cmb_Buscar_FormReporteCompras.Items.Add(new { Text = "Tipo Documento", Value = "tipo_Documento_Venta" });
            cmb_Buscar_FormReporteCompras.Items.Add(new { Text = "ID Venta", Value = "venta_ID" });

            cmb_Buscar_FormReporteCompras.SelectedIndex = 0;
        }


        private void CargarVentas()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = "SELECT * FROM TB_Venta";
                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgv_Data_FormReporteVentas.DataSource = dt;

                    // Aplicar formato al DataGridView
                    FormatearDataGridView();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar ventas: {ex.Message}");
            }
        }

        private void FormatearDataGridView()
        {
            // Ocultar columnas no relevantes
            if (dgv_Data_FormReporteVentas.Columns.Contains("venta_ID"))
                dgv_Data_FormReporteVentas.Columns["venta_ID"].Visible = false;

            // Configurar nombres de columnas
            var headers = new (string Original, string Nuevo)[]
            {
                ("numero_Documento_Venta", "N° Documento"),
                ("tipo_Documento_Venta", "Tipo Documento"),
                ("nombre_Cliente_Venta", "Cliente"),
                ("monto_Total_Venta", "Total"),
                ("fecha_Creacion_Compra", "Fecha")
            };

            foreach (var header in headers)
            {
                if (dgv_Data_FormReporteVentas.Columns.Contains(header.Original))
                {
                    dgv_Data_FormReporteVentas.Columns[header.Original].HeaderText = header.Nuevo;
                }
            }

            // Formato monetario
            if (dgv_Data_FormReporteVentas.Columns.Contains("monto_Total_Venta"))
            {
                dgv_Data_FormReporteVentas.Columns["monto_Total_Venta"].DefaultCellStyle.Format = "C2";
                dgv_Data_FormReporteVentas.Columns["monto_Total_Venta"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            }
        }

        private void dateTimePicker_Inicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_Final_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btn_Buscar_FormReporteVentas_Click(object sender, EventArgs e)
        {
            FiltrarPorFechas();
        }

        private void FiltrarPorFechas()
        {
            DateTime fechaInicio = dateTimePicker_Inicio.Value.Date;
            DateTime fechaFin = dateTimePicker_Final.Value.Date.AddDays(1); // Incluir todo el día final

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT * FROM TB_Venta 
                                   WHERE fecha_Creacion_Compra >= @fechaInicio 
                                   AND fecha_Creacion_Compra < @fechaFin";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin.ToString("yyyy-MM-dd"));

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgv_Data_FormReporteVentas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al filtrar por fechas: {ex.Message}");
            }
        }

        private void cmb_Buscar_FormReporteCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Buscar_FormReporteVentas_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton_Buscar_FormReporteVentas_Click(object sender, EventArgs e)
        {

        }

        private void iconButton_Vaciar_FormReporteVentas_Click(object sender, EventArgs e)
        {
            // Restablecer controles
            dateTimePicker_Inicio.Value = DateTime.Today.AddDays(-30);
            dateTimePicker_Final.Value = DateTime.Today;
            txt_Buscar_FormReporteVentas.Clear();
            cmb_Buscar_FormReporteCompras.SelectedIndex = 0;

            // Recargar todos los datos
            CargarVentas();
        }

        private void dgv_Data_FormReporteVentas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_Buscar_FormReporteVentas_TextChanged(object sender, EventArgs e)
        {
            if (cmb_Buscar_FormReporteCompras.SelectedItem == null)
            {
                MessageBox.Show("Seleccione una columna para buscar");
                return;
            }

            string texto = txt_Buscar_FormReporteVentas.Text.Trim();
            if (string.IsNullOrEmpty(texto))
            {
                MessageBox.Show("Ingrese texto de búsqueda");
                return;
            }

            string columna = (cmb_Buscar_FormReporteCompras.SelectedItem as dynamic).Value;
            string query = $"SELECT * FROM TB_Venta WHERE {columna} LIKE @busqueda";

            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@busqueda", $"%{texto}%");

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dgv_Data_FormReporteVentas.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}");
            }
        }

        
    }
}
