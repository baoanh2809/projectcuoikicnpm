namespace ProductManagement
{
    partial class frmExportDetailEdit
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
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.cbProName = new System.Windows.Forms.ComboBox();
            this.nmrUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvExportDetailEdit = new System.Windows.Forms.DataGridView();
            this.cbExportStatus = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbPaymentStatus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportDetailEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(424, 509);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 41;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(282, 509);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 40;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // cbProName
            // 
            this.cbProName.FormattingEnabled = true;
            this.cbProName.Items.AddRange(new object[] {
            "Deodorant Spray",
            "Deodorant Soap",
            "Deodorant Set mini",
            "Deodorant Set large"});
            this.cbProName.Location = new System.Drawing.Point(171, 356);
            this.cbProName.Name = "cbProName";
            this.cbProName.Size = new System.Drawing.Size(176, 24);
            this.cbProName.TabIndex = 39;
            this.cbProName.SelectedValueChanged += new System.EventHandler(this.cbProName_SelectedValueChanged);
            // 
            // nmrUnitPrice
            // 
            this.nmrUnitPrice.Enabled = false;
            this.nmrUnitPrice.Location = new System.Drawing.Point(578, 410);
            this.nmrUnitPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmrUnitPrice.Name = "nmrUnitPrice";
            this.nmrUnitPrice.Size = new System.Drawing.Size(176, 22);
            this.nmrUnitPrice.TabIndex = 38;
            // 
            // nmrAmount
            // 
            this.nmrAmount.Location = new System.Drawing.Point(578, 354);
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(176, 22);
            this.nmrAmount.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(450, 412);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 36;
            this.label3.Text = "Unit price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(450, 356);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 35;
            this.label4.Text = "Amount";
            // 
            // txtProID
            // 
            this.txtProID.Enabled = false;
            this.txtProID.Location = new System.Drawing.Point(171, 406);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(176, 22);
            this.txtProID.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 409);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 33;
            this.label2.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 359);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 32;
            this.label1.Text = "Product name";
            // 
            // dgvExportDetailEdit
            // 
            this.dgvExportDetailEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExportDetailEdit.Location = new System.Drawing.Point(36, 22);
            this.dgvExportDetailEdit.Name = "dgvExportDetailEdit";
            this.dgvExportDetailEdit.RowHeadersWidth = 51;
            this.dgvExportDetailEdit.RowTemplate.Height = 24;
            this.dgvExportDetailEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExportDetailEdit.Size = new System.Drawing.Size(730, 302);
            this.dgvExportDetailEdit.TabIndex = 31;
            this.dgvExportDetailEdit.SelectionChanged += new System.EventHandler(this.dgvExportDetailEdit_SelectionChanged);
            // 
            // cbExportStatus
            // 
            this.cbExportStatus.FormattingEnabled = true;
            this.cbExportStatus.Items.AddRange(new object[] {
            "Pending",
            "Transporting",
            "Finish"});
            this.cbExportStatus.Location = new System.Drawing.Point(171, 455);
            this.cbExportStatus.Name = "cbExportStatus";
            this.cbExportStatus.Size = new System.Drawing.Size(176, 24);
            this.cbExportStatus.TabIndex = 43;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 458);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 42;
            this.label5.Text = "Export status";
            // 
            // cbPaymentStatus
            // 
            this.cbPaymentStatus.FormattingEnabled = true;
            this.cbPaymentStatus.Items.AddRange(new object[] {
            "Paid",
            "Unpaid"});
            this.cbPaymentStatus.Location = new System.Drawing.Point(578, 458);
            this.cbPaymentStatus.Name = "cbPaymentStatus";
            this.cbPaymentStatus.Size = new System.Drawing.Size(176, 24);
            this.cbPaymentStatus.TabIndex = 45;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 461);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 16);
            this.label6.TabIndex = 44;
            this.label6.Text = "Payment status";
            // 
            // frmExportDetailEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 560);
            this.Controls.Add(this.cbPaymentStatus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbExportStatus);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cbProName);
            this.Controls.Add(this.nmrUnitPrice);
            this.Controls.Add(this.nmrAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtProID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvExportDetailEdit);
            this.Name = "frmExportDetailEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.frmExportDetailEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExportDetailEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.ComboBox cbProName;
        private System.Windows.Forms.NumericUpDown nmrUnitPrice;
        private System.Windows.Forms.NumericUpDown nmrAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvExportDetailEdit;
        private System.Windows.Forms.ComboBox cbExportStatus;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbPaymentStatus;
        private System.Windows.Forms.Label label6;
    }
}