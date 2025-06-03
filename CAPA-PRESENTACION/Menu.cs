
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
using CAPA_NEGOCIO;
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
            List<Permiso> listaPermisos = new CN_Permiso().Listar(UsuarioActual.usuario_ID); //Se asigna a la listaPermisos el resultado de la consulta de permisos para el usuario actual (Adan).

            foreach (IconMenuItem iconMenu in menuStrip_Menu_Menu.Items) //Recorre todos los menus (Adan).
            {
                bool encontrado = listaPermisos.Any(a => a.codigo_Permiso == iconMenu.Name); //Verifica si el menu esta en la lista de permisos (Adan).

                if (encontrado == false)
                {
                    iconMenu.Visible = false;
                }
            }

            string nombreC = UsuarioActual.nombre_Usuario + " " + UsuarioActual.nombre_Paterno_Usuario + " " + UsuarioActual.nombre_Materno_Usuario; //Cadena con el nombre completo (Adan).

            this.Text = $"Usuario: {nombreC}."; //Cambia la propiedad del text por el nombre completo del usuario (Adan).
        }

        private void mnString_Titulo_Menu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private static IconMenuItem menuPulsado = null; //Declaracion de la variable iconMenuItem para almacenar el menu que se ha pulsado (Adan).

        private static Form formActivo = null; //Declaracion de la variable formActivo para almacenar el formulario activo (Adan).

        private void AbrirFormulario(IconMenuItem menu, Form formulario)
        {
            try
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
                    formActivo.Dispose();
                }

                formActivo = formulario;

                panel_Contenedor.Controls.Clear();

                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None; //Suprimira sus bordes.
                formulario.Dock = DockStyle.Fill; //Se expandira en plenitud dentro del panel contenedor (Adan).
                panel_Contenedor.Controls.Add(formulario); //Agrega el formulario al panel contenedor (Adan);

                formulario.Show();
            }
            catch (Exception EX)
            {
                MessageBox.Show(EX.Message);
                throw;
            }


        }

        private void iconMenuItem_Usuarios_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormUsuarios()); //Llamada al metodo abrir formulario con destino a FormUsuarios (Adan).
        }

        private void iconMenuItem_Categoria_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_Mantenedor_Menu, new FormCategoria()); //Llamada al metodo abrir formulario con destino a FormCategoria (Adan).
        }

        private void iconMenuItem_Producto_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_Mantenedor_Menu, new FormProducto()); //Llamada al metodo abrir formulario con destino a FormProducto (Adan).
        }

        private void iconMenuItem_Registrar_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_RegistrarVentas_Menu, new FormVentas(UsuarioActual.usuario_ID));
        }

        private void iconMenuItem_VerDetalle_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_VerDetalleVentas_Menu, new FormDetalleVenta()); //Llamada al metodo abrir formulario con destino a FormDetallesVentas (Adan).
        }

        private void iconMenuItem_RegistrarCompras_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_Compras_Menu, new FormCompras(UsuarioActual.usuario_ID)); //Llamada al metodo abrir formulario con destino a FormCompras (Adan).
        }

        private void iconMenuItem_VerDetalleCompras_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_Compras_Menu, new FormDetalleCompra()); //Llamada al metodo abrir formulario con destino a FormDetallesVentas (Adan).
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

        private void iconMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void iconMenuItem_Almacenes_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormAlmacenes());//Llamada al metodo abrir formulario con destino a FormInventario (Adan).
        }

        private void iconMenuItem_Direcciones_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormDirecciones());//Llamada al metodo abrir formulario con destino a FormDirecciones (Adan).

        }

        private void negocioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_Mantenedor_Menu, new FormNegocio()); //Llamada al metodo abrir formulario con destino a FormNegocio (Adan).
        }

        private void rEPORTECOMPRASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_Mantenedor_Menu, new FormReportesCompras()); //Llamada al metodo abrir formulario con destino a FormNegocio (Adan).

        }

        private void rEPORTEVENTAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(iconMenuItem_Mantenedor_Menu, new FormReporteVentas());  //Llamada al metodo abrir formulario con destino a FormNegocio (Adan).

        }

        private void iconMenuItem_Inventario_Menu_Click(object sender, EventArgs e)
        {
            AbrirFormulario((IconMenuItem)sender, new FormInventario());//Llamada al metodo abrir formulario con destino a FormInventario (Adan).
        }
    }
}
