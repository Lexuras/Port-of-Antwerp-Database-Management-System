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
using LXZAM_Haven.Business;
using LXZAM_Haven_Forms;

namespace LXZAM_Haven_Forms
{
    public partial class frmHavens : Form
    {
        public frmHavens()
        {
            InitializeComponent();
        }

        private void frmHavens_Load(object sender, EventArgs e)
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
            label3.BackColor = Color.FromArgb(155, 212, 228);
            Naam.BackColor = Color.FromArgb(155, 212, 228);
            lstHaven.BackColor = Color.FromArgb(202, 222, 239);

            txtNaam.BackColor = Color.FromArgb(202, 222, 239);
            txtDokken.BackColor = Color.FromArgb(202, 222, 239);
            txtLand.BackColor = Color.FromArgb(202, 222, 239);
            txtStad.BackColor = Color.FromArgb(202, 222, 239);

            cboID.BackColor = Color.FromArgb(202, 222, 239);


        }

    
        private void toonOverzicht()
        {
            lstHaven.Items.Clear();
            cboID.Items.Clear();
            Controller _controller = new Controller();
            
       

            
            foreach (Haven h in _controller.GetHavens())

            {
                lstHaven.Items.Add(h.ToString());
                cboID.Items.Add(h.idHaven.ToString());
                
            }
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            Haven s = new Haven(txtNaam.Text, txtLand.Text, txtStad.Text, Convert.ToInt32(txtDokken.Text));

            _controller.HavenToevoegen(s);
            toonOverzicht();
            txtNaam.Clear();
            txtDokken.Clear();
            txtLand.Clear();
            txtStad.Clear();
            
        }

        private void txtLand_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            Haven s = new Haven( Convert.ToInt16(cboID.Text), txtNaam.Text, txtLand.Text, txtStad.Text, Convert.ToInt32(txtDokken.Text));

            _controller.HavenVerwijderen(s);
            toonOverzicht();
            txtNaam.Clear();
            txtDokken.Clear();
            txtLand.Clear();
            txtStad.Clear();
        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller _controller = new Controller();

            foreach (Haven h in _controller.GetHavens())
            {
                if (cboID.Text == h.idHaven.ToString())
                {
                    txtNaam.Text = h.Naam.ToString();
                    txtStad.Text = h.Stad.ToString();
                    txtLand.Text = h.Land.ToString();
                    txtDokken.Text = h.aantalDokken.ToString();

                }

            }
        }

        private void btnVerander_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            Haven s = new Haven(Convert.ToInt16(cboID.Text), txtNaam.Text, txtLand.Text, txtStad.Text, Convert.ToInt32(txtDokken.Text));

            _controller.HavenVeranderen(s);
            toonOverzicht();
            txtNaam.Clear();
            txtDokken.Clear();
            txtLand.Clear();
            txtStad.Clear();
        }

        private void btnGaTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBeginScherm frm = new frmBeginScherm();
            frm.Show();
        }
    }
}

