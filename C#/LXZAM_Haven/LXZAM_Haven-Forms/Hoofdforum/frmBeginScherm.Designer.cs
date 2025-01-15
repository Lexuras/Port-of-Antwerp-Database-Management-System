namespace LXZAM_Haven_Forms
{
    partial class frmBeginScherm
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
            this.btnHavenOpRoute = new System.Windows.Forms.Button();
            this.btnRouteOpProductPerRoute = new System.Windows.Forms.Button();
            this.btnProductOpProductPerRoute = new System.Windows.Forms.Button();
            this.btnSchip = new System.Windows.Forms.Button();
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnSchipOpRoute = new System.Windows.Forms.Button();
            this.btnHaven = new System.Windows.Forms.Button();
            this.btnSluit = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnHavenOpRoute
            // 
            this.btnHavenOpRoute.Location = new System.Drawing.Point(224, 141);
            this.btnHavenOpRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHavenOpRoute.Name = "btnHavenOpRoute";
            this.btnHavenOpRoute.Size = new System.Drawing.Size(151, 103);
            this.btnHavenOpRoute.TabIndex = 7;
            this.btnHavenOpRoute.Text = "Haven en Route";
            this.btnHavenOpRoute.UseVisualStyleBackColor = true;
            this.btnHavenOpRoute.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRouteOpProductPerRoute
            // 
            this.btnRouteOpProductPerRoute.Location = new System.Drawing.Point(407, 141);
            this.btnRouteOpProductPerRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnRouteOpProductPerRoute.Name = "btnRouteOpProductPerRoute";
            this.btnRouteOpProductPerRoute.Size = new System.Drawing.Size(151, 103);
            this.btnRouteOpProductPerRoute.TabIndex = 8;
            this.btnRouteOpProductPerRoute.Text = "Route op Product\r\n";
            this.btnRouteOpProductPerRoute.UseVisualStyleBackColor = true;
            this.btnRouteOpProductPerRoute.Click += new System.EventHandler(this.btnRouteOpProductPerRoute_Click);
            // 
            // btnProductOpProductPerRoute
            // 
            this.btnProductOpProductPerRoute.Location = new System.Drawing.Point(589, 141);
            this.btnProductOpProductPerRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProductOpProductPerRoute.Name = "btnProductOpProductPerRoute";
            this.btnProductOpProductPerRoute.Size = new System.Drawing.Size(151, 103);
            this.btnProductOpProductPerRoute.TabIndex = 9;
            this.btnProductOpProductPerRoute.Text = "Product op Route";
            this.btnProductOpProductPerRoute.UseVisualStyleBackColor = true;
            this.btnProductOpProductPerRoute.Click += new System.EventHandler(this.btnProductOpProductPerRoute_Click);
            // 
            // btnSchip
            // 
            this.btnSchip.Location = new System.Drawing.Point(452, 11);
            this.btnSchip.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSchip.Name = "btnSchip";
            this.btnSchip.Size = new System.Drawing.Size(151, 103);
            this.btnSchip.TabIndex = 4;
            this.btnSchip.Text = "Schip";
            this.btnSchip.UseVisualStyleBackColor = true;
            this.btnSchip.Click += new System.EventHandler(this.btnSchip_Click);
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(260, 11);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(151, 103);
            this.btnProduct.TabIndex = 1;
            this.btnProduct.Text = "Product";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnSchipOpRoute
            // 
            this.btnSchipOpRoute.Location = new System.Drawing.Point(27, 141);
            this.btnSchipOpRoute.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSchipOpRoute.Name = "btnSchipOpRoute";
            this.btnSchipOpRoute.Size = new System.Drawing.Size(151, 103);
            this.btnSchipOpRoute.TabIndex = 6;
            this.btnSchipOpRoute.Text = "Schip en Route";
            this.btnSchipOpRoute.UseVisualStyleBackColor = true;
            this.btnSchipOpRoute.Click += new System.EventHandler(this.btnSchipOpRoute_Click);
            // 
            // btnHaven
            // 
            this.btnHaven.Location = new System.Drawing.Point(73, 11);
            this.btnHaven.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnHaven.Name = "btnHaven";
            this.btnHaven.Size = new System.Drawing.Size(151, 103);
            this.btnHaven.TabIndex = 3;
            this.btnHaven.Text = "Haven";
            this.btnHaven.UseVisualStyleBackColor = true;
            this.btnHaven.Click += new System.EventHandler(this.btnHaven_Click);
            // 
            // btnSluit
            // 
            this.btnSluit.Location = new System.Drawing.Point(27, 272);
            this.btnSluit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSluit.Name = "btnSluit";
            this.btnSluit.Size = new System.Drawing.Size(713, 134);
            this.btnSluit.TabIndex = 5;
            this.btnSluit.Text = "Sluit de applicatie af";
            this.btnSluit.UseVisualStyleBackColor = true;
            this.btnSluit.Click += new System.EventHandler(this.btnSluit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = global::LXZAM_Haven_Forms.Properties.Resources.havenlogo;
            this.pictureBox1.Location = new System.Drawing.Point(634, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // frmBeginScherm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnProductOpProductPerRoute);
            this.Controls.Add(this.btnRouteOpProductPerRoute);
            this.Controls.Add(this.btnHavenOpRoute);
            this.Controls.Add(this.btnSchipOpRoute);
            this.Controls.Add(this.btnSluit);
            this.Controls.Add(this.btnSchip);
            this.Controls.Add(this.btnHaven);
            this.Controls.Add(this.btnProduct);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmBeginScherm";
            this.Text = "Homescreen";
            this.Load += new System.EventHandler(this.frmBeginScherm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnHavenOpRoute;
        private System.Windows.Forms.Button btnRouteOpProductPerRoute;
        private System.Windows.Forms.Button btnProductOpProductPerRoute;
        private System.Windows.Forms.Button btnSchip;
        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnSchipOpRoute;
        private System.Windows.Forms.Button btnHaven;
        private System.Windows.Forms.Button btnSluit;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}