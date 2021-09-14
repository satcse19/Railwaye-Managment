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
    
    public partial class train_shedule_and_dely : Form
    {
        public train_shedule_and_dely()
        {
            InitializeComponent();
        }
        
        private void label4_Click(object sender, EventArgs e)
        {

        }

       
        
        SqlConnection con = new SqlConnection(global::Railwaye_Management.Properties.Settings.Default.infoConnectionString);
        string delly;
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into info values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','"+delly+"')";
            cmd.ExecuteNonQuery(); 
            con.Close();
            disp_data();

            MessageBox.Show("Added Successfully");
        }
        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from info";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            delly = "Yes";
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            delly = "No";
        }

        private void train_shedule_and_dely_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'infoDataSet1.info' table. You can move, or remove it, as needed.
            this.infoTableAdapter.Fill(this.infoDataSet1.info);

        }
    }

}
