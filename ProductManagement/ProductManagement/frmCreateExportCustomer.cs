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
    public partial class frmCreateExportCustomer : Form
    {
        SqlConnection conn = new SqlConnection(Program.strConn);
        SqlCommand cmd;
        SqlDataAdapter da;

        public bool IsNumber(string value)
        {
            foreach (Char c in value)
            {
                if (!Char.IsDigit(c))
                    return false;
            }
            return true;
        }

        public frmCreateExportCustomer()
        {
            InitializeComponent();
        }

        private void frmCreateExportCustomer_Load(object sender, EventArgs e)
        {
            conn.Open();
            lblCustomer.ForeColor = Color.Blue;

            frmCreateExport f = new frmCreateExport();
            lblTotalPrice.Text = f.TotalPrice.ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            lblCustomer.ForeColor = Color.Black;
            lblProduct.ForeColor = Color.Blue;
            this.Close();
        }

        private void lblProduct_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCusName.Text == "")
            {
                MessageBox.Show("Please enter customer name.");
            }

            else if (txtPhone.Text == "")
            {
                MessageBox.Show("Please enter customer phone number.");
            }

            else if (!IsNumber(txtPhone.Text) || txtPhone.Text.Length != 10) {
                MessageBox.Show("Phone number is unvalid");
            }

            else if (rbCash.Checked == false && rbTransfer.Checked == false && rbMomo.Checked == false)
            {
                MessageBox.Show("Please choose payment method.");
            }

            else if (rbPaid.Checked == false && rbUnpaid.Checked == false)
            {
                MessageBox.Show("Please choose payment method.");
            }

            else
            {
                frmCreateExport f = new frmCreateExport();

                if (f.TotalPrice == 0)
                {
                    MessageBox.Show("Please enter products.");
                }
                else
                {
                    string paymentMethod = "", paymentStatus = "";

                    if (rbCash.Checked == true)
                    {
                        paymentMethod = "Cash";
                    }
                    else if (rbTransfer.Checked == true)
                    {
                        paymentMethod = "Transfer";
                    }
                    else if (rbMomo.Checked == true)
                    {
                        paymentMethod = "Momo";
                    }

                    if (rbPaid.Checked == true)
                    {
                        paymentStatus = "Paid";
                    }
                    else if (rbUnpaid.Checked == true)
                    {
                        paymentStatus = "Unpaid";
                    }

                    //Get Export ID
                    String sSQL = "select * from Exports";
                    cmd = new SqlCommand(sSQL, conn);
                    da = new SqlDataAdapter(cmd);
                    DataTable tempDt = new DataTable();
                    da.Fill(tempDt);
                    String exportID;
                    if (tempDt.Rows.Count <= 9)
                    {
                        exportID = "EP0" + tempDt.Rows.Count;
                    }
                    else
                    {
                        exportID = "EP" + tempDt.Rows.Count;
                    }

                    sSQL = "insert Exports (exportID, cusName, cusNumber, exportStatus, paymentStatus, paymentMethod, totalPrice, created) values ('" + exportID + "', '" + txtCusName.Text + "', '" + txtPhone.Text + "', 'Pending', '" + paymentStatus + "', '" + paymentMethod + "', " + f.TotalPrice + ", getdate())";
                    cmd = new SqlCommand(sSQL, conn);
                    cmd.ExecuteNonQuery();

                    DataRow[] rows = f.dataTable.Select();
                    foreach (DataRow row in rows)
                    {
                        //Add all data of datagridview into Receipt detail
                        sSQL = "insert ExportDetails (exportID, proID, proName, amount, unitPrice) values ('" + exportID + "', '"  + row[1] + "', '" + row[0] + "', '" + row[2] + "', '" + row[3] + "')";
                        cmd = new SqlCommand(sSQL, conn);
                        cmd.ExecuteNonQuery();

                        //Update data of Product
                        sSQL = "update Products set amount = amount - '" + row[2] + "', updated = getdate() where proID = '" + row[1] + "'";
                        cmd = new SqlCommand(sSQL, conn);
                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Succesfully");
                    this.Close();
                    Application.OpenForms["frmCreateExport"].Close();
                }
            }
        }
    }
}
