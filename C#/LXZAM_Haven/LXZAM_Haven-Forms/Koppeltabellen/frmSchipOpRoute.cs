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
    public partial class frmSchipOpRoute : Form
    {
        public frmSchipOpRoute()
        {
            InitializeComponent();
        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstRoutes.Items.Clear();
            Controller _controller = new Controller();

            foreach (Route r in _controller.GetRoutes())
            {
                if (cboID.Text.Substring(0,1) == r.idSchip.ToString())
                {
                    lstRoutes.Items.Add(r);

                }

            }
        }

        private void frmSchipOpRoute_Load(object sender, EventArgs e)
        {
            toonOverzicht();
            color();
        }
        private void color()
        {
            cboID.BackColor = Color.FromArgb(202, 222, 239);
            lstRoutes.BackColor = Color.FromArgb(202, 222, 239);
            btnGaTerug.BackColor = Color.IndianRed;
            btnGaTerug.ForeColor = Color.White;
            BackColor = Color.FromArgb(7, 132, 181);
            label1.BackColor = Color.FromArgb(155, 212, 228);
        }

        private void toonOverzicht()
        {
            Controller _controller = new Controller();
            foreach (Schip s in _controller.GetSchip())
            {
                cboID.Items.Add(s.idSchip.ToString() + " - " + s.Naam.ToString());
            }

        }

        private void lstRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGaTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBeginScherm frm = new frmBeginScherm();
            frm.Show();
        }
    }
}
