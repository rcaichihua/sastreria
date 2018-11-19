using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Sastreria
{
    public partial class ucCliente : UserControl
    {
        public ucCliente()
        {
            InitializeComponent();
        }

        private void metroLabel10_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox14_Click(object sender, EventArgs e)
        {

        }

        private void metroTextBox22_Click(object sender, EventArgs e)
        {

        }

        private void pbImagen_Click(object sender, EventArgs e)
        {
            frmImagen win = new frmImagen();
            win.ShowDialog();
        }

        private void mtSalir_Click(object sender, EventArgs e)
        {

        }

        private void metroTile3_Click(object sender, EventArgs e)
        {

        }

        private void metroTabControl1_Click(object sender, EventArgs e)
        {
            if (mtcCliente.SelectedIndex==0)
            {

            }
            else
            {

            }
        }

        private void mtEditar_Click(object sender, EventArgs e)
        {

        }

        private void mtNuevo2_Click(object sender, EventArgs e)
        {
            mtcCliente.SelectedIndex = 0;
        }

        private void ucCliente_Load(object sender, EventArgs e)
        {
            //LLENA LISTADO DE CLIENTES
            cboTipodeDocumento.SelectedIndex =0;
        }
    }
}
