using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Sastreria
{
    public partial class frmImagen : MetroFramework.Forms.MetroForm
    {
        public frmImagen()
        {
            InitializeComponent();
        }

        private void frmImagen_Load(object sender, EventArgs e)
        {
            //System.IO.FileStream fs;
            //fs = new System.IO.FileStream(RutaImagen, FileMode.Open, FileAccess.Read);
            //pictureBox1.Image = System.Drawing.Image.FromStream(fs);
            //fs.Close();
        }

        private void frmImagen_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
