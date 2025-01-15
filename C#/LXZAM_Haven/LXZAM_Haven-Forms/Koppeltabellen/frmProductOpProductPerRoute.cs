using LXZAM_Haven.Business;
using LXZAM_Haven_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LXZAM_Haven_Forms
{
    public partial class frmProductOpProductPerRoute : Form
    {
        public frmProductOpProductPerRoute()
        {
            InitializeComponent();
        }

        private void btnGaTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBeginScherm frm = new frmBeginScherm();
            frm.Show();
        }

        private void frmProductOpProductPerRoute_Load(object sender, EventArgs e)
        {
            toonOverzicht();
            color();
        }

        private void color()
        {
            cboID.BackColor = Color.FromArgb(202, 222, 239);
            lstProductPerRoute.BackColor = Color.FromArgb(202, 222, 239);
            btnGaTerug.BackColor = Color.IndianRed;
            btnGaTerug.ForeColor = Color.White;
            BackColor = Color.FromArgb(7, 132, 181);
            label1.BackColor = Color.FromArgb(155, 212, 228);
        }
        private void toonOverzicht()
        {
            Controller _controller = new Controller();
            foreach (Product p in _controller.getProducten())
            {
                cboID.Items.Add(p.idProduct.ToString() + " - " + p.Naam.ToString());
            }

        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstProductPerRoute.Items.Clear();
            Controller _controller = new Controller();

            foreach (ProductPerRoute ppr in _controller.GetProductenPerRoutes())
            {
                if (cboID.Text.Substring(0, 1) == ppr.idProduct.ToString())
                {
                    lstProductPerRoute.Items.Add(ppr);

                }

            }
        }
    }
}
