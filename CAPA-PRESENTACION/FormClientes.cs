using CAPA_DATOS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class FormClientes : PADRE
    {
        public FormClientes()
        {
            InitializeComponent();
        }

        private void CargarClientes()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT * FROM TB_Cliente"; ; //Selecciona todos los atributos de la TB_Clientes (Adan).

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgv_Data_FormClientes.DataSource = tabla;

                }

                foreach (DataGridViewColumn columna in dgv_Data_FormClientes.Columns)
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
            var headersAlmacen = new Dictionary<string, string> 

            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
{
            { "cliente_ID","IDENTIFICADOR DE CLIENTE"},
            { "nombre_Cliente","NOMBRE"},
            { "apellido_Paterno_Cliente", "APELLIDO PATERNO" },
            { "apellido_Materno_Cliente", "APELLIDO MATERNO" },
            { "documento_Cliente", "DOCUMENTO" },
            { "correo_Cliente", "CORREO" },
            { "telefono_Cliente","TELEFONO"},
            { "estado_Actividad_Cliente","ESTADO DE ACTIVIDAD"},
            { "fecha_Registro_Cliente","FECHA DE REGISTRO"},
            { "hora_Registro_Cliente","HORA DE REGISTRO"}
            };

            cmb_Buscar_FormClientes.DisplayMember = "Value";
            cmb_Buscar_FormClientes.ValueMember = "Key";
            cmb_Buscar_FormClientes.DataSource = new BindingSource(headersAlmacen, null);
        }

        private void FormClientes_Load(object sender, EventArgs e)
        {
            try
            {
                CargarClientes(); //Llama al metodo que carga los clientes (Adan).

                cmb_Estado_FormClientes.Items.Add(new { Texto = "Activo", Valor = 1 });
                cmb_Estado_FormClientes.Items.Add(new { Texto = "Inactivo", Valor = 0 });
                cmb_Estado_FormClientes.DisplayMember = "Texto";
                cmb_Estado_FormClientes.ValueMember = "Valor";

                var headersAlmacen = new Dictionary<string, string> 
            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
            {
            { "cliente_ID","IDENTIFICADOR DE CLIENTE"},
            { "nombre_Cliente","NOMBRE"},
            { "apellido_Paterno_Cliente", "APELLIDO PATERNO" },
            { "apellido_Materno_Cliente", "APELLIDO MATERNO" },
            { "documento_Cliente", "DOCUMENTO" },
            { "correo_Cliente", "CORREO" },
            { "telefono_Cliente","TELEFONO"},
            { "estado_Actividad_Cliente","ESTADO DE ACTIVIDAD"},
            { "fecha_Registro_Cliente","FECHA DE REGISTRO"},
            { "hora_Registro_Cliente","HORA DE REGISTRO"}
            };

                foreach (DataGridViewColumn columna in dgv_Data_FormClientes.Columns) //Se aplica en c/u de las columnas del dvg (Adan).
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
            catch (Exception ex)
            {
                string mensajeError = $"Error: {ex.Message}\nTipo de excepción: {ex.GetType().Name}\nTraza de la pila: {ex.StackTrace}";
                MessageBox.Show(mensajeError);
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

                    string query = "INSERT INTO TB_Cliente (nombre_Cliente, apellido_Paterno_Cliente, apellido_Materno_Cliente, documento_Cliente, correo_Cliente, telefono_Cliente, estado_Actividad_Cliente) VALUES (@v1, @v2, @v3, @v4, @v5, @v6, @v7)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@v1", txt_Nombre_FormClientes.Text.ToString());
                        cmd.Parameters.AddWithValue("@v2", txt_NombrePaterno_FormClientes.Text.ToString());
                        cmd.Parameters.AddWithValue("@v3", txt_NombreMaterno_FormClientes.Text.ToString());
                        cmd.Parameters.AddWithValue("@v4", txt_Documento_FormClientes.Text.ToString());
                        cmd.Parameters.AddWithValue("@v5", txt_Correo_FormClientes.Text.ToString());
                        cmd.Parameters.AddWithValue("@v6", txt_Telefono_FormClientes.Text.ToString());


                        var estadoSeleccionado = cmb_Estado_FormClientes.SelectedItem;

                        int valorEstado = 0;

                        if (estadoSeleccionado != null)
                        {
                            var propiedad = estadoSeleccionado.GetType().GetProperty("Valor");

                            if (propiedad != null)
                            {
                                valorEstado = Convert.ToInt32(propiedad.GetValue(estadoSeleccionado) ?? 0);
                            }
                        }

                        valorEstado = (valorEstado == 1) ? 1 : 0;

                        cmd.Parameters.AddWithValue("@v7", valorEstado);

                        cmd.ExecuteNonQuery();
                    }
                }

                CargarClientes();
            }
            catch (Exception)
            {

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

        private void dgv_Data_FormClientes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow tupla = dgv_Data_FormClientes.CurrentRow;

                txt_Nombre_FormClientes.Text = tupla.Cells["nombre_Cliente"].Value?.ToString();
                txt_NombrePaterno_FormClientes.Text = tupla.Cells["apellido_Paterno_Cliente"].Value?.ToString();
                txt_NombreMaterno_FormClientes.Text = tupla.Cells["apellido_Materno_Cliente"].Value?.ToString();
                txt_Documento_FormClientes.Text = tupla.Cells["documento_Cliente"].Value?.ToString();
                txt_Correo_FormClientes.Text = tupla.Cells["correo_Cliente"].Value?.ToString();
                txt_Telefono_FormClientes.Text = tupla.Cells["telefono_Cliente"].Value?.ToString();

                var valorEstado = tupla.Cells["estado_Actividad_Cliente"].Value;

                if (valorEstado != null)
                {
                    foreach (var item in cmb_Estado_FormClientes.Items)
                    {
                        var prop = item.GetType().GetProperty("Valor");
                        if (prop != null && prop.GetValue(item)?.ToString() == valorEstado.ToString())
                        {
                            cmb_Estado_FormClientes.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    cmb_Estado_FormClientes.SelectedIndex = -1;
                }

                txt_ID_FormClientes.Text = tupla.Cells["cliente_ID"].Value?.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            if (dgv_Data_FormClientes.CurrentRow == null) return;
        }

        private void btn_Eliminar_FormClientes_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Data_FormClientes.CurrentRow == null) return; //Si no hay una fila seleccionada se acaba el proceso (Adan).

                int id = Convert.ToInt32(dgv_Data_FormClientes.CurrentRow.Cells["cliente_ID"].Value);

                if (MessageBox.Show("¿Quieres eliminar este registro?", "CONFIRMAR",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) //Mensaje que confirma el proceso de eliminacion (Adan).
                {
                    using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                    {
                        cn.Open();

                        SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TB_Cliente WHERE cliente_ID = @id", cn); //Elimina la tupla (Adan).

                        cmd.Parameters.AddWithValue("@id", id); //Asocia al registro con el valor de la variable (Adan).

                        cmd.ExecuteNonQuery();
                    }

                    CargarClientes();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Editar_FormClientes_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgv_Data_FormClientes.CurrentRow.Cells["cliente_ID"].Value); // Obtiene el ID del registro seleccionado (Adan).

                var estadoSeleccionado = cmb_Estado_FormClientes.SelectedItem;

                int valorEstado = 0;

                if (estadoSeleccionado != null)
                {
                    var propiedad = estadoSeleccionado.GetType().GetProperty("Valor");

                    if (propiedad != null)
                    {
                        valorEstado = Convert.ToInt32(propiedad.GetValue(estadoSeleccionado) ?? 0);
                    }
                }


                //var valorEstado = tupla.Cells["estado_Actividad_Cliente"].Value; 1

                if (valorEstado != null)
                {
                    foreach (var item in cmb_Estado_FormClientes.Items)
                    {
                        var prop = item.GetType().GetProperty("Valor");
                        if (prop != null && prop.GetValue(item)?.ToString() == valorEstado.ToString())
                        {
                            cmb_Estado_FormClientes.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    cmb_Estado_FormClientes.SelectedIndex = -1;
                }

                //txt_ID_FormClientes.Text = tupla.Cells["cliente_ID"].Value?.ToString(); 2
                // Almacena los nuevos valores de los campos (Adan).

                string nuevoNombreCliente = txt_Nombre_FormClientes.Text;
                string nuevoApellidoPaterno = txt_NombrePaterno_FormClientes.Text;
                string nuevoApellidoMaterno = txt_NombreMaterno_FormClientes.Text;
                string nuevoDocumento = txt_Documento_FormClientes.Text;
                string nuevoCorreo = txt_Correo_FormClientes.Text;
                string nuevoTelefono = txt_Telefono_FormClientes.Text;


                int nuevoEstadoActividad = valorEstado;
                int nuevoCliente = Convert.ToInt32(txt_ID_FormClientes.Text);


                if (dgv_Data_FormClientes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para editar"); // Valida que se haya seleccionado un registro (Adan).
                    return;
                }

                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();

                    string query = @"UPDATE TB_Cliente SET nombre_Cliente = @v1, apellido_Paterno_Cliente = @v2, apellido_Materno_Cliente =  @v3, documento_Cliente = @v4, correo_Cliente = @v5,  telefono_Cliente = @v6, estado_Actividad_Cliente =  @v7  WHERE cliente_ID = @id";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    cmd.Parameters.AddWithValue("@v1", nuevoNombreCliente.ToString());
                    cmd.Parameters.AddWithValue("@v2", nuevoApellidoPaterno.ToString());
                    cmd.Parameters.AddWithValue("@v3", nuevoApellidoMaterno.ToString());
                    cmd.Parameters.AddWithValue("@v4", nuevoDocumento.ToString());
                    cmd.Parameters.AddWithValue("@v5", nuevoCorreo.ToString());
                    cmd.Parameters.AddWithValue("@v6", nuevoTelefono.ToString());
                    cmd.Parameters.AddWithValue("@v7", nuevoEstadoActividad);

                    cmd.Parameters.AddWithValue("@id", id);

                    //var estadoSeleccionado = cmb_Estado_FormClientes.SelectedItem;

                    //int valorEstado = 0;

                    if (estadoSeleccionado != null)
                    {
                        var propiedad = estadoSeleccionado.GetType().GetProperty("Valor");

                        if (propiedad != null)
                        {
                            valorEstado = Convert.ToInt32(propiedad.GetValue(estadoSeleccionado) ?? 0);
                        }
                    }

                    valorEstado = (valorEstado == 1) ? 1 : 0;

                    cmd.Parameters.AddWithValue("@v7", valorEstado);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro modificado");

                    CargarClientes();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show($"Error al editar: {ex.Message}");
                throw;
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Buscar_FormClientes.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona una columna para buscar", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string columna = cmb_Buscar_FormClientes.SelectedValue.ToString();

                string texto = txt_Buscar_FormClientes.Text.Trim();

                string query = "SELECT * FROM TB_Cliente";

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

                    dgv_Data_FormClientes.DataSource = dt;
                }

                CAPA_PRESENTACION.Utilidades.FuncionesPersonalizadas.LimpiarControles(this); //Limpia los campos de texto (Adan).
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void iconButton_Restablecer_FormClientes_Click(object sender, EventArgs e)
        {
            CargarClientes();
        }
    }
}
