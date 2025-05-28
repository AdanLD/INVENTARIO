using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CAPA_PRESENTACION
{
    public partial class FormCompras : PADRE
    {
        public FormCompras()
        {
            InitializeComponent();
        }

        private void FormCompras_Load(object sender, EventArgs e)
        {
            txt_Fecha_FormCompras.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

                List<string> TiposDoc = new List<string> { "BOLETA", "FACTURA" };
                cmb_TipoDoc_FormCompras.DataSource = TiposDoc;
            
        }
    }
}
