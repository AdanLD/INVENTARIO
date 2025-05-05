using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_ENTIDAD;

namespace CAPA_PRESENTACION
{
    public partial class Menu : CAPA_PRESENTACION.PADRE
    {
        private static Usuario UsuarioActual; ///Declaracion de la variable UsuarioActual para almacenar al usuario y que no varie en sus valores (Variable global) (Adan).
        public Menu(Usuario ObjUsuario)
        {
            UsuarioActual = ObjUsuario; //Se asigna el usuario a la variable UsuarioActual (Adan).
            InitializeComponent();
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            Menu menu = new Menu(UsuarioActual);
            menu.Text = $"{menu.Text} {UsuarioActual.nombre_Usuario} {UsuarioActual.nombre_Paterno_Usuario} {UsuarioActual.nombre_Materno_Usuario}"; 
        }

        private void mnString_Titulo_Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
