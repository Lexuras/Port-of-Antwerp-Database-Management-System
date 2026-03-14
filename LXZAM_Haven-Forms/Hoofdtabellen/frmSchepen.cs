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
    public partial class frmSchepen : Form
    {
        public frmSchepen()
        {
            InitializeComponent();
        }

        private void frmSchepen_Load(object sender, EventArgs e)
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
            label4.BackColor = Color.FromArgb(155, 212, 228);
            Naam.BackColor = Color.FromArgb(155, 212, 228);
            lstSchepen.BackColor = Color.FromArgb(202, 222, 239);

            txtNaam.BackColor = Color.FromArgb(202, 222, 239);
            txtBreedte.BackColor = Color.FromArgb(202, 222, 239);
            txtCapaciteit.BackColor = Color.FromArgb(202, 222, 239);
            txtLengte.BackColor = Color.FromArgb(202, 222, 239);
            txtType.BackColor = Color.FromArgb(202, 222, 239);

            cboID.BackColor = Color.FromArgb(202, 222, 239);
        }

        private void toonOverzicht()
        {
            lstSchepen.Items.Clear();
            cboID.Items.Clear();
            Controller _controller = new Controller();




            foreach (Schip s in _controller.GetSchip())

            {
                lstSchepen.Items.Add(s.ToString());
                cboID.Items.Add(s.idSchip.ToString());

            }
        }

        private void btnVoegToe_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            Schip s = new Schip(txtNaam.Text, txtType.Text, Convert.ToDouble(txtLengte.Text),Convert.ToDouble(txtBreedte.Text),Convert.ToInt16(txtCapaciteit.Text));

            _controller.SchipToevoegen(s);
            toonOverzicht();
            txtNaam.Clear();
            txtType.Clear();
            txtLengte.Clear();
            txtCapaciteit.Clear();
            txtBreedte.Clear();
        }

        private void cboID_SelectedIndexChanged(object sender, EventArgs e)
        {
            Controller _controller = new Controller();

            foreach (Schip s in _controller.GetSchip())
            {
                if (cboID.Text == s.idSchip.ToString())
                {
                    txtNaam.Text = s.Naam.ToString();
                    txtBreedte.Text = s.Breedte.ToString();
                    txtCapaciteit.Text = s.Capaciteit.ToString();
                    txtLengte.Text = s.Lengte.ToString();
                    txtType.Text = s.Type.ToString();
                    


                }

            }
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            Schip s = new Schip(Convert.ToInt16(cboID.Text), txtNaam.Text, txtType.Text, Convert.ToDouble(txtLengte.Text), Convert.ToDouble(txtBreedte.Text), Convert.ToInt16(txtCapaciteit.Text));

            _controller.SchipVerwijderen(s);
            toonOverzicht();
            txtNaam.Clear();
            txtType.Clear();
            txtLengte.Clear();
            txtCapaciteit.Clear();
            txtBreedte.Clear();
            
        }

        private void btnVerander_Click(object sender, EventArgs e)
        {
            Controller _controller = new Controller();
            Schip s = new Schip(Convert.ToInt16(cboID.Text), txtNaam.Text, txtType.Text, Convert.ToDouble(txtLengte.Text), Convert.ToDouble(txtBreedte.Text), Convert.ToInt16(txtCapaciteit.Text));

            _controller.SchipVeranderen(s);
            toonOverzicht();
            txtNaam.Clear();
            txtType.Clear();
            txtLengte.Clear();
            txtCapaciteit.Clear();
            txtBreedte.Clear();
        }

        private void btnGaTerug_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmBeginScherm frm = new frmBeginScherm();
            frm.Show();
        }
    }
}
