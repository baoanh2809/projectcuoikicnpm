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
    public partial class frmReceiptDetailEdit : Form
    {
        private string receiptID;
        SqlConnection conn = new SqlConnection(Program.strConn);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public frmReceiptDetailEdit()
        {
            InitializeComponent();
        }

        public string ReceiptID { get => receiptID; set => receiptID = value; }

        public void loadData()
        {
            String sSQL = "select * from ReceiptDetails where receiptID = '" + receiptID + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dt.Columns.Remove("receiptID");
            dgvReceiptDetailEdit.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceiptDetailEdit_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = dgvReceiptDetailEdit.CurrentRow.Index;
            int receiptDetailID = int.Parse(dgvReceiptDetailEdit.Rows[i].Cells[0].Value.ToString());

            String sSQL = "update ReceiptDetails set proName = '" + cbProName.Text + "', proID = '" + txtProID.Text + "', amount = " + nmrAmount.Value + ", unitPrice = " + nmrUnitPrice.Value + " where receiptDetailID = '" + receiptDetailID + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully");
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

        private void dgvReceiptDetailEdit_SelectionChanged(object sender, EventArgs e)
        {
            cbProName.ResetText();
            int i = dgvReceiptDetailEdit.CurrentRow.Index;
            cbProName.SelectedText = dgvReceiptDetailEdit.Rows[i].Cells[2].Value.ToString();
            nmrAmount.Value = int.Parse(dgvReceiptDetailEdit.Rows[i].Cells[3].Value.ToString());

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
    }
}
