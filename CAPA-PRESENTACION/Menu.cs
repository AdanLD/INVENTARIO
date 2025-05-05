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
using FontAwesome.Sharp;
using FontAwesome;

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
            menu.Text = $"{menu.Text} {UsuarioActual.nombre_Usuario} {UsuarioActual.nombre_Paterno_Usuario} {UsuarioActual.nombre_Materno_Usuario}"; //Cambia la propiedad del text por el nombre completo del usuario (Adan).
        }


        private void mnString_Titulo_Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private static IconMenuItem menuPulsado = null; //Declaracion de la variable iconMenuItem para almacenar el menu que se ha pulsado (Adan).

        private static Form formActivo = null; //Declaracion de la variable formActivo para almacenar el formulario activo (Adan).

        private void AbrirFormulario(IconMenuItem menu, Form formulario) /* Recibe el inconMenuItem pulsado y su respectivo formulario */
        {
            if (menuPulsado != null)
            {
                menuPulsado.BackColor = Color.White;
            }

            menu.BackColor = Color.Silver;

            menuPulsado = menu;

            if (formActivo != null)
            {
                formActivo.Close();
            }

            formActivo = formulario;

            formulario.TopLevel = false;
            formulario.FormBorderStyle = FormBorderStyle.None; //Suprimira sus bordes.
            formulario.Dock = DockStyle.Fill; //Se expandira en plenitud dentro del panel contenedor (Adan).

            panel_Contenedor.Controls.Add(formulario); //Agrega el formulario al panel contenedor (Adan);

            formulario.Show();

        }

        private void iconMenuItem_Usuarios_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormUsuarios()); //Llamada al metodo abrir formulario con destino a FormUsuarios (Adan).
        }

        private void iconMenuItem_Categoria_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_Categoria_Menu, new FormCategoria()); //Llamada al metodo abrir formulario con destino a FormCategoria (Adan).
        }

        private void iconMenuItem_Producto_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_Producto_Menu, new FormProducto()); //Llamada al metodo abrir formulario con destino a FormProducto (Adan).
        }

        private void iconMenuItem_Registrar_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_RegistrarVentas_Menu, new FormVentas()); //Llamada al metodo abrir formulario con destino a FormVentas (Adan).
        }

        private void iconMenuItem_VerDetalle_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_VerDetalleVentas_Menu, new FormDetalleVenta()); //Llamada al metodo abrir formulario con destino a FormDetallesVentas (Adan).
        }

        private void iconMenuItem_RegistrarCompras_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_RegistrarCompras_Menu, new FormCompras()); //Llamada al metodo abrir formulario con destino a FormCompras (Adan).
        }

        private void iconMenuItem_VerDetalleCompras_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_VerDetalleCompras_Menu, new FormDetalleCompra()); //Llamada al metodo abrir formulario con destino a FormDetallesVentas (Adan).
        }

        private void iconMenuItem_Clientes_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormClientes()); //Llamada al metodo abrir formulario con destino a FormClientes (Adan).
        }

        private void iconMenuItem_Proveedores_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormProveedores()); //Llamada al metodo abrir formulario con destino a FormProveedores (Adan).

        }

        private void iconMenuItem_Reportes_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormReportes()); //Llamada al metodo abrir formulario con destino a FormReportes (Adan).
        }

        private void iconMenuItem_Informacion_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormInformacion()); //Llamada al metodo abrir formulario con destino a FormInformacion (Adan).
        }
    }
}
