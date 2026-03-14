using LXZAM_Haven.Business;
using LXZAM_Haven_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LXZAM_Haven_Forms
{
    public partial class frmHavenOpRoute : Form
    {
        public frmHavenOpRoute()
        {
            InitializeComponent();
        }

        private void btnGaTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBeginScherm frm = new frmBeginScherm();
            frm.Show();
        }

        private void lstRoutes_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            lstRoutes.Items.Clear();
            foreach (Route r in _controller.GetRoutes())
            {
                if (cboID.Text.Substring(0, 1) == r.idHaven.ToString())
                {
                    lstRoutes.Items.Add(r);

                }

            }
        }

        private void frmHavenOpRoute_Load(object sender, EventArgs e)
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
            foreach (Haven h in _controller.GetHavens())
            {
                cboID.Items.Add(h.idHaven.ToString() + " - " + h.Naam.ToString());
            }

            

        }
    }
}
