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
    public partial class ucDashBoard : MetroFramework.Controls.MetroUserControl
    {
        public ucDashBoard()
        {
            InitializeComponent();
        }

        private void mtConsultarClientes_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucCliente"))
            {
                ucCliente uc = new ucCliente();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            frmMain.Instance.MetroContainer.Controls["ucCliente"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }

        private void mtConsultarVendedores_Click(object sender, EventArgs e)
        {
            if (!frmMain.Instance.MetroContainer.Controls.ContainsKey("ucProveedor"))
            {
                ucProveedor uc = new ucProveedor();
                uc.Dock = DockStyle.Fill;
                frmMain.Instance.MetroContainer.Controls.Add(uc);
            }
            frmMain.Instance.MetroContainer.Controls["ucProveedor"].BringToFront();
            frmMain.Instance.MetroBack.Visible = true;
        }
    }
}
