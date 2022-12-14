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
    public partial class frmExport : Form
    {
        SqlConnection conn = new SqlConnection(Program.strConn);
        DataTable dt = new DataTable();

        public void loadData()
        {
            String sSQL = "select * from Exports";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dgvExport.DataSource = dt;
        }
        public frmExport()
        {
            InitializeComponent();
        }

        private void frmExport_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadData();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            frmCreateExport f = new frmCreateExport();
            f.ShowDialog();
            loadData();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvExport.Rows.Count <= 1)
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                int i = dgvExport.CurrentRow.Index;

                frmExportDetailEdit f = new frmExportDetailEdit();
                f.ExportID = dgvExport.Rows[i].Cells[0].Value.ToString();
                f.ShowDialog();
            }
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            if (dgvExport.Rows.Count <= 1)
            {
                MessageBox.Show("Invalid");
            }
            else
            {
                int i = dgvExport.CurrentRow.Index;

                frmExportDetail f = new frmExportDetail();
                f.ExportID = dgvExport.Rows[i].Cells[0].Value.ToString();
                f.ShowDialog();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvExport_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (dgvExport.Rows.Count <= 1) {}

            else
            {
                int i = dgvExport.CurrentRow.Index;

                frmExportDetail f = new frmExportDetail();
                f.ExportID = dgvExport.Rows[i].Cells[0].Value.ToString();
                f.ShowDialog();
            }
        }
    }
}
