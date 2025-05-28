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
    public partial class FormCategoria : PADRE
    {
        public FormCategoria()
        {
            InitializeComponent();
        }

        private void CargarCategoria()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT * FROM TB_Categoria"; ; //Selecciona todos los atributos de la TB_Categoria (Adan).

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgv_Data_FormCategoria.DataSource = tabla;

                }

                foreach (DataGridViewColumn columna in dgv_Data_FormCategoria.Columns)
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
            var headersCategoria = new Dictionary<string, string> 

            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
            {
            { "categoria_ID","IDENTIFICADOR DE CATEGORIA"},
            { "nombre_Categoria","NOMBRE"},
            { "descripcion_Categoria", "DESCRIPCION" },
            { "fecha_Creacion_Categoria", "FECHA DE CREACION" },
            { "hora_Creacion_Categoria", "HORA DE CREACION" }
            };

            cmb_Buscar_FormCategoria.DisplayMember = "Value";
            cmb_Buscar_FormCategoria.ValueMember = "Key";
            cmb_Buscar_FormCategoria.DataSource = new BindingSource(headersCategoria, null);
        }

        private void FormCategoria_Load(object sender, EventArgs e)
        {
            try
            {
                CargarCategoria(); //Llama al metodo que carga los clientes (Adan).

                var headersCategoria = new Dictionary<string, string> 
            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
            {
            { "categoria_ID","IDENTIFICADOR DE CATEGORIA"},
            { "nombre_Categoria","NOMBRE"},
            { "descripcion_Categoria", "DESCRIPCION" },
            { "fecha_Creacion_Categoria", "FECHA DE CREACION" },
            { "hora_Creacion_Categoria", "HORA DE CREACION" }
            };

                foreach (DataGridViewColumn columna in dgv_Data_FormCategoria.Columns) //Se aplica en c/u de las columnas del dvg (Adan).
                {
                    // Verifica si el name de la columna existe y devuelve el string nombreColumna que corresponde al segundo valor del diccionario (Adan). 
                    if (headersCategoria.TryGetValue(columna.DataPropertyName, out string nombreColumna))
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

        private void btn_Vaciar_FormAlmacenes_Click(object sender, EventArgs e)
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

        private void btn_Guardar_FormUsuario_Click(object sender, EventArgs e)
        {
            try
            {

                using (SQLiteConnection conexion = new SQLiteConnection(Conectar.cadena))
                {
                    conexion.Open();

                    string query = "INSERT INTO TB_Categoria (nombre_Categoria, descripcion_Categoria) VALUES (@v1, @v2)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@v1", txt_Nombre_FormCategoria.Text);
                        cmd.Parameters.AddWithValue("@v2", txt_Descripcion_FormCategoria.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                CargarCategoria();
            }
            catch (Exception)
            {
                throw;
            }
        }


        private void dgv_Data_FormCategoria_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow tupla = dgv_Data_FormCategoria.CurrentRow;

                txt_ID_FormCategoria.Text = tupla.Cells["categoria_ID"].Value?.ToString();
                txt_Nombre_FormCategoria.Text = tupla.Cells["nombre_Categoria"].Value?.ToString();
                txt_Descripcion_FormCategoria.Text = tupla.Cells["descripcion_Categoria"].Value?.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            if (dgv_Data_FormCategoria.CurrentRow == null) return;
        }

        private void btn_Editar_FormCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgv_Data_FormCategoria.CurrentRow.Cells["categoria_ID"].Value); // Obtiene el ID del registro seleccionado (Adan).

                string nuevoNombreCategoria = txt_Nombre_FormCategoria.Text;
                string nuevaDescripcion = txt_Descripcion_FormCategoria.Text;

                if (dgv_Data_FormCategoria.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para editar"); // Valida que se haya seleccionado un registro (Adan).
                    return;
                }

                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();

                    string query = @"UPDATE TB_Categoria SET nombre_Categoria = @v1, descripcion_Categoria = @v2 WHERE categoria_ID = @id";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);

                    cmd.Parameters.AddWithValue("@v1", nuevoNombreCategoria);
                    cmd.Parameters.AddWithValue("@v2", nuevaDescripcion);

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro modificado");

                    CargarCategoria();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Eliminar_FormCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Data_FormCategoria.CurrentRow == null) return; //Si no hay una fila seleccionada se acaba el proceso (Adan).

                int id = Convert.ToInt32(dgv_Data_FormCategoria.CurrentRow.Cells["categoria_ID"].Value);

                if (MessageBox.Show("¿Quieres eliminar este registro?", "CONFIRMAR",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) //Mensaje que confirma el proceso de eliminacion (Adan).
                {
                    using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                    {
                        cn.Open();

                        SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TB_Categoria WHERE categoria_ID = @id", cn); //Elimina la tupla (Adan).

                        cmd.Parameters.AddWithValue("@id", id); //Asocia al registro con el valor de la variable (Adan).

                        cmd.ExecuteNonQuery();
                    }

                    CargarCategoria();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Buscar_FormCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Buscar_FormCategoria.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona una columna para buscar", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string columna = cmb_Buscar_FormCategoria.SelectedValue.ToString();

                string texto = txt_Buscar_FormCategoria.Text.Trim();

                string query = "SELECT * FROM TB_Categoria";

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

                    dgv_Data_FormCategoria.DataSource = dt;
                }



                CAPA_PRESENTACION.Utilidades.FuncionesPersonalizadas.LimpiarControles(this); //Limpia los campos de texto (Adan).
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Limpiar_FormCategoria_Click(object sender, EventArgs e)
        {
            try
            {
                CargarCategoria();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
