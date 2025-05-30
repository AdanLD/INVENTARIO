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
    public partial class FormReporteVentas : Form
    {
        public FormReporteVentas()
        {
            InitializeComponent();
        }

        private void OpcionesComboBox()
        {
            var headersReportesCompras = new Dictionary<string, string> 

                //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
{
            { "venta_ID","IDENTIFICADOR DE VENTA"},
            { "tipo_Documento_Venta","TIPO DE DOCUMENTO"},
            { "numero_Documento_Venta", "NUMERO DE DOCUMENTO DE VENTA" },
            { "tipo_Documento_Cliente_Venta", "TIPO DE DOCUMENTO DE CLIENTE" },
            { "nombre_Cliente_Venta", "NOMBRE DE CLIENTE"},
            { "apellido_Paterno_Cliente_Venta", "APELLIDO PATERNO DEL CLIENTE" },
            { "apellido_Materno_Cliente_Venta","APELLIDO MATERNO DEL CLIENTE"},
            { "stock_Maximo_Almacen","STOCK MAXIMO"},
            { "monto_Pago_Venta","MONTO DE PAGO"},
            { "monto_Cambio_Venta","MONTO DE CAMBIO"},
            { "monto_Total_Venta","MONTO TOTAL DE VENTA"},
            { "fecha_Creacion_Compra","FECHA DE CREACION"},
            { "hora_Creacion_Compra","HORA DE CREACION"},
            { "usuario_ID","IDENTIFICADOR DE USUARIO"}
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
                    // Formatear fechas para SQLite (YYYY-MM-DD)
                    string fechaInicioStr = fechaInicio.ToString("yyyy-MM-dd");
                    string fechaFinStr = fechaFin.ToString("yyyy-MM-dd");

                    string query = @"SELECT * FROM TB_Venta 
                                   WHERE fecha_Creacion_Venta BETWEEN @fechaInicio AND @fechaFin";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@fechaInicio", fechaInicioStr);
                    cmd.Parameters.AddWithValue("@fechaFin", fechaFinStr);

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(cmd);
                    DataTable tabla = new DataTable();
                    adaptador.Fill(tabla);

                    dgv_Data_FormReporteVentas.DataSource = tabla;
                }

                foreach (DataGridViewColumn columna in dgv_Data_FormReporteVentas.Columns)
                {
                    columna.SortMode = DataGridViewColumnSortMode.NotSortable;
                }
            }
            catch (Exception ex)
            {
                string mensajeError = $"Error: {ex.Message}\nTipo de excepción: {ex.GetType().Name}\nTraza de la pila: {ex.StackTrace}";
                MessageBox.Show(mensajeError);
            }
        }

        private void CargarReportesCompra()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT * FROM TB_Venta"; ; //Selecciona todos los atributos de la TB_Compras (Adan).

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgv_Data_FormReporteVentas.DataSource = tabla;

                }

                foreach (DataGridViewColumn columna in dgv_Data_FormReporteVentas.Columns)
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

        private void btn_Buscar_FormReporteVentas_Click(object sender, EventArgs e)
        {
            try
            {
                CargarReporteVentas(); //Metodo que carga la informacion de la TB_Almacen (Adan).
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void CargarReporteVentas()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT * FROM TB_Venta"; ; //Selecciona todos los atributos de la TB_Proveedor (Adan).

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgv_Data_FormReporteVentas.DataSource = tabla;

                }

                foreach (DataGridViewColumn columna in dgv_Data_FormReporteVentas.Columns)
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

        private void FormReporteVentas_Load(object sender, EventArgs e)
        {
            try
            {
                CargarReportesCompra(); //Metodo que carga la informacion de la TB_Almacen.

                dateTimePicker_Inicio.Value = DateTime.Today.AddDays(-30);
                dateTimePicker_Final.Value = DateTime.Today;

                var headersAlmacen = new Dictionary<string, string> 
            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
{
            { "venta_ID","IDENTIFICADOR DE VENTA"},
            { "tipo_Documento_Venta","TIPO DE DOCUMENTO"},
            { "numero_Documento_Venta", "NUMERO DE DOCUMENTO DE VENTA" },
            { "tipo_Documento_Cliente_Venta", "TIPO DE DOCUMENTO DE CLIENTE" },
            { "nombre_Cliente_Venta", "NOMBRE DE CLIENTE"},
            { "apellido_Paterno_Cliente_Venta", "APELLIDO PATERNO DEL CLIENTE" },
            { "apellido_Materno_Cliente_Venta","APELLIDO MATERNO DEL CLIENTE"},
            { "stock_Maximo_Almacen","STOCK MAXIMO"},
            { "monto_Pago_Venta","MONTO DE PAGO"},
            { "monto_Cambio_Venta","MONTO DE CAMBIO"},
            { "fecha_Creacion_Compra","FECHA DE CREACION"},
            { "hora_Creacion_Compra","HORA DE CREACION"},
            { "usuario_ID","IDENTIFICADOR DE USUARIO"}
            };

                foreach (DataGridViewColumn columna in dgv_Data_FormReporteVentas.Columns) //Se aplica en c/u de las columnas del dvg (Adan).
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

        private void cmb_BuscarClientes_FormReporteVentas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker_Final_ValueChanged(object sender, EventArgs e)
        {

        }

        private void cmb_Buscar_FormReporteCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt_Buscar_FormReporteVentas_TextChanged(object sender, EventArgs e)
        {

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


                string columna = cmb_Buscar_FormReporteCompras.SelectedValue.ToString();

                string texto = txt_Buscar_FormReporteVentas.Text.Trim();

                string query = "SELECT * FROM TB_Venta";

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

                    dgv_Data_FormReporteVentas.DataSource = dt;
                }



                CAPA_PRESENTACION.Utilidades.FuncionesPersonalizadas.LimpiarControles(this); //Limpia los campos de texto (Adan).
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void iconButton_Vaciar_FormReporteVentas_Click(object sender, EventArgs e)
        {

        }
    }
}
