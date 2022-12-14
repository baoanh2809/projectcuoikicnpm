namespace ProductManagement
{
    partial class frmCreateExport
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
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.cbProName = new System.Windows.Forms.ComboBox();
            this.nmrUnitPrice = new System.Windows.Forms.NumericUpDown();
            this.nmrAmount = new System.Windows.Forms.NumericUpDown();
            this.dgvCreateExport = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtProID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblProduct = new System.Windows.Forms.Label();
            this.lblCustomer = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateExport)).BeginInit();
            this.pnlBody.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(197, 290);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(100, 28);
            this.btnDelete.TabIndex = 34;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(63, 290);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(4);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(100, 28);
            this.btnAdd.TabIndex = 33;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // cbProName
            // 
            this.cbProName.FormattingEnabled = true;
            this.cbProName.Items.AddRange(new object[] {
            "Deodorant Spray",
            "Deodorant Soap",
            "Deodorant Set mini",
            "Deodorant Set large"});
            this.cbProName.Location = new System.Drawing.Point(158, 74);
            this.cbProName.Name = "cbProName";
            this.cbProName.Size = new System.Drawing.Size(176, 24);
            this.cbProName.TabIndex = 32;
            this.cbProName.SelectedIndexChanged += new System.EventHandler(this.cbProName_SelectedIndexChanged);
            // 
            // nmrUnitPrice
            // 
            this.nmrUnitPrice.Enabled = false;
            this.nmrUnitPrice.Location = new System.Drawing.Point(158, 230);
            this.nmrUnitPrice.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.nmrUnitPrice.Name = "nmrUnitPrice";
            this.nmrUnitPrice.Size = new System.Drawing.Size(176, 22);
            this.nmrUnitPrice.TabIndex = 31;
            // 
            // nmrAmount
            // 
            this.nmrAmount.Location = new System.Drawing.Point(158, 178);
            this.nmrAmount.Name = "nmrAmount";
            this.nmrAmount.Size = new System.Drawing.Size(176, 22);
            this.nmrAmount.TabIndex = 30;
            // 
            // dgvCreateExport
            // 
            this.dgvCreateExport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCreateExport.Location = new System.Drawing.Point(390, 63);
            this.dgvCreateExport.Name = "dgvCreateExport";
            this.dgvCreateExport.RowHeadersWidth = 51;
            this.dgvCreateExport.RowTemplate.Height = 24;
            this.dgvCreateExport.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCreateExport.Size = new System.Drawing.Size(553, 244);
            this.dgvCreateExport.TabIndex = 29;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(370, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(228, 38);
            this.label5.TabIndex = 28;
            this.label5.Text = "Create export";
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(488, 342);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 28);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(352, 342);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 28);
            this.btnNext.TabIndex = 26;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 16);
            this.label3.TabIndex = 25;
            this.label3.Text = "Unit price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 16);
            this.label4.TabIndex = 24;
            this.label4.Text = "Amount";
            // 
            // txtProID
            // 
            this.txtProID.Enabled = false;
            this.txtProID.Location = new System.Drawing.Point(158, 124);
            this.txtProID.Name = "txtProID";
            this.txtProID.Size = new System.Drawing.Size(176, 22);
            this.txtProID.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Product ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 21;
            this.label1.Text = "Product name";
            // 
            // lblProduct
            // 
            this.lblProduct.AutoSize = true;
            this.lblProduct.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProduct.Location = new System.Drawing.Point(357, 19);
            this.lblProduct.Name = "lblProduct";
            this.lblProduct.Size = new System.Drawing.Size(96, 29);
            this.lblProduct.TabIndex = 35;
            this.lblProduct.Text = "Product";
            this.lblProduct.Click += new System.EventHandler(this.lblProduct_Click);
            // 
            // lblCustomer
            // 
            this.lblCustomer.AutoSize = true;
            this.lblCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomer.Location = new System.Drawing.Point(481, 19);
            this.lblCustomer.Name = "lblCustomer";
            this.lblCustomer.Size = new System.Drawing.Size(117, 29);
            this.lblCustomer.TabIndex = 36;
            this.lblCustomer.Text = "Customer";
            this.lblCustomer.Click += new System.EventHandler(this.lblCustomer_Click);
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.btnDelete);
            this.pnlBody.Controls.Add(this.lblCustomer);
            this.pnlBody.Controls.Add(this.btnAdd);
            this.pnlBody.Controls.Add(this.lblProduct);
            this.pnlBody.Controls.Add(this.cbProName);
            this.pnlBody.Controls.Add(this.nmrUnitPrice);
            this.pnlBody.Controls.Add(this.btnClose);
            this.pnlBody.Controls.Add(this.nmrAmount);
            this.pnlBody.Controls.Add(this.btnNext);
            this.pnlBody.Controls.Add(this.dgvCreateExport);
            this.pnlBody.Controls.Add(this.label3);
            this.pnlBody.Controls.Add(this.label4);
            this.pnlBody.Controls.Add(this.txtProID);
            this.pnlBody.Controls.Add(this.label2);
            this.pnlBody.Controls.Add(this.label1);
            this.pnlBody.Location = new System.Drawing.Point(15, 84);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(974, 389);
            this.pnlBody.TabIndex = 37;
            // 
            // frmCreateExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1001, 485);
            this.ControlBox = false;
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.label5);
            this.Name = "frmCreateExport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Create Export";
            this.Load += new System.EventHandler(this.frmCreateExport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nmrUnitPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nmrAmount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCreateExport)).EndInit();
            this.pnlBody.ResumeLayout(false);
            this.pnlBody.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ComboBox cbProName;
        private System.Windows.Forms.NumericUpDown nmrUnitPrice;
        private System.Windows.Forms.NumericUpDown nmrAmount;
        private System.Windows.Forms.DataGridView dgvCreateExport;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtProID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblProduct;
        private System.Windows.Forms.Label lblCustomer;
        private System.Windows.Forms.Panel pnlBody;
    }
}