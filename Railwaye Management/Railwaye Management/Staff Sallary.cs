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
    public partial class Staff_Sallary : Form
    {
        public Staff_Sallary()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(global::Railwaye_Management.Properties.Settings.Default.staffConnectionString);

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from salary";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into salary values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Added Successfully");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "delete from salary where Id ='" + textBox1.Text + "'";
            cmd.ExecuteNonQuery();
            con.Close();
            disp_data();
            MessageBox.Show("Record Deleted");
        }

       

        private void Staff_Sallary_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'staffDataSet1.salary' table. You can move, or remove it, as needed.
            this.salaryTableAdapter.Fill(this.staffDataSet1.salary);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            disp_data();
        }
    }
}
