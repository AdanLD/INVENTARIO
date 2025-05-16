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
            try
            {
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
                        columna.Visible = true; //Oculta a la columna de coincidir su name con alguna de las opciones especificadas.
                        dgv_Data_FormDirecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            dgv_Data_FormDirecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader; //Ajusta el tamaño de las columnas al contenido (Adan).


        }

        private void txt_ID_FormUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_FormDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                //if (string.IsNullOrEmpty(txt_Calle_FormDireccion.Text) || txt_Calle_FormDireccion.Text == null)
                //{
                //    throw new Exception("La calle es obligatoria"); //Valida el registro de la calle (Adan).
                //}

                //if (string.IsNullOrEmpty(txt_Ciudad_FormDireccion.Text))
                //{
                //    throw new Exception("La ciudad es obligatoria"); //Valida el registro de la ciudad (Adan).
                //}
                //if (string.IsNullOrEmpty(txt_Estado_FormDireccion.Text)) 
                //{
                //    throw new Exception("El estado es obligatorio"); //Valida el registro del estado (Adan).
                //}
                //if (string.IsNullOrEmpty(txt_CP_FormDireccion.Text)) 
                //{
                //    throw new Exception("El código postal es obligatorio"); //Valida el registro del CP (Adan).
                //}

                //if (string.IsNullOrEmpty(txt_Pais_FormDireccion.Text))
                //{
                //    throw new Exception("El país es obligatorio"); //Valida el registro del pais (Adan).
                //}

                using (SQLiteConnection conexion = new SQLiteConnection(Conectar.cadena))
                {
                    conexion.Open();

                    string query = "INSERT INTO TB_Direccion (calle_Direccion, ciudad_Direccion, estado_Direccion, codigo_Postal_Direccion, pais_Direccion, referencias_Direccion) VALUES (@v1, @v2, @v3, @v4, @v5, @v6)";

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);

                    cmd.Parameters.AddWithValue("@v1", Convert.ToString(txt_Calle_FormDireccion.Text));
                    cmd.Parameters.AddWithValue("@v2", Convert.ToString(txt_Ciudad_FormDireccion.Text));
                    cmd.Parameters.AddWithValue("@v3", Convert.ToString(txt_Estado_FormDireccion.Text));
                    cmd.Parameters.AddWithValue("@v4", Convert.ToString(txt_CP_FormDireccion.Text));
                    cmd.Parameters.AddWithValue("@v5", Convert.ToString(txt_Pais_FormDireccion.Text));
                    cmd.Parameters.AddWithValue("@v6", Convert.ToString(txt_Referencias_FormDireccion.Text));

                    cmd.ExecuteNonQuery();
                }

                CargarDireccion(); // Actualiza el dvg (Adan).
            }
            catch (Exception)
            {
                throw;
            }

        }

        private void btn_Eliminar_FormDirecciones_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Data_FormDirecciones.CurrentRow == null) return;

                int id = Convert.ToInt32(dgv_Data_FormDirecciones.CurrentRow.Cells["direccion_ID"].Value);

                if (MessageBox.Show("¿Quieres eliminar este registro?", "CONFIRMAR",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                    {
                        cn.Open();

                        SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TB_Direccion WHERE direccion_ID = @id", cn);

                        cmd.Parameters.AddWithValue("@id", id);

                        cmd.ExecuteNonQuery();
                    }
                    CargarDireccion(); 
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
