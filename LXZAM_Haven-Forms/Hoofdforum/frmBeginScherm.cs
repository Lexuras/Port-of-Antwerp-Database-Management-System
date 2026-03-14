using LXZAM_Haven.Business;
using LXZAM_Haven_Forms.Properties;
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
    public partial class frmBeginScherm : Form
    {
        public frmBeginScherm()
        {
            InitializeComponent();
        }

        private void btnHaven_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHavens frm = new frmHavens();
            frm.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProducten frm = new frmProducten();
            frm.Show();
        }

        private void btnSchip_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSchepen frm = new frmSchepen();
            frm.Show();
            
        }

        private void btnSluit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmBeginScherm_Load(object sender, EventArgs e)
        {
            BackColor = Color.FromArgb(7, 132, 181);
            btnHaven.BackColor = Color.FromArgb(155, 212, 228);

            btnSluit.BackColor =Color.IndianRed;
            btnSluit.ForeColor = Color.White;
            btnSchip.BackColor = Color.FromArgb(155, 212, 228);
            
            btnProduct.BackColor = Color.FromArgb(155, 212, 228);

            // koppeltabelen
            btnHavenOpRoute.BackColor = Color.FromArgb(0, 255, 239);
            btnProductOpProductPerRoute.BackColor = Color.FromArgb(0, 255, 239);
            btnRouteOpProductPerRoute.BackColor = Color.FromArgb(0, 255, 239);
            btnSchipOpRoute.BackColor = Color.FromArgb(0, 255, 239);

            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmHavenOpRoute frm = new frmHavenOpRoute();
            frm.Show();
        }

        private void btnSchipOpRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmSchipOpRoute frm = new frmSchipOpRoute();
            frm.Show();
        }

        private void btnRouteOpProductPerRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmRouteOpProductPerRoute frm = new frmRouteOpProductPerRoute();
            frm.Show();
        }

        private void btnProductOpProductPerRoute_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmProductOpProductPerRoute frm = new frmProductOpProductPerRoute();
            frm.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
