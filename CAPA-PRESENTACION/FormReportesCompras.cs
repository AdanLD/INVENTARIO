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
                { "compra_ID","ID COMPRA"},
                { "tipo_Documento_Compra","TIPO DOC"},
                { "numero_Documento_Compra", "NUM DOC" },
                { "monto_Total_Compra", "MONTO" },
                { "moneda_Compra", "MONEDA"},
                { "fecha_Creacion_Compra", "FECHA" },
                { "hora_Creacion_Compra","HORA"},
                { "usuario_ID","ID USUARIO"},
                { "proveedor_ID","ID PROVEEDOR"}
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
                bool usarFiltroTexto = false;

                if (!string.IsNullOrEmpty(texto))
                {
                    if (cmb_Buscar_FormReporteCompras.SelectedItem == null)
                    {
                        MessageBox.Show("Selecciona una columna para buscar", "Advertencia",
                                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    columna = cmb_Buscar_FormReporteCompras.SelectedValue.ToString();
                    usarFiltroTexto = true;
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

                    if (usarFiltroTexto)
                    {
                        query += $" AND \"{columna}\" LIKE @busqueda";
                    }

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicio);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFin);

                    if (usarFiltroTexto)
                    {
                        cmd.Parameters.AddWithValue("@busqueda", $"%{texto}%");
                    }

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adaptador.Fill(dt);
                    dvg_ReporteCompras_FormReporteCompras.DataSource = dt;
                }

                // Configurar las cabeceras de las columnas
                var headersAlmacen = new Dictionary<string, string>
                {
                    { "compra_ID","ID COMPRA"},
                    { "tipo_Documento_Compra","TIPO DOC"},
                    { "numero_Documento_Compra", "NUM DOC" },
                    { "monto_Total_Compra", "MONTO" },
                    { "moneda_Compra", "MONEDA"},
                    { "fecha_Creacion_Compra", "FECHA" },
                    { "hora_Creacion_Compra","HORA"},
                    { "usuario_ID","ID USUARIO"},
                    { "proveedor_ID","ID PROVEEDOR"}
                };

                foreach (DataGridViewColumn col in dvg_ReporteCompras_FormReporteCompras.Columns)
                {
                    if (headersAlmacen.TryGetValue(col.DataPropertyName, out string nombreColumna))
                    {
                        col.HeaderText = nombreColumna;
                    }
                }

                // Deshabilitar ordenación en las columnas
                foreach (DataGridViewColumn columnaa in dvg_ReporteCompras_FormReporteCompras.Columns)
                {
                    columnaa.SortMode = DataGridViewColumnSortMode.NotSortable;
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
        }

        private void iconButton_BuscarEntre_FormReporteCompras_Click(object sender, EventArgs e)
        {
            BuscarConFiltros();
        }

        private void cmb_Buscar_FormReporteCompras_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void txt_Buscar_FormReporteCompras_TextChanged(object sender, EventArgs e)
        {
        }

        private void iconButton_Buscar_FormReporteCompras_Click(object sender, EventArgs e)
        {
            BuscarConFiltros();
        }

        private void iconButton_Vaciar_FormReporteCompras_Click(object sender, EventArgs e)
        {
            txt_Buscar_FormReporteCompras.Clear();
            BuscarConFiltros();
        }

        private void dvg_ReporteCompras_FormReporteCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}