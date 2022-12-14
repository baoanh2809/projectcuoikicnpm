using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class frmCreateExport : Form
    {
        public Form currentFormChild;
        public static int totalPrice;

        public static DataTable dt = new DataTable();

        public DataTable dataTable
        {
            get
            {
                return dt;
            }
            set
            {
                dt = value;
            }
        }

        public int TotalPrice { get => totalPrice; set => totalPrice = value; }

        public frmCreateExport()
        {
            InitializeComponent();
        }

        private int getTotalPrice()
        {
            int total = 0, amount, unitPrice;
            int row = dgvCreateExport.Rows.Count;

            for (int i = 0; i < row - 1; i++)
            {
                amount = int.Parse(dgvCreateExport.Rows[i].Cells[2].Value.ToString());
                unitPrice = int.Parse(dgvCreateExport.Rows[i].Cells[3].Value.ToString());

                total += (amount * unitPrice);
            }

            return total;
        }

        private void OpenChildForm (Form childForm)
        {
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }

            currentFormChild = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pnlBody.Controls.Add(childForm);
            pnlBody.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProName_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProName.Text == "Deodorant Spray")
            {
                txtProID.Text = "SP";
                nmrUnitPrice.Value = 450000;
            }

            else if (cbProName.Text == "Deodorant Soap")
            {
                txtProID.Text = "SO";
                nmrUnitPrice.Value = 380000;
            }

            else if (cbProName.Text == "Deodorant Set mini")
            {
                txtProID.Text = "SM";
                nmrUnitPrice.Value = 290000;
            }

            else if (cbProName.Text == "Deodorant Set large")
            {
                txtProID.Text = "SL";
                nmrUnitPrice.Value = 800000;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (cbProName.Text == "")
            {
                MessageBox.Show("Please choose Product name.");
            }

            else if (nmrAmount.Value == 0)
            {
                MessageBox.Show("Please enter Unit price.");
            }

            else
            {
                if (dt.Rows.Count == 0)
                {
                    dt.Columns.Add("Product name");
                    dt.Columns.Add("Product ID");
                    dt.Columns.Add("Amount");
                    dt.Columns.Add("Unit price");

                    dgvCreateExport.DataSource = dt;
                }

                DataRow row;
                row = dt.NewRow();
                row["Product name"] = cbProName.Text;
                row["Product ID"] = txtProID.Text;
                row["Amount"] = nmrAmount.Value;
                row["Unit price"] = nmrUnitPrice.Value;
                dt.Rows.Add(row);

                dgvCreateExport.DataSource = dt;

                cbProName.Text = "";
                txtProID.Text = "";
                nmrAmount.Value = 0;
                nmrUnitPrice.Value = 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvCreateExport.SelectedRows)
            {
                dgvCreateExport.Rows.RemoveAt(item.Index);
            }

            if (dgvCreateExport.Rows.Count <= 1)
            {
                dgvCreateExport.DataSource = null;
            }
        }

        private void frmCreateExport_Load(object sender, EventArgs e)
        {
            lblProduct.ForeColor = Color.Blue;
        }

        private void lblCustomer_Click(object sender, EventArgs e)
        {
            totalPrice = getTotalPrice();
            OpenChildForm(new frmCreateExportCustomer());

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            totalPrice = getTotalPrice();
            OpenChildForm(new frmCreateExportCustomer());
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            lblCustomer.ForeColor = Color.Black;
            lblProduct.ForeColor = Color.Blue;
            if (currentFormChild != null)
            {
                currentFormChild.Close();
            }
        }
    }
}
