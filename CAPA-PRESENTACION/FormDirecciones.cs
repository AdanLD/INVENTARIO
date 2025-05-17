using CAPA_DATOS;
using CAPA_ENTIDAD;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
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
                CargarDireccion();

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

                //foreach (DataGridViewColumn columna in dgv_Data_FormDirecciones.Columns) //Se aplica en c/u de las columnas del dvg (Adan).
                //{
                //    // Verifica si el name de la columna existe y devuelve el string nombreColumna que corresponde al segundo valor del diccionario (Adan). 
                //    if (headersAlmacen.TryGetValue(columna.DataPropertyName, out string nombreColumna))
                //    {
                //        columna.HeaderText = nombreColumna;
                //    }

                //    if (columna.DataPropertyName == "direccion_ID")
                //    {
                //        columna.Visible = false; //Oculta a la columna de coincidir su name con alguna de las opciones especificadas.
                //        dgv_Data_FormDirecciones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
                //    }

                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void txt_ID_FormUsuario_TextChanged(object sender, EventArgs e)
        {
        }

        private void btn_Guardar_FormDireccion_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txt_Calle_FormDireccion.Text))
                {
                    MessageBox.Show($"La calle es obligatoria. Por favor, inserta un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Valida el registro de la calle (Adan).
                    return;
                }

                if (string.IsNullOrEmpty(txt_Ciudad_FormDireccion.Text))
                {
                    MessageBox.Show($"La ciudad es obligatoria. Por favor, inserta un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Valida el registro de la calle (Adan).
                    return;
                }
                if (string.IsNullOrEmpty(txt_Estado_FormDireccion.Text))
                {
                    MessageBox.Show($"El estado es obligatorio. Por favor, inserta un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Valida el registro de la calle (Adan).
                    return;
                }
                if (string.IsNullOrEmpty(txt_CP_FormDireccion.Text))
                {
                    MessageBox.Show($"El CP es obligatorio. Por favor, inserta un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Valida el registro de la calle (Adan).
                    return;
                }

                if (string.IsNullOrEmpty(txt_Pais_FormDireccion.Text))
                {
                    MessageBox.Show($"El pais es obligatorio. Por favor, inserta un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Valida el registro de la calle (Adan).
                    return;
                }

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

        private void btn_Editar_FormDirecciones_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgv_Data_FormDirecciones.CurrentRow.Cells["direccion_ID"].Value); // Obtiene el ID del registro seleccionado (Adan).

                // Almacena los nuevos valores de los campos (Adan).
                string nuevaCalle = txt_Calle_FormDireccion.Text;
                string nuevaCiudad = txt_Ciudad_FormDireccion.Text;
                string nuevoEstado = txt_Estado_FormDireccion.Text;
                string nuevoCP = txt_CP_FormDireccion.Text;
                string nuevoPais = txt_Pais_FormDireccion.Text;
                string nuevasReferencias = txt_Referencias_FormDireccion.Text;

                if (string.IsNullOrEmpty(txt_Calle_FormDireccion.Text))
                {
                    MessageBox.Show($"La calle es obligatoria. Por favor, inserta un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Valida el registro de la calle (Adan).
                    return;
                }

                if (string.IsNullOrEmpty(txt_Ciudad_FormDireccion.Text))
                {
                    MessageBox.Show($"La ciudad es obligatoria. Por favor, inserta un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Valida el registro de la calle (Adan).
                    return;
                }
                if (string.IsNullOrEmpty(txt_Estado_FormDireccion.Text))
                {
                    MessageBox.Show($"El estado es obligatorio. Por favor, inserta un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Valida el registro de la calle (Adan).
                    return;
                }
                if (string.IsNullOrEmpty(txt_CP_FormDireccion.Text))
                {
                    MessageBox.Show($"El CP es obligatorio. Por favor, inserta un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Valida el registro de la calle (Adan).
                    return;
                }

                if (string.IsNullOrEmpty(txt_Pais_FormDireccion.Text))
                {
                    MessageBox.Show($"El pais es obligatorio. Por favor, inserta un valor valido", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Valida el registro de la calle (Adan).
                    return;
                }

                if (dgv_Data_FormDirecciones.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para editar"); // Valida que se haya seleccionado un registro (Adan).
                    return;
                }

                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();

                    string query = @"UPDATE TB_Direccion SET calle_Direccion = @v1, ciudad_Direccion = @v2, estado_Direccion = @v3, codigo_Postal_Direccion = @v4, pais_Direccion = @v5, referencias_Direccion = @v6 WHERE direccion_ID = @id";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);

                    cmd.Parameters.AddWithValue("@v1", nuevaCalle);
                    cmd.Parameters.AddWithValue("@v2", nuevaCiudad);
                    cmd.Parameters.AddWithValue("@v3", nuevoEstado);
                    cmd.Parameters.AddWithValue("@v4", nuevoCP);
                    cmd.Parameters.AddWithValue("@v5", nuevoPais);
                    cmd.Parameters.AddWithValue("@v6", nuevasReferencias);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro modificado");

                    CargarDireccion();
                }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgv_Data_FormDirecciones_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow tupla = dgv_Data_FormDirecciones.CurrentRow;

                //Almacena en los campos los valores de cada celda (Adan).
                txt_Calle_FormDireccion.Text = tupla.Cells["calle_Direccion"].Value?.ToString();
                txt_Ciudad_FormDireccion.Text = tupla.Cells["ciudad_Direccion"].Value?.ToString();
                txt_Estado_FormDireccion.Text = tupla.Cells["estado_Direccion"].Value?.ToString();
                txt_CP_FormDireccion.Text = tupla.Cells["codigo_Postal_Direccion"].Value?.ToString();
                txt_Pais_FormDireccion.Text = tupla.Cells["pais_Direccion"].Value?.ToString();
                txt_Referencias_FormDireccion.Text = tupla.Cells["referencias_Direccion"].Value?.ToString();
                txt_ID_FormDirecciones.Text = tupla.Cells["direccion_ID"].Value?.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            if (dgv_Data_FormDirecciones.CurrentRow == null) return;
        }

        private void iconButton3_Click(object sender, EventArgs e)
        {
            CAPA_PRESENTACION.Utilidades.FuncionesPersonalizadas.LimpiarControles(this); //Limpia los campos de texto (Adan).
        }
    }
}
