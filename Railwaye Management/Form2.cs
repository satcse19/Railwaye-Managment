using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Railwaye_Management
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            train_shedule_and_dely mm = new train_shedule_and_dely();
            mm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Ticket mm = new Ticket();
            mm.Show();
        }
    }
}
