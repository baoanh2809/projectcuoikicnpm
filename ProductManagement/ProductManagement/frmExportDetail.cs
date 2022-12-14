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
    public partial class frmExportDetail : Form
    {
        private string exportID;

        SqlConnection conn = new SqlConnection(Program.strConn);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();
        public frmExportDetail()
        {
            InitializeComponent();
        }

        public string ExportID { get => exportID; set => exportID = value; }

        private void frmExportDetail_Load(object sender, EventArgs e)
        {
            conn.Open();
            String sSQL = "select * from ExportDetails where exportID = '" + exportID + "'";
            cmd = new SqlCommand(sSQL, conn);
            da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dt.Columns.Remove("exportID");
            dgvExportDetail.DataSource = dt;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
