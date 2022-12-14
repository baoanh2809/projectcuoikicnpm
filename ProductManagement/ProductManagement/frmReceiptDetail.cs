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
    public partial class frmReceiptDetail : Form
    {

        private string receiptID;

        SqlConnection conn = new SqlConnection(Program.strConn);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public frmReceiptDetail()
        {
            InitializeComponent();
        }

        public string ReceiptID { get => receiptID; set => receiptID = value; }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReceiptDetail_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sSQL = "select * from ReceiptDetails where receiptID = '" + receiptID + "'";
            cmd = new SqlCommand(sSQL, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dt.Columns.Remove("receiptID");
            dgvReceiptDetail.DataSource = dt;
        }
    }
}
