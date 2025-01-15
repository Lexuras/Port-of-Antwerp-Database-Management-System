namespace LXZAM_Haven_Forms
{
    partial class frmProducten
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
            this.lstProducten = new System.Windows.Forms.ListBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtKG = new System.Windows.Forms.TextBox();
            this.txtVerpakking = new System.Windows.Forms.TextBox();
            this.Naam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.btnVerander = new System.Windows.Forms.Button();
            this.btnGaTerug = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstProducten
            // 
            this.lstProducten.FormattingEnabled = true;
            this.lstProducten.Location = new System.Drawing.Point(37, 172);
            this.lstProducten.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lstProducten.Name = "lstProducten";
            this.lstProducten.Size = new System.Drawing.Size(493, 147);
            this.lstProducten.TabIndex = 0;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(469, 75);
            this.btnVoegToe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(91, 22);
            this.btnVoegToe.TabIndex = 2;
            this.btnVoegToe.Text = "Toevoegen";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(205, 36);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(119, 20);
            this.txtNaam.TabIndex = 6;
            // 
            // txtKG
            // 
            this.txtKG.Location = new System.Drawing.Point(205, 75);
            this.txtKG.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtKG.Name = "txtKG";
            this.txtKG.Size = new System.Drawing.Size(119, 20);
            this.txtKG.TabIndex = 7;
            // 
            // txtVerpakking
            // 
            this.txtVerpakking.Location = new System.Drawing.Point(205, 130);
            this.txtVerpakking.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtVerpakking.Name = "txtVerpakking";
            this.txtVerpakking.Size = new System.Drawing.Size(119, 20);
            this.txtVerpakking.TabIndex = 8;
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Location = new System.Drawing.Point(130, 39);
            this.Naam.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(35, 13);
            this.Naam.TabIndex = 11;
            this.Naam.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Aantal KG";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(78, 137);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Type verpakking";
            // 
            // cboID
            // 
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(468, 30);
            this.cboID.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(92, 21);
            this.cboID.TabIndex = 14;
            this.cboID.SelectedIndexChanged += new System.EventHandler(this.cboID_SelectedIndexChanged);
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(469, 100);
            this.btnVerwijder.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(91, 23);
            this.btnVerwijder.TabIndex = 15;
            this.btnVerwijder.Text = "Verwijderen";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // btnVerander
            // 
            this.btnVerander.Location = new System.Drawing.Point(468, 127);
            this.btnVerander.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnVerander.Name = "btnVerander";
            this.btnVerander.Size = new System.Drawing.Size(92, 25);
            this.btnVerander.TabIndex = 17;
            this.btnVerander.Text = "Veranderen";
            this.btnVerander.UseVisualStyleBackColor = true;
            this.btnVerander.Click += new System.EventHandler(this.btnVerander_Click);
            // 
            // btnGaTerug
            // 
            this.btnGaTerug.Location = new System.Drawing.Point(11, 11);
            this.btnGaTerug.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnGaTerug.Name = "btnGaTerug";
            this.btnGaTerug.Size = new System.Drawing.Size(77, 49);
            this.btnGaTerug.TabIndex = 18;
            this.btnGaTerug.Text = "Ga terug";
            this.btnGaTerug.UseVisualStyleBackColor = true;
            this.btnGaTerug.Click += new System.EventHandler(this.btnGaTerug_Click);
            // 
            // frmProducten
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.btnGaTerug);
            this.Controls.Add(this.btnVerander);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.cboID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.txtVerpakking);
            this.Controls.Add(this.txtKG);
            this.Controls.Add(this.txtNaam);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.lstProducten);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmProducten";
            this.Text = "Producten";
            this.Load += new System.EventHandler(this.frmProducten_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstProducten;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtKG;
        private System.Windows.Forms.TextBox txtVerpakking;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.Button btnVerander;
        private System.Windows.Forms.Button btnGaTerug;
    }
}