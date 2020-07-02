using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0619.ouser
{
    public partial class ouserMenu : Form
    {
        public ouserMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void searchFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchFlights frm1 = new searchFlights();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void ouserMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Exit the system?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm4 = new Login();
            frm4.Show();
            this.Hide();
        }

        private void foodServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foodServices frm2 = new foodServices();
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
