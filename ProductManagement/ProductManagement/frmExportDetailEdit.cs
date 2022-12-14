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
    public partial class frmExportDetailEdit : Form
    {
        private string exportID;
        SqlConnection conn = new SqlConnection(Program.strConn);
        SqlCommand cmd;
        SqlDataAdapter da;
        DataTable dt = new DataTable();

        public frmExportDetailEdit()
        {
            InitializeComponent();
        }

        public string ExportID { get => exportID; set => exportID = value; }

        public void loadData()
        {
            String sSQL = "select * from ExportDetails where exportID = '" + exportID + "'";
            cmd = new SqlCommand(sSQL, conn);
            da = new SqlDataAdapter(cmd);
            dt.Clear();
            da.Fill(dt);
            dt.Columns.Remove("exportID");
            dgvExportDetailEdit.DataSource = dt;
        }

        private void frmExportDetailEdit_Load(object sender, EventArgs e)
        {
            conn.Open();
            loadData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int i = dgvExportDetailEdit.CurrentRow.Index;
            int exportDetailID = int.Parse(dgvExportDetailEdit.Rows[i].Cells[0].Value.ToString());

            //Update ExportDetails
            String sSQL = "update ExportDetails set proName = '" + cbProName.Text + "', proID = '" + txtProID.Text + "', amount = " + nmrAmount.Value + ", unitPrice = " + nmrUnitPrice.Value + " where exportDetailID = '" + exportDetailID + "'";
            SqlCommand cmd = new SqlCommand(sSQL, conn);
            cmd.ExecuteNonQuery();

            //Update Exports
            sSQL = "update Exports set paymentStatus = '" + cbPaymentStatus.Text + "', exportStatus = '" + cbExportStatus.Text + "' where exportID = '" + exportID + "'";
            cmd = new SqlCommand(sSQL, conn);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Successfully");
            this.Close();
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

        private void dgvExportDetailEdit_SelectionChanged(object sender, EventArgs e)
        {
            cbProName.ResetText();
            cbPaymentStatus.ResetText();
            cbExportStatus.ResetText();

            int i = dgvExportDetailEdit.CurrentRow.Index;

            cbProName.SelectedText = dgvExportDetailEdit.Rows[i].Cells[2].Value.ToString();
            nmrAmount.Value = int.Parse(dgvExportDetailEdit.Rows[i].Cells[3].Value.ToString());

            //Get PaymentStatus and ExportStatus
            String sSQL = "select * from Exports where exportID = '" + exportID + "'";
            cmd = new SqlCommand(sSQL, conn);
            da = new SqlDataAdapter(cmd);
            DataTable tempDt = new DataTable();
            tempDt.Clear();
            da.Fill(tempDt);

            DataRow[] rows = tempDt.Select();
            foreach (DataRow row in rows)
            {
                cbPaymentStatus.SelectedText = row[4].ToString();
                cbExportStatus.SelectedText = row[3].ToString();
            }

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
