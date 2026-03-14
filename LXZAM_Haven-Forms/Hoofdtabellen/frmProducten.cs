using LXZAM_Haven.Business;
using LXZAM_Haven_Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LXZAM_Haven_Forms
{
    public partial class frmProducten : Form
    {
        public frmProducten()
        {
            InitializeComponent();
        }

        private void frmProducten_Load(object sender, EventArgs e)
        {
            toonOverzicht();
            BackColor = Color.FromArgb(7, 132, 181);
            btnGaTerug.BackColor = Color.IndianRed;
            btnGaTerug.ForeColor = Color.White;
            btnVerander.BackColor = Color.FromArgb(155, 212, 228);
            btnVerwijder.BackColor = Color.FromArgb(155, 212, 228);
            btnVoegToe.BackColor = Color.FromArgb(155, 212, 228);
            label1.BackColor = Color.FromArgb(155, 212, 228);
            label2.BackColor = Color.FromArgb(155, 212, 228);
            Naam.BackColor = Color.FromArgb(155, 212, 228);
            lstProducten.BackColor = Color.FromArgb(202, 222, 239);

            txtNaam.BackColor = Color.FromArgb(202, 222, 239);
            txtKG.BackColor = Color.FromArgb(202, 222, 239);
            txtVerpakking.BackColor = Color.FromArgb(202, 222, 239);

            cboID.BackColor = Color.FromArgb(202, 222, 239);
        }

        private void toonOverzicht()
        {
            lstProducten.Items.Clear();
            cboID.Items.Clear();
            Controller _controller = new Controller();




            foreach (Product p in _controller.getProducten())

            {
                lstProducten.Items.Add(p.ToString());
                cboID.Items.Add(p.idProduct.ToString());

            }
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            Product s = new Product(txtNaam.Text, 
                Convert.ToDouble(txtKG.Text), txtVerpakking.Text);

            _controller.ProductToevoegen(s);
            toonOverzicht();
            txtNaam.Clear();
            txtVerpakking.Clear();
            txtKG.Clear();
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller _controller = new Controller();

            foreach (Product p in _controller.getProducten())
            {
                if (cboID.Text == p.idProduct.ToString())
                {
                    txtNaam.Text = p.Naam.ToString();
                    txtKG.Text = p.TotaalGewichtKG.ToString();
                    txtVerpakking.Text = p.TypeVerpakking.ToString();
                    

                }

            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            Product p = new Product(Convert.ToInt16(cboID.Text), txtNaam.Text,
                Convert.ToDouble(txtKG.Text), txtVerpakking.Text);

            _controller.ProductVerwijderen(p);
            toonOverzicht();
            txtNaam.Clear();
            txtVerpakking.Clear();
            txtKG.Clear();
           
        }

        private void btnVerander_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            Product p = new Product(Convert.ToInt16(cboID.Text), txtNaam.Text,
            Convert.ToDouble(txtKG.Text), txtVerpakking.Text);

            _controller.ProductVeranderen(p);
            toonOverzicht();
            txtNaam.Clear();
            txtVerpakking.Clear();
            txtKG.Clear();
        }

        private void btnGaTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBeginScherm frm = new frmBeginScherm();
            frm.Show();
        }
    }
}
