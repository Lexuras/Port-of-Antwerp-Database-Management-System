namespace LXZAM_Haven_Forms
{
    partial class frmSchipOpRoute
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
            this.cboID = new System.Windows.Forms.ComboBox();
            this.lstRoutes = new System.Windows.Forms.ListBox();
            this.btnGaTerug = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboID
            // 
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(487, 30);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(197, 24);
            this.cboID.TabIndex = 0;
            this.cboID.SelectedIndexChanged += new System.EventHandler(this.cboID_SelectedIndexChanged);
            // 
            // lstRoutes
            // 
            this.lstRoutes.FormattingEnabled = true;
            this.lstRoutes.ItemHeight = 16;
            this.lstRoutes.Location = new System.Drawing.Point(30, 116);
            this.lstRoutes.Name = "lstRoutes";
            this.lstRoutes.Size = new System.Drawing.Size(1062, 292);
            this.lstRoutes.TabIndex = 1;
            this.lstRoutes.UseTabStops = false;
            this.lstRoutes.SelectedIndexChanged += new System.EventHandler(this.lstRoutes_SelectedIndexChanged);
            // 
            // btnGaTerug
            // 
            this.btnGaTerug.Location = new System.Drawing.Point(30, 11);
            this.btnGaTerug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGaTerug.Name = "btnGaTerug";
            this.btnGaTerug.Size = new System.Drawing.Size(103, 60);
            this.btnGaTerug.TabIndex = 20;
            this.btnGaTerug.Text = "Ga terug";
            this.btnGaTerug.UseVisualStyleBackColor = true;
            this.btnGaTerug.Click += new System.EventHandler(this.btnGaTerug_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(363, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 16);
            this.label1.TabIndex = 25;
            this.label1.Text = "Schip ID + Naam";
            // 
            // frmSchipOpRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1105, 460);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGaTerug);
            this.Controls.Add(this.lstRoutes);
            this.Controls.Add(this.cboID);
            this.Name = "frmSchipOpRoute";
            this.Text = "frmSchipOpRoute";
            this.Load += new System.EventHandler(this.frmSchipOpRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.ListBox lstRoutes;
        private System.Windows.Forms.Button btnGaTerug;
        private System.Windows.Forms.Label label1;
    }
}