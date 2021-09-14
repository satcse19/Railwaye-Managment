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
    public partial class Track : Form
    {
        public Track()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(global::Railwaye_Management.Properties.Settings.Default.rechedConnectionString);
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into rech values ('" + textBox1.Text + "','" + textBox2.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added Successfully");
        }

        private void Track_Load(object sender, EventArgs e)
        {

        }
    }
}
