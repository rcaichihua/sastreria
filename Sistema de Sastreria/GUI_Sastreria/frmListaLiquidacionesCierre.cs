using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
namespace GUI_Tesoreria.caja.Liquidacion_cajas
{
    public partial class frmListaLiquidacionesCierre : Form
    {
        public frmListaLiquidacionesCierre()
        {
            InitializeComponent();
        }
        private static frmListaLiquidacionesCierre frmInstance = null;
        public static frmListaLiquidacionesCierre Instance()
        {
            if (((frmInstance == null) || (frmInstance.IsDisposed == true)))
            {
                frmInstance = new frmListaLiquidacionesCierre();
            }
            frmInstance.BringToFront();
            return frmInstance;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            DataTable dtResultado = new DataTable();
           

            if (dtResultado.Rows.Count <= 0)
            {
                
            }
            else
            {
                dgvListadoLiquidaciones.DataSource = dtResultado;

                if (dgvListadoLiquidaciones.RowCount > 0)
                {
                    decimal TotalCaja = 0.00m;
                    decimal TotalDeposito = 0.00m;

                    foreach (DataGridViewRow row in dgvListadoLiquidaciones.Rows)
                    {
                        TotalCaja = TotalCaja + Convert.ToDecimal(row.Cells["totalIngresoCaja"].Value);
                        TotalDeposito = TotalDeposito + Convert.ToDecimal(row.Cells["diferenciaDeposito"].Value);
                    }
                    txtTotalIngresoCaja.Text = TotalCaja.ToString("###,###,##0.00");
                    txtTotalDeposito.Text = TotalDeposito.ToString("###,###,##0.00");
                    lblNroLiquidaciones.Text = dgvListadoLiquidaciones.Rows.Count.ToString();
                }
            }
        }

        private void btnCerrarLiquidacion_Click(object sender, EventArgs e)
        {
            if (dgvListadoLiquidaciones.Rows.Count <= 0) return;
            int index = dgvListadoLiquidaciones.CurrentRow.Index;
            decimal resu = 0.00m;
            DataTable dtResultado = new DataTable();

            
        }

        private void dgvListadoLiquidaciones_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvListadoLiquidaciones.RowCount > 0)
            {
                foreach (DataGridViewRow row in dgvListadoLiquidaciones.Rows)
                {
                    if (row.Cells["Estado"].Value.ToString() == "CERRADO")
                    {
                        row.DefaultCellStyle.BackColor = Color.LightSkyBlue;
                    }
                }
            }
        }

        private void frmListaLiquidacionesCierre_Load(object sender, EventArgs e)
        {
            BtnBuscar_Click(sender, e);
        }
    }
}
