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

        private void VerificarEsquemaDocumento()
        {
            try
            {
                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();
                    string query = "PRAGMA table_info(TB_Proveedor);";
                    SQLiteCommand cmd = new SQLiteCommand(query, cn);
                    bool documentoExiste = false;

                    using (SQLiteDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            if (dr["name"].ToString().Equals("documento_Proveedor", StringComparison.OrdinalIgnoreCase))
                            {
                                documentoExiste = true;
                                break;
                            }
                        }
                    }

                    if (!documentoExiste)
                    {
                        query = "ALTER TABLE TB_Proveedor ADD COLUMN documento_Proveedor TEXT;";
                        cmd = new SQLiteCommand(query, cn);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error verificando esquema: {ex.Message}");
            }
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
                { "razonSocial_Proveedor","RAZON SOCIAL"},
                { "documento_Proveedor","DOCUMENTO"}
            };

            cmb_Buscar_FormProveedor.DisplayMember = "Value";
            cmb_Buscar_FormProveedor.ValueMember = "Key";
            cmb_Buscar_FormProveedor.DataSource = new BindingSource(headersProveedor, null);
        }

        private void FormProveedores_Load(object sender, EventArgs e)
        {
            try
            {
                VerificarEsquemaDocumento(); // Verificar campo documento
                CargarProveedor(); //Llama al metodo que carga los proveedores (Adan).

                cmb_Estado_FormProveedor.Items.Add(new { Texto = "Activo", Valor = 1 });
                cmb_Estado_FormProveedor.Items.Add(new { Texto = "Inactivo", Valor = 0 });
                cmb_Estado_FormProveedor.DisplayMember = "Texto";
                cmb_Estado_FormProveedor.ValueMember = "Valor";

                var headersProveedor = new Dictionary<string, string>
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
                    { "razonSocial_Proveedor","RAZON SOCIAL"},
                    { "documento_Proveedor","DOCUMENTO"}
                };

                foreach (DataGridViewColumn columna in dgv_Data_FormProveedor.Columns)
                {
                    if (headersProveedor.TryGetValue(columna.DataPropertyName, out string nombreColumna))
                    {
                        columna.HeaderText = nombreColumna;
                    }
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
                CAPA_PRESENTACION.Utilidades.FuncionesPersonalizadas.LimpiarControles(this);
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
                // Validación de documento
                if (string.IsNullOrWhiteSpace(txt_Documento_FormProveedor.Text))
                {
                    MessageBox.Show("El documento es obligatorio", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                using (SQLiteConnection conexion = new SQLiteConnection(Conectar.cadena))
                {
                    conexion.Open();

                    string query = @"INSERT INTO TB_Proveedor (
                        nombre_Proveedor, 
                        razonSocial_Proveedor, 
                        correo_Proveedor, 
                        direccion_ID, 
                        estado_Proveedor, 
                        numero_Telefonico_Proveedor,
                        documento_Proveedor
                    ) VALUES (
                        @v1, @v2, @v3, @v4, @v5, @v6, @v7
                    )";

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
                        cmd.Parameters.AddWithValue("@v7", txt_Documento_FormProveedor.Text);

                        cmd.ExecuteNonQuery();
                    }
                }

                CargarProveedor();
                MessageBox.Show("Proveedor registrado exitosamente", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgv_Data_FormProveedor_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Data_FormProveedor.CurrentRow == null) return;

                DataGridViewRow tupla = dgv_Data_FormProveedor.CurrentRow;

                txt_ID_FormProveedor.Text = tupla.Cells["proveedor_ID"].Value?.ToString();
                txt_Nombre_FormProveedor.Text = tupla.Cells["nombre_Proveedor"].Value?.ToString();
                txt_Direccion_FormProveedor.Text = tupla.Cells["direccion_ID"].Value?.ToString();
                txt_RazonSocial_FormProveedor.Text = tupla.Cells["razonSocial_Proveedor"].Value?.ToString();
                txt_Correo_FormProveedor.Text = tupla.Cells["correo_Proveedor"].Value?.ToString();
                txt_Documento_FormProveedor.Text = tupla.Cells["documento_Proveedor"].Value?.ToString(); // Nuevo campo

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
        }

        private void btn_Eliminar_FormUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Data_FormProveedor.CurrentRow == null) return;

                int id = Convert.ToInt32(dgv_Data_FormProveedor.CurrentRow.Cells["proveedor_ID"].Value);

                if (MessageBox.Show("¿Quieres eliminar este registro?", "CONFIRMAR",
                    MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                    {
                        cn.Open();
                        SQLiteCommand cmd = new SQLiteCommand(
                            "DELETE FROM TB_Proveedor WHERE proveedor_ID = @id", cn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }

                    CargarProveedor();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Editar_FormUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgv_Data_FormProveedor.CurrentRow == null)
                {
                    MessageBox.Show("Seleccione un registro para editar");
                    return;
                }

                // Validación de documento
                if (string.IsNullOrWhiteSpace(txt_Documento_FormProveedor.Text))
                {
                    MessageBox.Show("El documento es obligatorio", "Error",
                                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                int id = Convert.ToInt32(dgv_Data_FormProveedor.CurrentRow.Cells["proveedor_ID"].Value);

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

                using (SQLiteConnection cn = new SQLiteConnection(Conectar.cadena))
                {
                    cn.Open();

                    string query = @"UPDATE TB_Proveedor SET 
                        nombre_Proveedor = @v1, 
                        estado_Proveedor = @v2, 
                        direccion_ID = @v3, 
                        correo_Proveedor = @v4, 
                        numero_Telefonico_Proveedor = @v5, 
                        razonSocial_Proveedor = @v6,
                        documento_Proveedor = @v7 
                        WHERE proveedor_ID = @id";

                    SQLiteCommand cmd = new SQLiteCommand(query, cn);

                    cmd.Parameters.AddWithValue("@v1", txt_Nombre_FormProveedor.Text);
                    cmd.Parameters.AddWithValue("@v2", valorEstado);
                    cmd.Parameters.AddWithValue("@v3", txt_Direccion_FormProveedor.Text);
                    cmd.Parameters.AddWithValue("@v4", txt_Correo_FormProveedor.Text);
                    cmd.Parameters.AddWithValue("@v5", txt_Telefono_FormProveedor.Text);
                    cmd.Parameters.AddWithValue("@v6", txt_RazonSocial_FormProveedor.Text);
                    cmd.Parameters.AddWithValue("@v7", txt_Documento_FormProveedor.Text);
                    cmd.Parameters.AddWithValue("@id", id);

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Registro modificado exitosamente", "Éxito",
                                MessageBoxButtons.OK, MessageBoxIcon.Information);
                CargarProveedor();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    query += $" WHERE \"{columna}\" LIKE @busqueda";
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

                CAPA_PRESENTACION.Utilidades.FuncionesPersonalizadas.LimpiarControles(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void iconButton_Limpiar_FormProveedores_Click(object sender, EventArgs e)
        {
            try
            {
                CargarProveedor();
                txt_Buscar_FormProveedor.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}