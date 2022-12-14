namespace ProductManagement
{
    partial class frmMain
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
            this.ptbProduct = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.ptbReceipt = new System.Windows.Forms.PictureBox();
            this.ptbExport = new System.Windows.Forms.PictureBox();
            this.ptbReport = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReceipt)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReport)).BeginInit();
            this.SuspendLayout();
            // 
            // ptbProduct
            // 
            this.ptbProduct.Image = global::ProductManagement.Properties.Resources._318572771_494849802498022_8345026025173901497_n;
            this.ptbProduct.InitialImage = null;
            this.ptbProduct.Location = new System.Drawing.Point(166, 97);
            this.ptbProduct.Name = "ptbProduct";
            this.ptbProduct.Size = new System.Drawing.Size(110, 103);
            this.ptbProduct.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbProduct.TabIndex = 0;
            this.ptbProduct.TabStop = false;
            this.ptbProduct.Click += new System.EventHandler(this.ptbProduct_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 215);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 16);
            this.label1.TabIndex = 6;
            this.label1.Text = "Product";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(375, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "Receipt";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(376, 372);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 16);
            this.label3.TabIndex = 8;
            this.label3.Text = "Export";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(195, 372);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 16);
            this.label6.TabIndex = 9;
            this.label6.Text = "Report";
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(30, 35);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 28);
            this.btnLogout.TabIndex = 10;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // ptbReceipt
            // 
            this.ptbReceipt.Image = global::ProductManagement.Properties.Resources._319450253_453637193634994_3999999253889852929_n;
            this.ptbReceipt.InitialImage = null;
            this.ptbReceipt.Location = new System.Drawing.Point(341, 97);
            this.ptbReceipt.Name = "ptbReceipt";
            this.ptbReceipt.Size = new System.Drawing.Size(110, 103);
            this.ptbReceipt.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbReceipt.TabIndex = 11;
            this.ptbReceipt.TabStop = false;
            this.ptbReceipt.Click += new System.EventHandler(this.ptbReceipt_Click);
            // 
            // ptbExport
            // 
            this.ptbExport.Image = global::ProductManagement.Properties.Resources._318945725_947035556704591_3418047667652174133_n;
            this.ptbExport.InitialImage = null;
            this.ptbExport.Location = new System.Drawing.Point(341, 254);
            this.ptbExport.Name = "ptbExport";
            this.ptbExport.Size = new System.Drawing.Size(110, 103);
            this.ptbExport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbExport.TabIndex = 13;
            this.ptbExport.TabStop = false;
            this.ptbExport.Click += new System.EventHandler(this.ptbExport_Click);
            // 
            // ptbReport
            // 
            this.ptbReport.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.ptbReport.Image = global::ProductManagement.Properties.Resources._318037890_854351202479870_3520052751415555567_n;
            this.ptbReport.InitialImage = null;
            this.ptbReport.Location = new System.Drawing.Point(166, 254);
            this.ptbReport.Name = "ptbReport";
            this.ptbReport.Size = new System.Drawing.Size(110, 103);
            this.ptbReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbReport.TabIndex = 12;
            this.ptbReport.TabStop = false;
            this.ptbReport.Click += new System.EventHandler(this.ptbReport_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 450);
            this.Controls.Add(this.ptbExport);
            this.Controls.Add(this.ptbReport);
            this.Controls.Add(this.ptbReceipt);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbProduct);
            this.MaximizeBox = false;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Product Management";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReceipt)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.PictureBox ptbReceipt;
        private System.Windows.Forms.PictureBox ptbExport;
        private System.Windows.Forms.PictureBox ptbReport;
    }
}