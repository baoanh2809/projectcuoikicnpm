namespace ProductManagement
{
    partial class frmReport
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
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnTurnover = new System.Windows.Forms.Button();
            this.btnBestSeller = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.nmrMonth = new System.Windows.Forms.NumericUpDown();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMonth)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(341, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 38);
            this.label5.TabIndex = 16;
            this.label5.Text = "Report";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnTurnover);
            this.panel1.Controls.Add(this.btnBestSeller);
            this.panel1.Location = new System.Drawing.Point(78, 159);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 118);
            this.panel1.TabIndex = 17;
            // 
            // btnTurnover
            // 
            this.btnTurnover.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnTurnover.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTurnover.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTurnover.Location = new System.Drawing.Point(0, 58);
            this.btnTurnover.Name = "btnTurnover";
            this.btnTurnover.Size = new System.Drawing.Size(127, 58);
            this.btnTurnover.TabIndex = 2;
            this.btnTurnover.Text = "Turnover";
            this.btnTurnover.UseVisualStyleBackColor = true;
            this.btnTurnover.Click += new System.EventHandler(this.btnTurnover_Click);
            // 
            // btnBestSeller
            // 
            this.btnBestSeller.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBestSeller.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBestSeller.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBestSeller.Location = new System.Drawing.Point(0, 0);
            this.btnBestSeller.Name = "btnBestSeller";
            this.btnBestSeller.Size = new System.Drawing.Size(127, 58);
            this.btnBestSeller.TabIndex = 1;
            this.btnBestSeller.Text = "Best seller";
            this.btnBestSeller.UseVisualStyleBackColor = true;
            this.btnBestSeller.Click += new System.EventHandler(this.btnBestSeller_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(211, 159);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.RowHeadersWidth = 51;
            this.dgvReport.RowTemplate.Height = 24;
            this.dgvReport.Size = new System.Drawing.Size(501, 116);
            this.dgvReport.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(295, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 16);
            this.label1.TabIndex = 19;
            this.label1.Text = "Month";
            // 
            // nmrMonth
            // 
            this.nmrMonth.Location = new System.Drawing.Point(360, 123);
            this.nmrMonth.Maximum = new decimal(new int[] {
            12,
            0,
            0,
            0});
            this.nmrMonth.Name = "nmrMonth";
            this.nmrMonth.Size = new System.Drawing.Size(120, 22);
            this.nmrMonth.TabIndex = 20;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(348, 306);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 21;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 357);
            this.ControlBox = false;
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.nmrMonth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Name = "frmReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Report";
            this.Load += new System.EventHandler(this.frmReport_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrMonth)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nmrMonth;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnTurnover;
        private System.Windows.Forms.Button btnBestSeller;
    }
}