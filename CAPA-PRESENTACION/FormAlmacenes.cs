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

        private void OpcionesComboBox()
        {
            var headersAlmacen = new Dictionary<string, string> 

                //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
{
            { "almacen_ID","IDENTIFICADOR DE ALMACEN"},
            { "nombre_Almacen","NOMBRE"},
            { "estado_Actividad_Almacen", "ESTADO DE ACTIVIDAD" },
            { "direccion_ID", "DIRECCION" },
            { "capacidad_Almacen", "CAPACIDAD (m * m)" },
            { "stock_Almacen", "STOCK" },
            { "stock_Minimo_Almacen","STOCK MINIMO"},
            { "stock_Maximo_Almacen","STOCK MAXIMO"},
            { "responsable_Almacen","RESPONSABLE"},
            { "fecha_Apertura_Almacen","FECHA DE APERTURA"}
            };

            cmb_Buscar_FormAlmacen.DisplayMember = "Value";
            cmb_Buscar_FormAlmacen.ValueMember = "Key";
            cmb_Buscar_FormAlmacen.DataSource = new BindingSource(headersAlmacen, null);
        }

        private void FormInventario_Load(object sender, EventArgs e)
        {
            CargarAlmacen(); //Metodo que carga la informacion de la TB_Almacen.

            cmb_Estado_FormAlmacenes.Items.Add(new { Texto = "Activo", Valor = 1 });
            cmb_Estado_FormAlmacenes.Items.Add(new { Texto = "Inactivo", Valor = 0 });
            cmb_Estado_FormAlmacenes.DisplayMember = "Texto";
            cmb_Estado_FormAlmacenes.ValueMember = "Valor";

            var headersAlmacen = new Dictionary<string, string> 
            //Diccionario que almacena dos strings, el nombre del atributo y su remplazo del header (Adan).
{
            { "almacen_ID","IDENTIFICADOR DE ALMACEN"},
            { "nombre_Almacen","NOMBRE"},
            { "estado_Actividad_Almacen", "ESTADO DE ACTIVIDAD" },
            { "direccion_ID", "DIRECCION" },
            { "capacidad_Almacen", "CAPACIDAD (m * m)" },
            { "stock_Almacen", "STOCK" },
            { "stock_Minimo_Almacen","STOCK MINIMO"},
            { "stock_Maximo_Almacen","STOCK MAXIMO"},
            { "responsable_Almacen","RESPONSABLE"},
            { "fecha_Apertura_Almacen","FECHA DE APERTURA"}
            };

            foreach (DataGridViewColumn columna in dgv_Data_FormAlmacenes.Columns) //Se aplica en c/u de las columnas del dvg (Adan).
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

        private void CargarAlmacen()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    string query = @"SELECT almacen_ID,nombre_Almacen,CAST(estado_Actividad_Almacen AS INTEGER) AS estado_Actividad_Almacen, direccion_ID, capacidad_Almacen, stock_Almacen, stock_Minimo_Almacen, stock_Maximo_Almacen,responsable_Almacen, fecha_Apertura_Almacen
                                   FROM TB_Almacen"; ; //Selecciona todos los atributos de la TB_Almacen (Adan).

                    SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, cn);

                    DataTable tabla = new DataTable();

                    adaptador.Fill(tabla);

                    dgv_Data_FormAlmacenes.DataSource = tabla;

                }

                foreach (DataGridViewColumn columna in dgv_Data_FormAlmacenes.Columns)
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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_FormAlmacenes_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Estado_FormAlmacenes.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona un estado válido.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_Nombre_FormAlmacenes.Text))
                {
                    MessageBox.Show("El nombre del almacen es obligatorio. Por favor, inserta un valor valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_DireccionID_FormAlmacenes.Text))
                {
                    MessageBox.Show("La dirección del almacen es obligatoria. Por favor, inserta un valor valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txt_Capacidad_FormAlmacenes.Text, out decimal capacidad) || capacidad <= 0)
                {
                    MessageBox.Show("La capacidad del almacen debe ser un numero positivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_Stock_FormAlmacenes.Text, out int stock) || stock < 0)
                {
                    MessageBox.Show("El stock del almacen debe ser un numero entero no negativo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_Minimo_FormAlmacenes.Text, out int stockMin) || stockMin < 0)
                {
                    MessageBox.Show("El stock minimo debe ser un numero entero no negativo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_maximo_FormAlmacenes.Text, out int stockMax) || stockMax < stockMin)
                {
                    MessageBox.Show("El stock maximo debe ser un numero entero mayor o igual al stock minimo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_Responsable_FormAlmacenes.Text))
                {
                    MessageBox.Show("El responsable del almacen es obligatorio. Por favor, inserta un valor valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                using (SQLiteConnection conexion = new SQLiteConnection(Conectar.cadena))
                {
                    conexion.Open();

                    string query = "INSERT INTO TB_Almacen (nombre_Almacen, estado_Actividad_Almacen, direccion_ID, capacidad_Almacen, stock_Almacen, stock_Minimo_Almacen, stock_Maximo_Almacen, responsable_Almacen) VALUES (@v1, @v2, @v3, @v4, @v5, @v6, @v7, @v8)";

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@v1", txt_Nombre_FormAlmacenes.Text);

                        var estadoSeleccionado = cmb_Estado_FormAlmacenes.SelectedItem;

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
                        cmd.Parameters.AddWithValue("@v2", valorEstado);

                        cmd.Parameters.AddWithValue("@v3", Convert.ToInt32(txt_DireccionID_FormAlmacenes.Text));
                        cmd.Parameters.AddWithValue("@v4", capacidad);
                        cmd.Parameters.AddWithValue("@v5", stock);
                        cmd.Parameters.AddWithValue("@v6", stockMin);
                        cmd.Parameters.AddWithValue("@v7", stockMax);
                        cmd.Parameters.AddWithValue("@v8", txt_Responsable_FormAlmacenes.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                CargarAlmacen();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Buscar_FormAlmacen.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona una columna para buscar", "Advertencia",
                                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }


                string columna = cmb_Buscar_FormAlmacen.SelectedValue.ToString();

                string texto = txt_Buscar_FormAlmacen.Text.Trim();

                string query = "SELECT * FROM TB_Almacen";

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

                    dgv_Data_FormAlmacenes.DataSource = dt;
                }



                CAPA_PRESENTACION.Utilidades.FuncionesPersonalizadas.LimpiarControles(this); //Limpia los campos de texto (Adan).
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

        private void dgv_Data_FormAlmacenes_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow tupla = dgv_Data_FormAlmacenes.CurrentRow;

                txt_Nombre_FormAlmacenes.Text = tupla.Cells["nombre_Almacen"].Value?.ToString();

                var valorEstado = tupla.Cells["estado_Actividad_Almacen"].Value;

                if (valorEstado != null)
                {
                    foreach (var item in cmb_Estado_FormAlmacenes.Items)
                    {
                        var prop = item.GetType().GetProperty("Valor");
                        if (prop != null && prop.GetValue(item)?.ToString() == valorEstado.ToString())
                        {
                            cmb_Estado_FormAlmacenes.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    cmb_Estado_FormAlmacenes.SelectedIndex = -1;
                }

                txt_DireccionID_FormAlmacenes.Text = tupla.Cells["direccion_ID"].Value?.ToString();
                txt_Capacidad_FormAlmacenes.Text = tupla.Cells["capacidad_Almacen"].Value?.ToString();
                txt_Stock_FormAlmacenes.Text = tupla.Cells["stock_Almacen"].Value?.ToString();
                txt_Minimo_FormAlmacenes.Text = tupla.Cells["stock_Minimo_Almacen"].Value?.ToString();
                txt_maximo_FormAlmacenes.Text = tupla.Cells["stock_Maximo_Almacen"].Value?.ToString();
                txt_Responsable_FormAlmacenes.Text = tupla.Cells["responsable_Almacen"].Value?.ToString();


                txt_ID_FormAlmacenes.Text = tupla.Cells["direccion_ID"].Value?.ToString();
            }
            catch (Exception)
            {
                throw;
            }
            if (dgv_Data_FormAlmacenes.CurrentRow == null) return;
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            try
            {
                CargarAlmacen();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Eliminar_FormAlmacenes_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Data_FormAlmacenes.CurrentRow == null) return; //Si no hay una fila seleccionada se acaba el proceso (Adan).

                int id = Convert.ToInt32(dgv_Data_FormAlmacenes.CurrentRow.Cells["almacen_ID"].Value);

                if (MessageBox.Show("¿Quieres eliminar este registro?", "CONFIRMAR",
                    MessageBoxButtons.YesNo) == DialogResult.Yes) //Mensaje que confirma el proceso de eliminacion (Adan).
                {
                    using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                    {
                        cn.Open();

                        SQLiteCommand cmd = new SQLiteCommand("DELETE FROM TB_Almacen WHERE almacen_ID = @id", cn); //Elimina la tupla (Adan).

                        cmd.Parameters.AddWithValue("@id", id); //Asocia al registro con el valor de la variable (Adan).

                        cmd.ExecuteNonQuery();
                    }

                    CargarAlmacen();

                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Editar_FormAlmacenes_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmb_Estado_FormAlmacenes.SelectedItem == null)
                {
                    MessageBox.Show("Selecciona un estado válido.");
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_Nombre_FormAlmacenes.Text))
                {
                    MessageBox.Show("El nombre del almacen es obligatorio. Por favor, inserta un valor valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_DireccionID_FormAlmacenes.Text))
                {
                    MessageBox.Show("La dirección del almacen es obligatoria. Por favor, inserta un valor valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!decimal.TryParse(txt_Capacidad_FormAlmacenes.Text, out decimal capacidad) || capacidad <= 0)
                {
                    MessageBox.Show("La capacidad del almacen debe ser un numero positivo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_Stock_FormAlmacenes.Text, out int stock) || stock < 0)
                {
                    MessageBox.Show("El stock del almacen debe ser un numero entero no negativo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_Minimo_FormAlmacenes.Text, out int stockMin) || stockMin < 0)
                {
                    MessageBox.Show("El stock minimo debe ser un numero entero no negativo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(txt_maximo_FormAlmacenes.Text, out int stockMax) || stockMax < stockMin)
                {
                    MessageBox.Show("El stock maximo debe ser un numero entero mayor o igual al stock minimo.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(txt_Responsable_FormAlmacenes.Text))
                {
                    MessageBox.Show("El responsable del almacen es obligatorio. Por favor, inserta un valor valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                int id = Convert.ToInt32(dgv_Data_FormAlmacenes.CurrentRow.Cells["almacen_ID"].Value); // Obtiene el ID del registro seleccionado (Adan).

                var estadoSeleccionado = cmb_Estado_FormAlmacenes.SelectedItem;

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

                string nuevoNombreAlmacen = txt_Nombre_FormAlmacenes.Text;
                int nuevoEstadoActividad = valorEstado;
                string nuevaDireccion = txt_DireccionID_FormAlmacenes.Text;
                string nuevoCP = txt_Capacidad_FormAlmacenes.Text;
                int nuevoStock = Convert.ToInt32(txt_Stock_FormAlmacenes.Text);
                int nuevoMinStock = Convert.ToInt32(txt_Minimo_FormAlmacenes.Text);
                int nuevoMaxStock = Convert.ToInt32(txt_maximo_FormAlmacenes.Text);
                string nuevoResponsable = txt_Responsable_FormAlmacenes.Text;



                if (dgv_Data_FormAlmacenes.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para editar"); // Valida que se haya seleccionado un registro (Adan).
                    return;
                }

                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();

                    string query = @"UPDATE TB_Almacen SET nombre_Almacen = @v1, estado_Actividad_Almacen = @v2, direccion_ID = @v3, capacidad_Almacen = @v4, stock_Almacen = @v5, stock_Minimo_Almacen = @v6, stock_Maximo_Almacen = @v7,responsable_Almacen = @v8 WHERE almacen_ID = @id";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);

                    cmd.Parameters.AddWithValue("@v1", nuevoNombreAlmacen);
                    cmd.Parameters.AddWithValue("@v2", nuevoEstadoActividad);
                    cmd.Parameters.AddWithValue("@v3", nuevaDireccion);
                    cmd.Parameters.AddWithValue("@v4", nuevoCP);
                    cmd.Parameters.AddWithValue("@v5", nuevoStock);
                    cmd.Parameters.AddWithValue("@v6", nuevoMinStock);
                    cmd.Parameters.AddWithValue("@v7", nuevoMaxStock);
                    cmd.Parameters.AddWithValue("@v8", nuevoResponsable);



                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Registro modificado");

                    CargarAlmacen();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
