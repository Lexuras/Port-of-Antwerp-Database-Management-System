namespace LXZAM_Haven_Forms
{
    partial class frmHavens
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lstHaven = new System.Windows.Forms.ListBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtLand = new System.Windows.Forms.TextBox();
            this.txtStad = new System.Windows.Forms.TextBox();
            this.txtDokken = new System.Windows.Forms.TextBox();
            this.Naam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnVerander = new System.Windows.Forms.Button();
            this.btnGaTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstHaven
            // 
            this.lstHaven.FormattingEnabled = true;
            this.lstHaven.Location = new System.Drawing.Point(21, 199);
            this.lstHaven.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstHaven.Name = "lstHaven";
            this.lstHaven.Size = new System.Drawing.Size(542, 147);
            this.lstHaven.TabIndex = 0;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(494, 67);
            this.btnVoegToe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(79, 27);
            this.btnVoegToe.TabIndex = 1;
            this.btnVoegToe.Text = "Toevoegen";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(200, 35);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(256, 20);
            this.txtNaam.TabIndex = 6;
            // 
            // txtLand
            // 
            this.txtLand.Location = new System.Drawing.Point(200, 73);
            this.txtLand.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtLand.Name = "txtLand";
            this.txtLand.Size = new System.Drawing.Size(256, 20);
            this.txtLand.TabIndex = 7;
            this.txtLand.TextChanged += new System.EventHandler(this.txtLand_TextChanged);
            // 
            // txtStad
            // 
            this.txtStad.Location = new System.Drawing.Point(200, 113);
            this.txtStad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtStad.Name = "txtStad";
            this.txtStad.Size = new System.Drawing.Size(256, 20);
            this.txtStad.TabIndex = 8;
            // 
            // txtDokken
            // 
            this.txtDokken.Location = new System.Drawing.Point(200, 144);
            this.txtDokken.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtDokken.Name = "txtDokken";
            this.txtDokken.Size = new System.Drawing.Size(63, 20);
            this.txtDokken.TabIndex = 9;
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Location = new System.Drawing.Point(162, 37);
            this.Naam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(35, 13);
            this.Naam.TabIndex = 10;
            this.Naam.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "Stad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Land";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(113, 147);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Aantal Dokken";
            // 
            // cboID
            // 
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(481, 29);
            this.cboID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(92, 21);
            this.cboID.TabIndex = 14;
            this.cboID.SelectedIndexChanged += new System.EventHandler(this.cboID_SelectedIndexChanged);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(494, 98);
            this.btnVerwijder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(79, 28);
            this.btnVerwijder.TabIndex = 15;
            this.btnVerwijder.Text = "Verwijderen";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnVerander
            // 
            this.btnVerander.Location = new System.Drawing.Point(494, 130);
            this.btnVerander.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerander.Name = "btnVerander";
            this.btnVerander.Size = new System.Drawing.Size(79, 24);
            this.btnVerander.TabIndex = 16;
            this.btnVerander.Text = "Veranderen";
            this.btnVerander.UseVisualStyleBackColor = true;
            this.btnVerander.Click += new System.EventHandler(this.btnVerander_Click);
            // 
            // btnGaTerug
            // 
            this.btnGaTerug.Location = new System.Drawing.Point(28, 24);
            this.btnGaTerug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGaTerug.Name = "btnGaTerug";
            this.btnGaTerug.Size = new System.Drawing.Size(77, 49);
            this.btnGaTerug.TabIndex = 17;
            this.btnGaTerug.Text = "Ga terug";
            this.btnGaTerug.UseVisualStyleBackColor = true;
            this.btnGaTerug.Click += new System.EventHandler(this.btnGaTerug_Click);
            // 
            // frmHavens
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnGaTerug);
            this.Controls.Add(this.btnVerander);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.cboID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.txtDokken);
            this.Controls.Add(this.txtStad);
            this.Controls.Add(this.txtLand);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.lstHaven);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmHavens";
            this.Text = "Havens";
            this.Load += new System.EventHandler(this.frmHavens_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstHaven;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtLand;
        private System.Windows.Forms.TextBox txtStad;
        private System.Windows.Forms.TextBox txtDokken;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnVerander;
        private System.Windows.Forms.Button btnGaTerug;
    }
}

