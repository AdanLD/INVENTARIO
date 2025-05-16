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
    public partial class FormDirecciones : PADRE
    {
        public FormDirecciones()
        {
            InitializeComponent();
        }

        private void CargarDireccion()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = "SELECT * FROM TB_Direccion"; //Selecciona todos los atributos de la TB_Direccion (Adan).

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgv_Data_FormDirecciones.DataSource = tabla;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormDirecciones_Load(object sender, EventArgs e)
        {
            dgv_Data_FormDirecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader; //Ajusta el tamaño de las columnas al contenido (Adan).

            CargarDireccion(); //Metodo que carga la informacion de la TB_Direccion.

            //cmb_Estado_FormAlmacenes.Items.Add(new { Texto = "Activo", Valor = 1 });
            //cmb_Estado_FormAlmacenes.Items.Add(new { Texto = "Inactivo", Valor = 0 });
            //cmb_Estado_FormAlmacenes.DisplayMember = "Texto";
            //cmb_Estado_FormAlmacenes.ValueMember = "Valor";

            var headersAlmacen = new Dictionary<string, string> 
            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
{
            { "direccion_ID","IDENTIFICADOR DE DIRECCION"},
            { "calle_Direccion","CALLE"},
            { "ciudad_Direccion", "CIUDAD" },
            { "estado_Direccion", "ESTADO" },
            { "codigo_Postal_Direccion", "CP" },
            { "pais_Direccion","PAIS"},
            { "referencias_Direccion","REFERENCIAS"},
            };



            foreach (DataGridViewColumn columna in dgv_Data_FormDirecciones.Columns) //Se aplica en c/u de las columnas del dvg (Adan).
            {
                // Verifica si el name de la columna existe y devuelve el string nombreColumna que corresponde al segundo valor del diccionario (Adan). 
                if (headersAlmacen.TryGetValue(columna.DataPropertyName, out string nombreColumna))
                {
                    columna.HeaderText = nombreColumna;
                }

                if (columna.DataPropertyName == "direccion_ID")
                {
                    columna.Visible = false; //Oculta a la columna de coincidir su name con alguna de las opciones especificadas.
                    dgv_Data_FormDirecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                }


            }
        }
    }
}
