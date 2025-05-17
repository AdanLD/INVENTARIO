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
                    MessageBox.Show("El nombre del almacen es obligatorio. Por favor, inserta un valor valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning); //Valida el registro del nombre del almacen (Adan).
                    return;
                }

                if (cmb_Estado_FormAlmacenes.SelectedItem == null)
                {
                    MessageBox.Show("El estado de actividad del almacen es obligatorio. Por favor, selecciona un valor valido.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

                    SQLiteCommand cmd = new SQLiteCommand(query, conexion);


                    cmd.Parameters.AddWithValue("@v1", Convert.ToString(txt_Nombre_FormAlmacenes.Text));
                    var estadoSeleccionado = cmb_Estado_FormAlmacenes.SelectedValue?.ToString();
                    cmd.Parameters.AddWithValue("@v2", estadoSeleccionado != null ? Convert.ToInt32(estadoSeleccionado) : 0);
                    cmd.Parameters.AddWithValue("@v3", Convert.ToInt32(txt_DireccionID_FormAlmacenes.Text));
                    cmd.Parameters.AddWithValue("@v4", Convert.ToString(txt_Capacidad_FormAlmacenes.Text));
                    cmd.Parameters.AddWithValue("@v5", Convert.ToString(txt_Stock_FormAlmacenes.Text));
                    cmd.Parameters.AddWithValue("@v6", Convert.ToString(txt_Minimo_FormAlmacenes.Text));
                    cmd.Parameters.AddWithValue("@v7", Convert.ToString(txt_maximo_FormAlmacenes.Text));
                    cmd.Parameters.AddWithValue("@v8", Convert.ToString(txt_Responsable_FormAlmacenes.Text));



                    cmd.ExecuteNonQuery();
                }

                CargarAlmacen(); // Actualiza el dvg (Adan).

            }
            catch (Exception ex)
            {

                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            
        }
    }
}
