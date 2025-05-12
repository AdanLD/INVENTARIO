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
                    //item.estado_Actividad_Usuario == true?"Activo":"",
                    hora,                    fecha
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
                    ((OpcionCombo)cmb_Estado_FormUsuario.SelectedItem).Valor.ToString(),
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
    }
}
