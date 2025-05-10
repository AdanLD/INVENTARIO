using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAPA_PRESENTACION.Utilidades
{
    public static class FuncionesPersonalizadas
    {
        public static void LimpiarControles(Control contenedor)
        {
            foreach (Control ctrl in contenedor.Controls)
            {
                if (ctrl is TextBox txt) //Si el control es un textbox este se limpiara (Adan).
                {
                    txt.Text = string.Empty;
                }
                else if (ctrl is ComboBox cmb)
                {
                    cmb.SelectedIndex = -1;
                }
                else if (ctrl is CheckBox check)
                {
                    check.Checked = false;
                }
                //else if (ctrl is DateTimePicker dateTime)
                //{
                //    dateTime.Value = DateTime.Now; //Quizas se deba remover junto a las opciones inutiles (Adan).
                //}
                else if (ctrl is RadioButton rbtn)
                {
                    rbtn.Checked = false;
                }
                if (ctrl.Controls.Count > 0)
                {
                    LimpiarControles(ctrl);
                }
            }
        } //Funcion para limpiar controles (Adan).
    }
}
