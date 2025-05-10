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
            cmb_Estado_FormUsuario.Items.Add(new OpcionCombo() { Valor = 1, Texto = "Activo" });
            cmb_Estado_FormUsuario.Items.Add(new OpcionCombo() { Valor = 0, Texto = "No activo" });
            cmb_Estado_FormUsuario.ValueMember = "Texto";
            cmb_Estado_FormUsuario.DisplayMember = "Valor";
            cmb_Estado_FormUsuario.SelectedIndex = 0;
        }

        private void cmb_Estado_FormUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
