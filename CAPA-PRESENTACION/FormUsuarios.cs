using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_PRESENTACION.Utilidades;
using CAPA_ENTIDAD;
using CAPA_NEGOCIO;

namespace CAPA_PRESENTACION
{
    public partial class FormUsuarios : PADRE
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private bool ValidarDatos()
        {
            // Validar documento
            if (string.IsNullOrWhiteSpace(txt_Documento_FormUsuario.Text))
            {
                MessageBox.Show("El documento es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Documento_FormUsuario.Focus();
                return false;
            }

            // Validar nombre
            if (string.IsNullOrWhiteSpace(txt_Nombre_FormUsuario.Text))
            {
                MessageBox.Show("El nombre es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Nombre_FormUsuario.Focus();
                return false;
            }

            // Validar apellido paterno
            if (string.IsNullOrWhiteSpace(txt_NombrePaterno_FormUsuario.Text))
            {
                MessageBox.Show("El apellido paterno es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_NombrePaterno_FormUsuario.Focus();
                return false;
            }

            // Validar correo
            if (string.IsNullOrWhiteSpace(txt_Correo_FormUsuario.Text))
            {
                MessageBox.Show("El correo es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Correo_FormUsuario.Focus();
                return false;
            }
            else if (!txt_Correo_FormUsuario.Text.Contains("@") || !txt_Correo_FormUsuario.Text.Contains("."))
            {
                MessageBox.Show("Ingrese un correo válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Correo_FormUsuario.Focus();
                return false;
            }

            // Validar teléfono
            if (string.IsNullOrWhiteSpace(txt_Telefono_FormUsuario.Text))
            {
                MessageBox.Show("El teléfono es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Telefono_FormUsuario.Focus();
                return false;
            }
            else if (!long.TryParse(txt_Telefono_FormUsuario.Text, out _) || txt_Telefono_FormUsuario.Text.Length != 10)
            {
                MessageBox.Show("El teléfono debe tener 10 dígitos numéricos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Telefono_FormUsuario.Focus();
                return false;
            }

            // Validar contraseña
            if (string.IsNullOrWhiteSpace(txt_Contraseaña_FormUsuario.Text))
            {
                MessageBox.Show("La contraseña es obligatoria", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseaña_FormUsuario.Focus();
                return false;
            }
            else if (txt_Contraseaña_FormUsuario.Text.Length < 6)
            {
                MessageBox.Show("La contraseña debe tener al menos 6 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_Contraseaña_FormUsuario.Focus();
                return false;
            }

            // Validar confirmación de contraseña
            if (txt_Contraseaña_FormUsuario.Text != txt_confirmarContraseaña_FormUsuario.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_confirmarContraseaña_FormUsuario.Focus();
                return false;
            }

            // Validar rol
            if (cmb_Rol_FormUsuario.SelectedItem == null)
            {
                MessageBox.Show("Debe seleccionar un rol", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_Rol_FormUsuario.Focus();
                return false;
            }

            return true;
        }
        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            try
            {
                cmb_Estado_FormUsuario.Items.Add(new OpcionCombo() { Valor = 1, Texto = 1 + " Activo" });
                cmb_Estado_FormUsuario.Items.Add(new OpcionCombo() { Valor = 0, Texto = 0 + " No activo" });
                cmb_Estado_FormUsuario.ValueMember = "Texto";
                cmb_Estado_FormUsuario.DisplayMember = "Valor";
                cmb_Estado_FormUsuario.SelectedIndex = 0;

                List<Cargo> ListaCargo = new CN_Cargo().Enlistar();

                foreach (Cargo item in ListaCargo)
                {
                    cmb_Rol_FormUsuario.Items.Add(new OpcionCombo() { Valor = item.cargo_ID, Texto = item.descripcion_Cargo });
                    cmb_Rol_FormUsuario.ValueMember = "Texto";
                    cmb_Rol_FormUsuario.DisplayMember = "Valor";
                    cmb_Rol_FormUsuario.SelectedIndex = 0;
                }

                foreach (DataGridViewColumn columna in dgv_Data_FormUsuario.Columns)
                {
                    if (columna.Visible == true && columna.Name != "btn_Seleccionar_FormUsuario")
                    {
                        cmb_Buscar_FormUsuario.Items.Add(new OpcionCombo() { Valor = columna.Name, Texto = columna.HeaderText }); //De ser visible la columna estara presente como item en el comboBox (Adan).
                    }
                }
                //cmb_Buscar_FormUsuario.ValueMember = "Texto";
                //cmb_Buscar_FormUsuario.DisplayMember = "Valor";
                //cmb_Buscar_FormUsuario.SelectedIndex = 0;


                //Mostrar todos los usuarios (Adan).
                List<Usuario> ListaUsuario = new CN_Usuario().Enlistar();

                string hora = TimeOnly.FromDateTime(DateTime.Now).ToString();
                string fecha = DateOnly.FromDateTime(DateTime.Now).ToString();

                foreach (Usuario item in ListaUsuario)
                {
                    dgv_Data_FormUsuario.Rows.Add(
                new object[]
                {
                    "",
                    item.usuario_ID,
                    item.documento_Usuario,
                    item.nombre_Usuario,
                    item.nombre_Paterno_Usuario,
                    item.nombre_Materno_Usuario,
                    item.correo_Usuario,
                    item.numero_telefonico_Usuario,
                    item.contraseña_Usuario,
                    item.ObjCargo.cargo_ID,
                    item.ObjCargo.descripcion_Cargo,
                    item.estado_Actividad_Usuario == true?"Activo":"Inactivo",
                    item.estado_Actividad_Usuario == true?"Activo":"Inactivo",
                    item.hora_Creacion_Usuario,
                    item.fecha_Creacion_Usuario
                }
            );
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        private void cmb_Estado_FormUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_Guardar_FormUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            string hora = TimeOnly.FromDateTime(DateTime.Now).ToString();
            string fecha = DateOnly.FromDateTime(DateTime.Now).ToString();


            //Añade nuevas filas a dgv_Data_FormUsuario (Adan).
            dgv_Data_FormUsuario.Rows.Add(
                new object[] //Arreglo de objetos que se usaran en un registros.
                {
                    //Variables existentes en FormUsuarios o en su contexto (Adan).
                    "",
                    txt_ID_FormUsuario.Text,
                    txt_Documento_FormUsuario.Text,
                    txt_Nombre_FormUsuario.Text,
                    txt_NombrePaterno_FormUsuario.Text,
                    txt_NombreMaterno_FormUsuario.Text,
                    txt_Correo_FormUsuario.Text,
                    txt_Telefono_FormUsuario.Text, //Hay un problema aqui (Adan).
                    ((OpcionCombo)cmb_Rol_FormUsuario.SelectedItem).Texto.ToString(),
                    ((OpcionCombo)cmb_Rol_FormUsuario.SelectedItem).Valor.ToString(),
                    hora,
                    ((OpcionCombo)cmb_Estado_FormUsuario.SelectedItem).Valor = true? "Activo":"Inactivo",
                    ((OpcionCombo)cmb_Estado_FormUsuario.SelectedItem).Texto.ToString(),
                    hora,
                    fecha
                }
            );

            FuncionesPersonalizadas.LimpiarControles(this); //Limpia los controles del formulario (Adan).


        }

        private void dgv_Data_FormUsuario_C(object sender, DataGridViewCellPaintingEventArgs e)
        {
            //if (e.RowIndex < 0)
            //{
            //    e.Paint(e.CellBounds, DataGridViewPaintParts.All);
            //    var w = Properties.Resources.check20.width;
            //}
        }

        private void dgv_Data_FormUsuario_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow tupla = dgv_Data_FormUsuario.CurrentRow;

                //Almacena en los campos los valores de cada celda (Adan).
                txt_Documento_FormUsuario.Text = tupla.Cells["documento_Usuario"].Value?.ToString();
                txt_Nombre_FormUsuario.Text = tupla.Cells["nombre_Usuario"].Value?.ToString();
                txt_NombrePaterno_FormUsuario.Text = tupla.Cells["nombre_paterno_Usuario"].Value?.ToString(); //Activo?
                txt_NombreMaterno_FormUsuario.Text = tupla.Cells["nombre_Materno_Usuario"].Value?.ToString();
                txt_Correo_FormUsuario.Text = tupla.Cells["correo_Usuario"].Value?.ToString();
                txt_Telefono_FormUsuario.Text = tupla.Cells["numero_telefonico_Usuario"].Value?.ToString();
                txt_Contraseaña_FormUsuario.Text = tupla.Cells["contrasena_Usuario"].Value?.ToString();
                txt_confirmarContraseaña_FormUsuario.Text = tupla.Cells["contrasena_Usuario"].Value?.ToString(); //No aparece.


                var valorCargo = tupla.Cells["cargo_ID"].Value;

                if (valorCargo != null)
                {
                    foreach (var item in cmb_Rol_FormUsuario.Items)
                    {
                        var prop = item.GetType().GetProperty("Valor");
                        if (prop != null && prop.GetValue(item)?.ToString() == valorCargo.ToString())
                        {
                            cmb_Rol_FormUsuario.SelectedItem = item;
                            break;
                        }
                    }
                }
                else
                {
                    cmb_Rol_FormUsuario.SelectedIndex = -1;
                }
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

        private void CargarUsuarios()
        {
            try
            {
                dgv_Data_FormUsuario.Rows.Clear();
                List<Usuario> ListaUsuario = new CN_Usuario().Enlistar();

                foreach (Usuario item in ListaUsuario)
                {
                    dgv_Data_FormUsuario.Rows.Add(
                        new object[]
                        {
                            "",
                            item.usuario_ID,
                            item.documento_Usuario,
                            item.nombre_Usuario,
                            item.nombre_Paterno_Usuario,
                            item.nombre_Materno_Usuario,
                            item.correo_Usuario,
                            item.numero_telefonico_Usuario,
                            item.contraseña_Usuario,
                            item.ObjCargo.cargo_ID,
                            item.ObjCargo.descripcion_Cargo,
                            item.estado_Actividad_Usuario ? "Activo" : "Inactivo",
                            item.estado_Actividad_Usuario ? "Activo" : "Inactivo",
                            item.hora_Creacion_Usuario,
                            item.fecha_Creacion_Usuario
                        }
                    );
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar usuarios: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Editar_FormUsuario_Click(object sender, EventArgs e)
        {
            if (!ValidarDatos()) return;

            if (dgv_Data_FormUsuario.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un usuario de la lista", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                int usuarioID = Convert.ToInt32(dgv_Data_FormUsuario.CurrentRow.Cells["usuario_ID"].Value);

                Usuario usuario = new Usuario()
                {
                    usuario_ID = usuarioID,
                    documento_Usuario = txt_Documento_FormUsuario.Text,
                    nombre_Usuario = txt_Nombre_FormUsuario.Text,
                    nombre_Paterno_Usuario = txt_NombrePaterno_FormUsuario.Text,
                    nombre_Materno_Usuario = txt_NombreMaterno_FormUsuario.Text,
                    correo_Usuario = txt_Correo_FormUsuario.Text,
                    numero_telefonico_Usuario = txt_Telefono_FormUsuario.Text,
                    contraseña_Usuario = txt_Contraseaña_FormUsuario.Text,
                    ObjCargo = new Cargo()
                    {
                        cargo_ID = Convert.ToInt32(((OpcionCombo)cmb_Rol_FormUsuario.SelectedItem).Valor)
                    },
                    estado_Actividad_Usuario = ((OpcionCombo)cmb_Estado_FormUsuario.SelectedItem).Valor.Equals(1)
                };

                CargarUsuarios();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el usuario: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
