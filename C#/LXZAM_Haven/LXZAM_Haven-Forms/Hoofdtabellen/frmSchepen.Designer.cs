namespace LXZAM_Haven_Forms
{
    partial class frmSchepen
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
            this.lstSchepen = new System.Windows.Forms.ListBox();
            this.btnVoegToe = new System.Windows.Forms.Button();
            this.Naam = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnVerwijder = new System.Windows.Forms.Button();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.btnVerander = new System.Windows.Forms.Button();
            this.btnGaTerug = new System.Windows.Forms.Button();
            this.txtType = new System.Windows.Forms.TextBox();
            this.txtNaam = new System.Windows.Forms.TextBox();
            this.txtLengte = new System.Windows.Forms.TextBox();
            this.txtCapaciteit = new System.Windows.Forms.TextBox();
            this.txtBreedte = new System.Windows.Forms.TextBox();
            this.pnlInvoer = new System.Windows.Forms.Panel();
            this.pnlInvoer.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstSchepen
            // 
            this.lstSchepen.FormattingEnabled = true;
            this.lstSchepen.ItemHeight = 16;
            this.lstSchepen.Location = new System.Drawing.Point(109, 235);
            this.lstSchepen.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstSchepen.Name = "lstSchepen";
            this.lstSchepen.Size = new System.Drawing.Size(624, 164);
            this.lstSchepen.TabIndex = 0;
            // 
            // btnVoegToe
            // 
            this.btnVoegToe.Location = new System.Drawing.Point(628, 107);
            this.btnVoegToe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVoegToe.Name = "btnVoegToe";
            this.btnVoegToe.Size = new System.Drawing.Size(109, 27);
            this.btnVoegToe.TabIndex = 2;
            this.btnVoegToe.Text = "Toevoegen";
            this.btnVoegToe.UseVisualStyleBackColor = true;
            this.btnVoegToe.Click += new System.EventHandler(this.btnVoegToe_Click);
            // 
            // Naam
            // 
            this.Naam.AutoSize = true;
            this.Naam.Location = new System.Drawing.Point(197, 10);
            this.Naam.Name = "Naam";
            this.Naam.Size = new System.Drawing.Size(44, 16);
            this.Naam.TabIndex = 11;
            this.Naam.Text = "Naam";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(209, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(177, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 16);
            this.label2.TabIndex = 13;
            this.label2.Text = "Capaciteit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(188, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 16);
            this.label3.TabIndex = 14;
            this.label3.Text = "Breedte";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(197, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 16);
            this.label4.TabIndex = 15;
            this.label4.Text = "Lengte";
            // 
            // btnVerwijder
            // 
            this.btnVerwijder.Location = new System.Drawing.Point(628, 143);
            this.btnVerwijder.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerwijder.Name = "btnVerwijder";
            this.btnVerwijder.Size = new System.Drawing.Size(107, 28);
            this.btnVerwijder.TabIndex = 16;
            this.btnVerwijder.Text = "Verwijderen";
            this.btnVerwijder.UseVisualStyleBackColor = true;
            this.btnVerwijder.Click += new System.EventHandler(this.btnVerwijder_Click);
            // 
            // cboID
            // 
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(612, 58);
            this.cboID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(121, 24);
            this.cboID.TabIndex = 17;
            this.cboID.SelectedIndexChanged += new System.EventHandler(this.cboID_SelectedIndexChanged);
            // 
            // btnVerander
            // 
            this.btnVerander.Location = new System.Drawing.Point(628, 180);
            this.btnVerander.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnVerander.Name = "btnVerander";
            this.btnVerander.Size = new System.Drawing.Size(107, 34);
            this.btnVerander.TabIndex = 18;
            this.btnVerander.Text = "Veranderen";
            this.btnVerander.UseVisualStyleBackColor = true;
            this.btnVerander.Click += new System.EventHandler(this.btnVerander_Click);
            // 
            // btnGaTerug
            // 
            this.btnGaTerug.Location = new System.Drawing.Point(15, 16);
            this.btnGaTerug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGaTerug.Name = "btnGaTerug";
            this.btnGaTerug.Size = new System.Drawing.Size(103, 60);
            this.btnGaTerug.TabIndex = 19;
            this.btnGaTerug.Text = "Ga terug";
            this.btnGaTerug.UseVisualStyleBackColor = true;
            this.btnGaTerug.Click += new System.EventHandler(this.btnGaTerug_Click);
            // 
            // txtType
            // 
            this.txtType.Location = new System.Drawing.Point(24, 43);
            this.txtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(160, 22);
            this.txtType.TabIndex = 6;
            // 
            // txtNaam
            // 
            this.txtNaam.Location = new System.Drawing.Point(24, 1);
            this.txtNaam.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaam.Name = "txtNaam";
            this.txtNaam.Size = new System.Drawing.Size(160, 22);
            this.txtNaam.TabIndex = 5;
            // 
            // txtLengte
            // 
            this.txtLengte.Location = new System.Drawing.Point(24, 92);
            this.txtLengte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLengte.Name = "txtLengte";
            this.txtLengte.Size = new System.Drawing.Size(160, 22);
            this.txtLengte.TabIndex = 7;
            // 
            // txtCapaciteit
            // 
            this.txtCapaciteit.Location = new System.Drawing.Point(24, 176);
            this.txtCapaciteit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCapaciteit.Name = "txtCapaciteit";
            this.txtCapaciteit.Size = new System.Drawing.Size(160, 22);
            this.txtCapaciteit.TabIndex = 9;
            // 
            // txtBreedte
            // 
            this.txtBreedte.Location = new System.Drawing.Point(24, 134);
            this.txtBreedte.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBreedte.Name = "txtBreedte";
            this.txtBreedte.Size = new System.Drawing.Size(160, 22);
            this.txtBreedte.TabIndex = 8;
            // 
            // pnlInvoer
            // 
            this.pnlInvoer.Controls.Add(this.txtBreedte);
            this.pnlInvoer.Controls.Add(this.txtCapaciteit);
            this.pnlInvoer.Controls.Add(this.txtLengte);
            this.pnlInvoer.Controls.Add(this.txtNaam);
            this.pnlInvoer.Controls.Add(this.txtType);
            this.pnlInvoer.Location = new System.Drawing.Point(268, 10);
            this.pnlInvoer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlInvoer.Name = "pnlInvoer";
            this.pnlInvoer.Size = new System.Drawing.Size(238, 208);
            this.pnlInvoer.TabIndex = 20;
            // 
            // frmSchepen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlInvoer);
            this.Controls.Add(this.btnGaTerug);
            this.Controls.Add(this.btnVerander);
            this.Controls.Add(this.cboID);
            this.Controls.Add(this.btnVerwijder);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Naam);
            this.Controls.Add(this.btnVoegToe);
            this.Controls.Add(this.lstSchepen);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmSchepen";
            this.Text = "Schepen";
            this.Load += new System.EventHandler(this.frmSchepen_Load);
            this.pnlInvoer.ResumeLayout(false);
            this.pnlInvoer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSchepen;
        private System.Windows.Forms.Button btnVoegToe;
        private System.Windows.Forms.Label Naam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnVerwijder;
        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.Button btnVerander;
        private System.Windows.Forms.Button btnGaTerug;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.TextBox txtNaam;
        private System.Windows.Forms.TextBox txtLengte;
        private System.Windows.Forms.TextBox txtCapaciteit;
        private System.Windows.Forms.TextBox txtBreedte;
        private System.Windows.Forms.Panel pnlInvoer;
    }
}