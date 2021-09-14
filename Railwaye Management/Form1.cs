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

namespace Railwaye_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(Properties.Settings.Default.textloginConnectionString);
            SqlDataAdapter sda = new SqlDataAdapter("select count(*) from login where username ='" + txtuser.Text + "' and password='" + texpass.Text + "'", conn);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows[0][0].ToString() == "1")
            {
                this.Hide();
                design mm = new design();
                mm.Show();
            }

            else
            {
                MessageBox.Show("Please Enter Correct Username and Password", "Wrong Password and Username", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtuser.Clear();
            texpass.Clear();
        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to exit?", "Exit application", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
