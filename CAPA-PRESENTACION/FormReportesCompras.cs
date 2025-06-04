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
    public partial class FormReportesCompras : Form
    {
        public FormReportesCompras()
        {
            InitializeComponent();
        }

        private void CargarProveedores()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = "SELECT proveedor_ID, nombre_Proveedor FROM TB_Proveedor";
                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);
                    DataTable tablaProveedores = new DataTable();
                    adaptador.Fill(tablaProveedores);

                    cmb_BuscarProvedores_FormReporteCompras.DisplayMember = "nombre_Proveedor";
                    cmb_BuscarProvedores_FormReporteCompras.ValueMember = "proveedor_ID";
                    cmb_BuscarProvedores_FormReporteCompras.DataSource = tablaProveedores;
                    cmb_BuscarProvedores_FormReporteCompras.SelectedIndex = -1; 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar proveedores: {ex.Message}");
            }
        }

        private void OpcionesComboBox()
        {
            var headersReportesCompras = new Dictionary<string, string>
            {
                { "compra_ID", "IDENTIFICADOR DE COMPRA" },
                { "tipo_Documento_Compra", "TIPO DE DOCUMENTO" },
                { "numero_Documento_Compra", "NUMERO DE DOCUMENTO" },
                { "monto_Total_Compra", "MONTO" },
                { "moneda_Compra", "MONEDA" },
                { "fecha_Creacion_Compra", "FECHA" },
                { "hora_Creacion_Compra", "HORA" },
                { "usuario_ID", "IDENTIFICADOR DE USUARIO" },
                { "proveedor_ID", "IDENTIFICADOR DE PROVEEDOR" }
            };

            cmb_Buscar_FormReporteCompras.DisplayMember = "Value";
            cmb_Buscar_FormReporteCompras.ValueMember = "Key";
            cmb_Buscar_FormReporteCompras.DataSource = new BindingSource(headersReportesCompras, null);
        }

        private void BuscarConFiltros()
        {
            try
            {
                string columna = "";
                string texto = txt_Buscar_FormReporteCompras.Text.Trim();
                bool usarFiltroTexto = !string.IsNullOrEmpty(texto);
                int proveedorID = -1;

                if (cmb_BuscarProvedores_FormReporteCompras.SelectedValue != null)
                {
                    proveedorID = Convert.ToInt32(cmb_BuscarProvedores_FormReporteCompras.SelectedValue);
                }

                if (usarFiltroTexto && cmb_Buscar_FormReporteCompras.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona una columna para buscar", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (usarFiltroTexto)
                {
                    columna = ((KeyValuePair<string, string>)cmb_Buscar_FormReporteCompras.SelectedItem).Key;
                }

                string fechaInicio = dateTimePicker_Inicio.Value.ToString("yyyy-MM-dd");
                string fechaFin = dateTimePicker_Final.Value.ToString("yyyy-MM-dd");

                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"
                        SELECT 
                            compra_ID,
                            tipo_Documento_Compra,
                            numero_Documento_Compra,
                            monto_Total_Compra,
                            moneda_Compra,
                            fecha_Creacion_Compra,
                            hora_Creacion_Compra,
                            usuario_ID,
                            proveedor_ID
                        FROM TB_Compra
                        WHERE fecha_Creacion_Compra BETWEEN @fechaInicio AND @fechaFin";

                    if (proveedorID > 0)
                    {
                        query += " AND proveedor_ID = @proveedorID";
                    }

                    if (usarFiltroTexto)
                    {
                        query += $" AND \"{columna}\" LIKE @busqueda";
                    }

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                    if (proveedorID > 0)
                    {
                        cmd.Parameters.AddWithValue("@proveedorID", proveedorID);
                    }

                    if (usarFiltroTexto)
                    {
                        cmd.Parameters.AddWithValue("@busqueda", $"%{texto}%");
                    }

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dvg_ReporteCompras_FormReporteCompras.DataSource = dt;
                }

                var headers = new Dictionary<string, string>
                {
                    { "compra_ID", "IDENTIFICADOR DE COMPRA" },
                    { "tipo_Documento_Compra", "TIPO DE DOCUMENTO" },
                    { "numero_Documento_Compra", "NUMERO DE DOCMENTO" },
                    { "monto_Total_Compra", "MONTO" },
                    { "moneda_Compra", "MONEDA" },
                    { "fecha_Creacion_Compra", "FECHA" },
                    { "hora_Creacion_Compra", "HORA" },
                    { "usuario_ID", "IDENTIFICADOR DE USUARIO" },
                    { "proveedor_ID", "IDENTIFICADOR DE PROVEEDOR" }
                };

                foreach (DataGridViewColumn col in dvg_ReporteCompras_FormReporteCompras.Columns)
                {
                    if (headers.TryGetValue(col.DataPropertyName, out string nombreColumna))
                    {
                        col.HeaderText = nombreColumna;
                    }
                    col.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error en la búsqueda: {ex.Message}");
            }
        }

        private void FormReportesCompras_Load(object sender, EventArgs e)
        {
            try
            {
                dateTimePicker_Inicio.Value = DateTime.Today.AddDays(-30);
                dateTimePicker_Final.Value = DateTime.Today;
                CargarProveedores();
                OpcionesComboBox();
                BuscarConFiltros();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el formulario: {ex.Message}");
            }
        }

        private void dateTimePicker_Inicio_ValueChanged(object sender, EventArgs e)
        {
            BuscarConFiltros();
        }

        private void dateTimePicker_Final_ValueChanged(object sender, EventArgs e)
        {
            BuscarConFiltros();
        }

        private void cmb_BuscarProvedores_FormReporteCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
            BuscarConFiltros(); 
        }

        private void iconButton_BuscarEntre_FormReporteCompras_Click(object sender, EventArgs e)
        {
            BuscarConFiltros();
        }

        private void iconButton_Buscar_FormReporteCompras_Click(object sender, EventArgs e)
        {
            BuscarConFiltros();
        }

        private void iconButton_Vaciar_FormReporteCompras_Click(object sender, EventArgs e)
        {
            txt_Buscar_FormReporteCompras.Clear();
            cmb_BuscarProvedores_FormReporteCompras.SelectedIndex = -1;
            BuscarConFiltros();
        }
    }
}