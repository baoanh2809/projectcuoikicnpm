using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductManagement
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmLogin f = new frmLogin();
            f.ShowDialog();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            /*frmLogin f = new frmLogin();
            f.Visible = true;
            f.ShowInTaskbar = true;
            this.Close();*/
        }

        private void ptbProduct_Click(object sender, EventArgs e)
        {
            frmWarehouse f = new frmWarehouse();
            f.ShowDialog();
        }

        private void ptbReceipt_Click(object sender, EventArgs e)
        {
            frmReceipt f = new frmReceipt();
            f.ShowDialog();
        }

        private void ptbReport_Click(object sender, EventArgs e)
        {
            frmReport f = new frmReport();
            f.ShowDialog();
        }

        private void ptbExport_Click(object sender, EventArgs e)
        {
            frmExport f = new frmExport();
            f.ShowDialog();
        }
    }
}
