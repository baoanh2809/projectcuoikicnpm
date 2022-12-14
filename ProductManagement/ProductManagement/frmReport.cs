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
    public partial class frmReport : Form
    {
        SqlConnection conn = new SqlConnection(Program.strConn);
        DataTable dt = new DataTable();        

        public void loadData(string sSQL)
        {
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dgvReport.DataSource = dt;
        }

        public frmReport()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            conn.Open();
        }

        private void btnBestSeller_Click(object sender, EventArgs e)
        {
            if (nmrMonth.Value == 0)
            {
                MessageBox.Show("Please choose month");
            }
            else
            {
                String sSQL = "select Top(1) A.proID, A.proName, A.unitPrice, sum(C.amount) as 'totalAmount' from Products A, Exports B, ExportDetails C where Month(B.created) = " + nmrMonth.Value + " and B.ExportID=C.ExportID and C.proID=A.proID group by A.proID, A.proName, A.unitPrice order by [totalAmount] DESC";
                loadData(sSQL);
            }
        }

        private void btnTurnover_Click(object sender, EventArgs e)
        {
            if (nmrMonth.Value == 0)
            {
                MessageBox.Show("Please choose month");
            }
            else
            {
                String sSQL = "select sum(totalPrice) as 'turnover' from Exports where Month(created) = " + nmrMonth.Value;
                loadData(sSQL);
            }
        }
    }
}
