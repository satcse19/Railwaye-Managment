using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Railwaye_Management
{
    public partial class design : Form
    {
        public design()
        {
            InitializeComponent();
        }

        private void design_Load(object sender, EventArgs e)
        {

        }
        private void AbrirFormEnPanel(object formhija)
        {
            if (this.panelContenedor.Controls.Count > 0)
                this.panelContenedor.Controls.RemoveAt(0);
            Form fh = formhija as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();

        }
        private void btnproductos_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Ticket());
        }

        private void btnRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelContenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BTNventas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Train_tac()); 
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Staff_Sallary());
        }

        private void button4_Click(object sender, EventArgs e)
        {

            AbrirFormEnPanel(new train_shedule_and_dely());

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Track());
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 mm = new Form1();
            mm.Show();
        }
    }
}
