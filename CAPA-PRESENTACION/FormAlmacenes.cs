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
using System.Windows.Media.Media3D;
using CAPA_DATOS;
using CAPA_ENTIDAD;

namespace CAPA_PRESENTACION
{
    public partial class FormAlmacenes : PADRE
    {
        public FormAlmacenes()
        {
            InitializeComponent();
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {

            CargarInventario(); //Metodo que carga la informacion de la TB_Almacen.

            var headersAlmacen = new Dictionary<string, string> 
            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
{            
            { "almacen_ID","IDENTIFICADOR DE ALMACEN"},
            { "nombre_Almacen","NOMBRE"},  
            { "estado_Actividad_Almacen", "ESTADO DE ACTIVIDAD" },
            { "direccion_ID", "DIRECCION" },
            { "capacidad_Almacen", "CAPACIDAD (m * m)" },
            { "stock_Almacen", "STOCK" },
            { "stock_Minimo_Almacen","STOCK MAXIMO"},
            { "stock_Maximo_Almacen","STOCK MAXIMO"},
            { "responsable_Almacen","RESPONSABLE"},
            { "fecha_Apertura_Almacen","FECHA DE APERTURA"}
            };

            foreach (DataGridViewColumn columna in dgv_Data_FormAlmacenes.Columns) //Se aplica en c/u de las columnas del dvg (Adan).
            {
                // Verifica si el name de la columna existe y devuelve el string nombreColumna que corresponde al segundo valor del diccionario (Adan). 
                if (headersAlmacen.TryGetValue(columna.DataPropertyName, out string nombreColumna))
                {
                    columna.HeaderText = nombreColumna; // 

                } else if 
                    (

                    columna.DataPropertyName == "almacen_ID" //||
                    //columna.DataPropertyName == ""

                    ){ 
                        columna.Visible = false; //Oculta a la columna de coincidir su name con alguna de las opciones especificadas.
                     }
            }

        }

        private void CargarInventario()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = "SELECT * FROM TB_Almacen"; //Selecciona todos los atributos de la TB_Almacen (Adan).

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgv_Data_FormAlmacenes.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }
    }
}
