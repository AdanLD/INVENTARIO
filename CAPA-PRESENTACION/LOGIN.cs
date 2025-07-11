﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CAPA_NEGOCIO;
using CAPA_ENTIDAD;
using FontAwesome.Sharp;
using CAPA_PRESENTACION.Utilidades;

namespace CAPA_PRESENTACION
{
    public partial class LOGIN : CAPA_PRESENTACION.PADRE
    {
        public LOGIN()
        {
            InitializeComponent();
        }

        private void LOGIN_Load(object sender, EventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
           try
            {
                List<Usuario> TEST = new CN_Usuario().Enlistar();

                Usuario ObjAUsuario = new CN_Usuario().Enlistar().Where(u => u.documento_Usuario == txt_Login_Usuario.Text && u.contraseña_Usuario == txt_Login_Contraseña.Text).FirstOrDefault(); //Busca al usuario(obj) con las coincidencias (Adan);

                if (ObjAUsuario != null)
                {
                    //Nueva instancia del form (Adan).
                    Menu menu = new Menu(ObjAUsuario);

                    //Abre el nuevo formulario (Adan).
                    menu.Show();

                    //Oculta el formulario del login (Adan).
                    this.Hide();

                    menu.FormClosing += frm_Cerrado; // Cuando se cierre el formulario Menu entonces se llevara a cabo el evento frm_Cerrado (Adan).
                }
                else
                {
                    MessageBox.Show("Usuario inexistente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                throw;
            }
            
               

        }

        private void frm_Cerrado(object sender, FormClosingEventArgs e) { FuncionesPersonalizadas.LimpiarControles(this); this.Show(); } //Evento que mostrara el formulario login previamenente oculto (Adan).

    }
}
