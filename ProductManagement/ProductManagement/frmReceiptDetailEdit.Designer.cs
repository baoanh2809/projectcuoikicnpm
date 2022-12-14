namespace ProductManagement
{
    partial class frmReceiptDetailEdit
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
            this.dgvReceiptDetailEdit = new System.Windows.Forms.DataGridView();
            this.cbProName = new System.Windows.Forms.ComboBox();
            this.nmrUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetailEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvReceiptDetailEdit
            // 
            this.dgvReceiptDetailEdit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReceiptDetailEdit.Location = new System.Drawing.Point(69, 31);
            this.dgvReceiptDetailEdit.Name = "dgvReceiptDetailEdit";
            this.dgvReceiptDetailEdit.RowHeadersWidth = 51;
            this.dgvReceiptDetailEdit.RowTemplate.Height = 24;
            this.dgvReceiptDetailEdit.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvReceiptDetailEdit.Size = new System.Drawing.Size(730, 302);
            this.dgvReceiptDetailEdit.TabIndex = 20;
            this.dgvReceiptDetailEdit.SelectionChanged += new System.EventHandler(this.dgvReceiptDetailEdit_SelectionChanged);
            // 
            // cbProName
            // 
            this.cbProName.FormattingEnabled = true;
            this.cbProName.Items.AddRange(new object[] {
            "Deodorant Spray",
            "Deodorant Soap",
            "Deodorant Set mini",
            "Deodorant Set large"});
            this.cbProName.Location = new System.Drawing.Point(216, 375);
            this.cbProName.Name = "cbProName";
            this.cbProName.Size = new System.Drawing.Size(176, 24);
            this.cbProName.TabIndex = 28;
            this.cbProName.SelectedValueChanged += new System.EventHandler(this.cbProName_SelectedValueChanged);
            // 
            // nmrUnitPrice
            // 
            this.nmrUnitPrice.Enabled = false;
            this.nmrUnitPrice.Location = new System.Drawing.Point(580, 428);
            this.nmrUnitPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmrUnitPrice.Name = "nmrUnitPrice";
            this.nmrUnitPrice.Size = new System.Drawing.Size(176, 22);
            this.nmrUnitPrice.TabIndex = 27;
            // 
            // nmrAmount
            // 
            this.nmrAmount.Location = new System.Drawing.Point(580, 372);
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(176, 22);
            this.nmrAmount.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(495, 431);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Unit price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 375);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Amount";
            // 
            // txtProID
            // 
            this.txtProID.Enabled = false;
            this.txtProID.Location = new System.Drawing.Point(216, 425);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(176, 22);
            this.txtProID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(94, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(94, 378);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Product name";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(305, 488);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(100, 28);
            this.btnSave.TabIndex = 29;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(447, 488);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 30;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmReceiptDetailEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 579);
            this.ControlBox = false;
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
            this.Controls.Add(this.dgvReceiptDetailEdit);
            this.Name = "frmReceiptDetailEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit";
            this.Load += new System.EventHandler(this.frmReceiptDetailEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReceiptDetailEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvReceiptDetailEdit;
        private System.Windows.Forms.ComboBox cbProName;
        private System.Windows.Forms.NumericUpDown nmrUnitPrice;
        private System.Windows.Forms.NumericUpDown nmrAmount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
    }
}