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
    public partial class frmCreateReceipt : Form
    {
        SqlConnection conn = new SqlConnection(Program.strConn);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public frmCreateReceipt()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvCreateReceipt.Rows.Count <= 1)
            {
                MessageBox.Show("Please enter data");
            }

            else
            {
                int row = dgvCreateReceipt.Rows.Count;
                //Get new ReceiptID
                String sSQL = "select * from Receipts";
                cmd = new SqlCommand(sSQL, conn);
                da = new SqlDataAdapter(cmd);
                DataTable tempDt = new DataTable();
                da.Fill(tempDt);
                String receiptID;
                if (tempDt.Rows.Count <= 9)
                {
                    receiptID = "RC0" + tempDt.Rows.Count;
                }
                else
                {
                    receiptID = "RC" + tempDt.Rows.Count;
                }

                //Add new Receit
                sSQL = "insert Receipts (receiptID, created) values ('" + receiptID + "', getdate())";
                cmd = new SqlCommand(sSQL, conn);
                cmd.ExecuteNonQuery();

                for (int i = 0; i < row - 1; i++)
                {   
                    //Add all data of datagridview into Receipt detail
                    sSQL = "insert ReceiptDetails (receiptID, proID, proName, amount, unitPrice) values ('" + receiptID + "', '" + dgvCreateReceipt.Rows[i].Cells[1].Value + "', '" + dgvCreateReceipt.Rows[i].Cells[0].Value + "', '" + dgvCreateReceipt.Rows[i].Cells[2].Value + "', '" + dgvCreateReceipt.Rows[i].Cells[3].Value + "')";
                    cmd = new SqlCommand(sSQL, conn);
                    cmd.ExecuteNonQuery();

                    //Update data of Product
                    sSQL = "update Products set amount = amount + '" + dgvCreateReceipt.Rows[i].Cells[2].Value + "', updated = getdate() where proID = '" + dgvCreateReceipt.Rows[i].Cells[1].Value + "'";
                    cmd = new SqlCommand(sSQL, conn);
                    cmd.ExecuteNonQuery();
                }

                dt.Clear();
                dgvCreateReceipt.DataSource = null;
                MessageBox.Show("Succesfully");
                this.Close();
            }
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbProName_SelectedValueChanged(object sender, EventArgs e)
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

                    dgvCreateReceipt.DataSource = dt;
                }

                DataRow row;
                row = dt.NewRow();
                row["Product name"] = cbProName.Text;
                row["Product ID"] = txtProID.Text;
                row["Amount"] = nmrAmount.Value;
                row["Unit price"] = nmrUnitPrice.Value;
                dt.Rows.Add(row);

                dgvCreateReceipt.DataSource = dt;

                cbProName.Text = "";
                txtProID.Text = "";
                nmrAmount.Value = 0;
                nmrUnitPrice.Value = 0;
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dgvCreateReceipt.SelectedRows)
            {
                dgvCreateReceipt.Rows.RemoveAt(item.Index);
            }

            if (dgvCreateReceipt.Rows.Count <= 1)
            {
                dgvCreateReceipt.DataSource = null;
            }
        }
    }
}
