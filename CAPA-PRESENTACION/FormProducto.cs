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
    public partial class FormProducto : PADRE
    {
        public FormProducto()
        {
            InitializeComponent();
        }

        private void CargarArticulo()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT * FROM TB_Articulo"; ; //Selecciona todos los atributos de la TB_Clientes (Adan).

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgv_Data_FormArticulo.DataSource = tabla;

                }

                foreach (DataGridViewColumn columna in dgv_Data_FormArticulo.Columns)
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

        private void OpcionesComboBox()
        {
            var headersProducto = new Dictionary<string, string> 

            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
{
            { "articulo_ID","IDENTIFICADOR DE ARTICULO"},
            { "codigo_Articulo","CODIGO DE ARTICULO"},
            { "nombre_Articulo", "NOMBRE DE ARTICULO" },
            { "descripcion_Articulo", "DESCRIPCION DE ARTICULO" },
            { "documento_Cliente", "DOCUMENTO" },
            { "precio_Compra_Articulo", "PRECIO DE COMPRA" },
            { "fecha_Creacion_Articulo","FECHA DE REGISTRO"},
            { "hora_Creacion_Articulo","HORA DE REGISTRO"},
            { "fecha_Registro_Cliente","FECHA DE REGISTRO"},
            { "categoria_ID","CATEGORIA"},
            { "precio_Venta_Articulo","PRECIO DE VENTA"}

            };

            cmb_Buscar_FormArticulos.DisplayMember = "Value";
            cmb_Buscar_FormArticulos.ValueMember = "Key";
            cmb_Buscar_FormArticulos.DataSource = new BindingSource(headersProducto, null);
        }

        private void FormProducto_Load(object sender, EventArgs e)
        {
            try
            {
                CargarArticulo(); //Llama al metodo que carga los articulos (Adan).

                cmb_Rol_FormProducto.Items.Add(new { Texto = "Activo", Valor = 1 });
                cmb_Rol_FormProducto.Items.Add(new { Texto = "Inactivo", Valor = 0 });
                cmb_Rol_FormProducto.DisplayMember = "Texto";
                cmb_Rol_FormProducto.ValueMember = "Valor";

                cmb_Estado_FormProducto.Items.Add(new { Texto = "Activo", Valor = 1 });
                cmb_Estado_FormProducto.Items.Add(new { Texto = "Inactivo", Valor = 0 });
                cmb_Estado_FormProducto.DisplayMember = "Texto";
                cmb_Estado_FormProducto.ValueMember = "Valor";

                var headersArticulo = new Dictionary<string, string> 
            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
            {
            { "articulo_ID","IDENTIFICADOR DE ARTICULO"},
            { "codigo_Articulo","CODIGO DE ARTICULO"},
            { "nombre_Articulo", "NOMBRE DE ARTICULO" },
            { "descripcion_Articulo", "DESCRIPCION DE ARTICULO" },
            { "documento_Cliente", "DOCUMENTO" },
            { "precio_Compra_Articulo", "PRECIO DE COMPRA" },
            { "fecha_Creacion_Articulo","FECHA DE REGISTRO"},
            { "hora_Creacion_Articulo","HORA DE REGISTRO"},
            { "fecha_Registro_Cliente","FECHA DE REGISTRO"},
            { "categoria_ID","CATEGORIA"},
            { "precio_Venta_Articulo","PRECIO DE VENTA"}
            };

                foreach (DataGridViewColumn columna in dgv_Data_FormArticulo.Columns) //Se aplica en c/u de las columnas del dvg (Adan).
                {
                    // Verifica si el name de la columna existe y devuelve el string nombreColumna que corresponde al segundo valor del diccionario (Adan). 
                    if (headersArticulo.TryGetValue(columna.DataPropertyName, out string nombreColumna))
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
            catch (Exception ex)
            {
                string mensajeError = $"Error: {ex.Message}\nTipo de excepción: {ex.GetType().Name}\nTraza de la pila: {ex.StackTrace}";
                MessageBox.Show(mensajeError);
                throw;
            }
        }

        private void btn_Vaciar_FormProductos_Click(object sender, EventArgs e)
        {
            try
            {
                CAPA_PRESENTACION.Utilidades.FuncionesPersonalizadas.LimpiarControles(this); //Limpia los campos de texto (Adan).
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
