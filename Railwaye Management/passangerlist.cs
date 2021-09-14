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
    public partial class passangerlist : Form
    {
        public passangerlist()
        {
            InitializeComponent();
        }

        private void passangerlist_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tcDataSet1.tc' table. You can move, or remove it, as needed.
            this.tcTableAdapter.Fill(this.tcDataSet1.tc);

        }
    }
}
