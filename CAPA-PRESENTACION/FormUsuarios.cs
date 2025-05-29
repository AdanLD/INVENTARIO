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

        private void btn_Editar_FormUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
