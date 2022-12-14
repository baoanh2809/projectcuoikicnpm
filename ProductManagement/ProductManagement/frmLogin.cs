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
    public partial class frmLogin : Form
    {
        SqlConnection conn = new SqlConnection(Program.strConn);
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter Username.");
            }

            else if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter Password.");
            }

            else
            {
                String sSQL = "SELECT username, password FROM Users WHERE " + "username='" + txtUsername.Text + "' and password='" + txtPassword.Text + "'";
                SqlCommand cmd = new SqlCommand(sSQL, conn);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt.Rows.Count > 0)
                {
                    /*this.Visible = false;
                    this.ShowInTaskbar = false;
                    frmMain f = new frmMain();
                    f.ShowDialog();*/
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Login. Please check Username or Password!");
                }
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            conn.Open();
        }
    }
}
