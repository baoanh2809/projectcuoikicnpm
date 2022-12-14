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
    public partial class frmReceipt : Form
    {
        SqlConnection conn = new SqlConnection(Program.strConn);
        DataTable dt = new DataTable();

        public void loadData()
        {
            String sSQL = "select * from Receipts";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dgvReceipt.DataSource = dt;
        }

        public frmReceipt()
        {
            InitializeComponent();
        }

        private void frmReceipt_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateReceipt f = new frmCreateReceipt();
            f.ShowDialog();
            loadData();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvReceipt.Rows.Count <= 1)
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                int i = dgvReceipt.CurrentRow.Index;

                frmReceiptDetail f = new frmReceiptDetail();
                f.ReceiptID = dgvReceipt.Rows[i].Cells[0].Value.ToString();
                f.ShowDialog();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvReceipt.Rows.Count <= 1)
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                int i = dgvReceipt.CurrentRow.Index;

                frmReceiptDetailEdit f = new frmReceiptDetailEdit();
                f.ReceiptID = dgvReceipt.Rows[i].Cells[0].Value.ToString();
                f.ShowDialog();
            }
        }

        private void dgvReceipt_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvReceipt.Rows.Count <= 1) { }

            else
            {
                int i = dgvReceipt.CurrentRow.Index;

                frmReceiptDetail f = new frmReceiptDetail();
                f.ReceiptID = dgvReceipt.Rows[i].Cells[0].Value.ToString();
                f.ShowDialog();
            }
        }
    }
}
