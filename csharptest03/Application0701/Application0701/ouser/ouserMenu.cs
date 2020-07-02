using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0701.ouser
{
    public partial class ouserMenu : Form
    {
        public ouserMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Exit?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void ouserMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.Show();
        }

        private void searchFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchFlight frm1 = new searchFlight();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void foodServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foodService frm2 = new foodService();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void flightStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flightStatus frm3 = new flightStatus();
            frm3.MdiParent = this;
            frm3.Show();
        }
    }
}
