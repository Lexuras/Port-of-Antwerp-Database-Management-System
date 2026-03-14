namespace LXZAM_Haven_Forms
{
    partial class frmProductOpProductPerRoute
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
            this.btnGaTerug = new System.Windows.Forms.Button();
            this.cboID = new System.Windows.Forms.ComboBox();
            this.lstProductPerRoute = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGaTerug
            // 
            this.btnGaTerug.Location = new System.Drawing.Point(46, 32);
            this.btnGaTerug.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnGaTerug.Name = "btnGaTerug";
            this.btnGaTerug.Size = new System.Drawing.Size(103, 60);
            this.btnGaTerug.TabIndex = 22;
            this.btnGaTerug.Text = "Ga terug";
            this.btnGaTerug.UseVisualStyleBackColor = true;
            this.btnGaTerug.Click += new System.EventHandler(this.btnGaTerug_Click);
            // 
            // cboID
            // 
            this.cboID.FormattingEnabled = true;
            this.cboID.Location = new System.Drawing.Point(381, 32);
            this.cboID.Name = "cboID";
            this.cboID.Size = new System.Drawing.Size(197, 24);
            this.cboID.TabIndex = 24;
            this.cboID.SelectedIndexChanged += new System.EventHandler(this.cboID_SelectedIndexChanged);
            // 
            // lstProductPerRoute
            // 
            this.lstProductPerRoute.FormattingEnabled = true;
            this.lstProductPerRoute.ItemHeight = 16;
            this.lstProductPerRoute.Location = new System.Drawing.Point(40, 135);
            this.lstProductPerRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lstProductPerRoute.Name = "lstProductPerRoute";
            this.lstProductPerRoute.Size = new System.Drawing.Size(721, 180);
            this.lstProductPerRoute.TabIndex = 25;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 16);
            this.label1.TabIndex = 26;
            this.label1.Text = "Product ID + Naam";
            // 
            // frmProductOpProductPerRoute
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lstProductPerRoute);
            this.Controls.Add(this.cboID);
            this.Controls.Add(this.btnGaTerug);
            this.Name = "frmProductOpProductPerRoute";
            this.Text = "frmProductOpProductPerRoute";
            this.Load += new System.EventHandler(this.frmProductOpProductPerRoute_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGaTerug;
        private System.Windows.Forms.ComboBox cboID;
        private System.Windows.Forms.ListBox lstProductPerRoute;
        private System.Windows.Forms.Label label1;
    }
}