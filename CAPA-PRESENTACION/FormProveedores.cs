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
    public partial class FormProveedores : PADRE
    {
        public FormProveedores()
        {
            InitializeComponent();
        }

        private void CargarProveedor()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT * FROM TB_Proveedor"; ; //Selecciona todos los atributos de la TB_Proveedor (Adan).

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgv_Data_FormProveedor.DataSource = tabla;

                }

                foreach (DataGridViewColumn columna in dgv_Data_FormProveedor.Columns)
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
            var headersProveedor = new Dictionary<string, string> 

            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
{
            { "proveedor_ID","IDENTIFICADOR DEL PROVEEDOR"},
            { "nombre_Proveedor","NOMBRE"},
            { "direccion_ID", "DIRECCION" },
            { "correo_Proveedor", "CORREO" },
            { "estado_Proveedor", "ESTADO DE ACTIVIDAD" },
            { "fecha_Creacion_Proveedor", "FECHA DE REGISTRO" },
            { "telefono_Cliente","TELEFONO"},
            { "hora_Creacion_Proveedor","HORA DE REGISTRO"},
            { "fecha_Registro_Cliente","FECHA DE REGISTRO"},
            { "numero_Telefonico_Proveedor","NUMERO TELEFONICO"},
            { "razonSocial_Proveedor","RAZON SOCIAL"}

            };

            cmb_Buscar_FormProveedor.DisplayMember = "Value";
            cmb_Buscar_FormProveedor.ValueMember = "Key";
            cmb_Buscar_FormProveedor.DataSource = new BindingSource(headersProveedor, null);
        }
        private void FormProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                CargarProveedor(); //Llama al metodo que carga los proveedores (Adan).

                cmb_Estado_FormProveedor.Items.Add(new { Texto = "Activo", Valor = 1 });
                cmb_Estado_FormProveedor.Items.Add(new { Texto = "Inactivo", Valor = 0 });
                cmb_Estado_FormProveedor.DisplayMember = "Texto";
                cmb_Estado_FormProveedor.ValueMember = "Valor";

                var headersProveedor = new Dictionary<string, string> 
            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
            {
            { "proveedor_ID","IDENTIFICADOR DEL PROVEEDOR"},
            { "nombre_Proveedor","NOMBRE"},
            { "direccion_ID", "DIRECCION" },
            { "correo_Proveedor", "CORREO" },
            { "estado_Proveedor", "ESTADO DE ACTIVIDAD" },
            { "fecha_Creacion_Proveedor", "FECHA DE REGISTRO" },
            { "telefono_Cliente","TELEFONO"},
            { "hora_Creacion_Proveedor","HORA DE REGISTRO"},
            { "fecha_Registro_Cliente","FECHA DE REGISTRO"},
            { "numero_Telefonico_Proveedor","NUMERO TELEFONICO"},
            { "razonSocial_Proveedor","RAZON SOCIAL"}

            };

                foreach (DataGridViewColumn columna in dgv_Data_FormProveedor.Columns) //Se aplica en c/u de las columnas del dvg (Adan).
                {
                    // Verifica si el name de la columna existe y devuelve el string nombreColumna que corresponde al segundo valor del diccionario (Adan). 
                    if (headersProveedor.TryGetValue(columna.DataPropertyName, out string nombreColumna))
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

                    string query = "INSERT INTO TB_Proveedor (nombre_Proveedor, razonSocial_Proveedor, correo_Proveedor, direccion_ID, estado_Proveedor, numero_Telefonico_Proveedor) VALUES (@v1, @v2, @v3, @v4, @v5, @v6)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@v1", txt_Nombre_FormProveedor.Text);
                        cmd.Parameters.AddWithValue("@v2", txt_RazonSocial_FormProveedor.Text);
                        cmd.Parameters.AddWithValue("@v3", txt_Correo_FormProveedor.Text);
                        cmd.Parameters.AddWithValue("@v4", txt_Direccion_FormProveedor.Text);


                        var estadoSeleccionado = cmb_Estado_FormProveedor.SelectedItem;

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

                        cmd.Parameters.AddWithValue("@v5", valorEstado);
                        cmd.Parameters.AddWithValue("@v6", txt_Telefono_FormProveedor.Text);


                        cmd.ExecuteNonQuery();
                    }
                }

                CargarProveedor();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Data_FormProveedor_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow tupla = dgv_Data_FormProveedor.CurrentRow;

                txt_ID_FormProveedor.Text = tupla.Cells["proveedor_ID"].Value?.ToString();
                txt_Nombre_FormProveedor.Text = tupla.Cells["nombre_Proveedor"].Value?.ToString();
                txt_Direccion_FormProveedor.Text = tupla.Cells["direccion_ID"].Value?.ToString();
                txt_RazonSocial_FormProveedor.Text = tupla.Cells["razonSocial_Proveedor"].Value?.ToString();
                txt_Correo_FormProveedor.Text = tupla.Cells["correo_Proveedor"].Value?.ToString();

                var valorEstado = tupla.Cells["estado_Proveedor"].Value;

                if (valorEstado != null)
                {
                    foreach (var item in cmb_Estado_FormProveedor.Items)
                    {
                        var prop = item.GetType().GetProperty("Valor");
                        if (prop != null && prop.GetValue(item)?.ToString() == valorEstado.ToString())
                        {
                            cmb_Estado_FormProveedor.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    cmb_Estado_FormProveedor.SelectedIndex = -1;
                }

                txt_Telefono_FormProveedor.Text = tupla.Cells["numero_Telefonico_Proveedor"].Value?.ToString();

            }
            catch (Exception)
            {
                throw;
            }
            if (dgv_Data_FormProveedor.CurrentRow == null) return;
        }

        private void btn_Eliminar_FormUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Data_FormProveedor.CurrentRow == null) return; //Si no hay una fila seleccionada se acaba el proceso (Adan).

                int id = Convert.ToInt32(dgv_Data_FormProveedor.CurrentRow.Cells["proveedor_ID"].Value);

                if (MessageBox.Show("¿Quieres eliminar este registro?", "CONFIRMAR",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) //Mensaje que confirma el proceso de eliminacion (Adan).
                {
                    using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                    {
                        cn.Open();

                        SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TB_Proveedor WHERE proveedor_ID = @id", cn); //Elimina la tupla (Adan).

                        cmd.Parameters.AddWithValue("@id", id); //Asocia al registro con el valor de la variable (Adan).

                        cmd.ExecuteNonQuery();
                    }

                    CargarProveedor();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Editar_FormUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dgv_Data_FormProveedor.CurrentRow.Cells["proveedor_ID"].Value); // Obtiene el ID del registro seleccionado (Adan).

                var estadoSeleccionado = cmb_Estado_FormProveedor.SelectedItem;

                int valorEstado = 0;

                if (estadoSeleccionado != null)
                {
                    var propiedad = estadoSeleccionado.GetType().GetProperty("Valor");

                    if (propiedad != null)
                    {
                        valorEstado = Convert.ToInt32(propiedad.GetValue(estadoSeleccionado) ?? 0);
                    }
                }

                // Almacena los nuevos valores de los campos (Adan).

                int nuevoEstadoActividad = valorEstado;
                string nuevoNombreProveedor = txt_Nombre_FormProveedor.Text;
                string nuevaDireccion = txt_Direccion_FormProveedor.Text;
                string nuevoRazonSocial = txt_RazonSocial_FormProveedor.Text;
                string nuevoCorreo = txt_Correo_FormProveedor.Text;
                string nuevoTelefono = txt_Telefono_FormProveedor.Text;



                if (dgv_Data_FormProveedor.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para editar"); // Valida que se haya seleccionado un registro (Adan).
                    return;
                }

                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();

                    string query = @"UPDATE TB_Proveedor SET nombre_Proveedor = @v1, estado_Proveedor = @v2, direccion_ID = @v3, correo_Proveedor = @v4, numero_Telefonico_Proveedor = @v5, razonSocial_Proveedor = @v6 WHERE proveedor_ID = @id";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);

                    cmd.Parameters.AddWithValue("@v1", nuevoNombreProveedor);
                    cmd.Parameters.AddWithValue("@v3", nuevaDireccion);
                    cmd.Parameters.AddWithValue("@v2", nuevoEstadoActividad);
                    cmd.Parameters.AddWithValue("@v4", nuevoCorreo);
                    cmd.Parameters.AddWithValue("@v5", nuevoTelefono);
                    cmd.Parameters.AddWithValue("@v6", nuevoRazonSocial);

                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro modificado");

                    CargarProveedor();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btn_Buscar_FormProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Buscar_FormProveedor.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona una columna para buscar", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string columna = cmb_Buscar_FormProveedor.SelectedValue.ToString();

                string texto = txt_Buscar_FormProveedor.Text.Trim();

                string query = "SELECT * FROM TB_Proveedor";

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

                    dgv_Data_FormProveedor.DataSource = dt;
                }

                CAPA_PRESENTACION.Utilidades.FuncionesPersonalizadas.LimpiarControles(this); //Limpia los campos de texto (Adan).
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void iconButton_Limpiar_FormProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                CargarProveedor();
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
