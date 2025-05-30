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

            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
{
            { "compra_ID","IDENTIFICADOR DE COMPRA"},
            { "tipo_Documento_Compra","TIPO DE DOCUMENTO"},
            { "numero_Documento_Compra", "NUMERO DE DOCUMENTO DE COMPRA" },
            { "monto_Total_Compra", "MONTO TOTAL DE COMPRA" },
            { "moneda_Compra", "UNIDAD MONETARIA"},
            { "fecha_Creacion_Compra", "FECHA DE CREACION" },
            { "hora_Creacion_Compra","HORA DE CREACION"},
            { "stock_Maximo_Almacen","STOCK MAXIMO"},
            { "usuario_ID","IDENTIFICADOR DE USUARIO"},
            { "cliente_ID","IDENTIFICADOR DE PROVEEDOR"}
            };

            cmb_Buscar_FormReporteCompras.DisplayMember = "Value";
            cmb_Buscar_FormReporteCompras.ValueMember = "Key";
            cmb_Buscar_FormReporteCompras.DataSource = new BindingSource(headersReportesCompras, null);
        }

        private void CargarReportesCompra()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT * FROM TB_Compra"; ; //Selecciona todos los atributos de la TB_Compras (Adan).

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dvg_ReporteCompras_FormReporteCompras.DataSource = tabla;

                }

                foreach (DataGridViewColumn columna in dvg_ReporteCompras_FormReporteCompras.Columns)
                {
                    columna.SortMode = DataGridViewColumnSortMode.NotSortable; //Inhabilita el ordenamiento al pulsar la cabecera en cada columna (Adan).
                }
            }
            catch (Exception ex)
            {
                string mensajeError = $"Error: {ex.Message}\nTipo de excepción: {ex.GetType().Name}\nTraza de la pila: {ex.StackTrace}";
                MessageBox.Show(mensajeError);
            }
        }

        private void FormReportesCompras_Load(object sender, EventArgs e)
        {

            try
            {
                CargarReportesCompra();
                CargarProveedores();

                dateTimePicker_Inicio.Value = DateTime.Today.AddDays(-30);
                dateTimePicker_Final.Value = DateTime.Today;

                var headersAlmacen = new Dictionary<string, string> 
            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
{
            { "compra_ID","IDENTIFICADOR DE COMPRA"},
            { "tipo_Documento_Compra","TIPO DE DOCUMENTO"},
            { "numero_Documento_Compra", "NUMERO DE DOCUMENTO DE COMPRA" },
            { "monto_Total_Compra", "MONTO TOTAL DE COMPRA" },
            { "moneda_Compra", "UNIDAD MONETARIA"},
            { "fecha_Creacion_Compra", "FECHA DE CREACION" },
            { "hora_Creacion_Compra","HORA DE CREACION"},
            { "stock_Maximo_Almacen","STOCK MAXIMO"},
            { "usuario_ID","IDENTIFICADOR DE USUARIO"},
            { "cliente_ID","IDENTIFICADOR DE PROVEEDOR"}
            };

                foreach (DataGridViewColumn columna in dvg_ReporteCompras_FormReporteCompras.Columns) //Se aplica en c/u de las columnas del dvg (Adan).
                {
                    // Verifica si el name de la columna existe y devuelve el string nombreColumna que corresponde al segundo valor del diccionario (Adan). 
                    if (headersAlmacen.TryGetValue(columna.DataPropertyName, out string nombreColumna))
                    {
                        columna.HeaderText = nombreColumna;
                    }

                    //if (columna.DataPropertyName == "almacen_ID")
                    //{
                    //    columna.Visible = false; //Oculta a la columna de coincidir su name con alguna de las opciones especificadas.
                    //}

                }

                OpcionesComboBox();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void dateTimePicker_Inicio_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_Final_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_BuscarProvedores_FormReporteCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void iconButton_BuscarEntre_FormReporteCompras_Click(object sender, EventArgs e)
        {
            
        }

        private void cmb_Buscar_FormReporteCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Buscar_FormReporteCompras_TextChanged(object sender, EventArgs e)
        {

        }

        private void iconButton_Buscar_FormReporteCompras_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Buscar_FormReporteCompras.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona una columna para buscar", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string columna = cmb_Buscar_FormReporteCompras.SelectedValue.ToString();

                string texto = txt_Buscar_FormReporteCompras.Text.Trim();

                string query = "SELECT * FROM TB_Compra";

                if (!string.IsNullOrEmpty(texto))
                {
                    query += $" WHERE \"{columna}\" LIKE @busqueda"; //Si no esta vaccio el registro continua con la consulta (Adan).
                }

                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    if (!string.IsNullOrEmpty(texto))
                    {
                        cmd.Parameters.AddWithValue("@busqueda", $"%{texto}%");
                    }

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(cmd);

                    DataTable dt = new DataTable();

                    adaptador.Fill(dt);

                    dvg_ReporteCompras_FormReporteCompras.DataSource = dt;
                }



                CAPA_PRESENTACION.Utilidades.FuncionesPersonalizadas.LimpiarControles(this); //Limpia los campos de texto (Adan).
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void iconButton_Vaciar_FormReporteCompras_Click(object sender, EventArgs e)
        {

        }

        private void dvg_ReporteCompras_FormReporteCompras_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
