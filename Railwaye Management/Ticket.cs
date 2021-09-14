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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(global::Railwaye_Management.Properties.Settings.Default.tcConnectionString);
        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            richTextBox1.Text  += "******************\n";
            richTextBox1.Text += "**********Ticket****\n";
            richTextBox1.Text += "********************\n";
            richTextBox1.Text += "Date:" + DateTime.Now + "\n\n";
            richTextBox1.Text +="Name:"+textBox1.Text+"\n\n";
            richTextBox1.Text += "From:" + textBox2.Text + "\n\n";
            richTextBox1.Text += "To:" + textBox3.Text + "\n\n";
            richTextBox1.Text += "Fee:" + textBox4.Text + "\n\n";
        }

        
        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "insert into tc values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
           

            MessageBox.Show("Added Successfully");
        }

        public void disp_data()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select * from tc";
            cmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, new Font("Times New Roman", 14, FontStyle.Bold), Brushes.Black, new Point(10, 10));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            passangerlist mm = new passangerlist();
            mm.Show();
            disp_data();

        }
    }
}
