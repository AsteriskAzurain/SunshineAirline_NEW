using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0706.ouser
{
    public partial class ouserMenu : Form
    {
        public ouserMenu()
        {
            InitializeComponent();
        }

        private void ouserMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
            this.IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm exit?", "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void searchFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchFlights frmsf = new SearchFlights();
            frmsf.MdiParent = this;
            frmsf.Show();
        }

        private void foodServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FoodServices frmfs = new FoodServices();
            frmfs.MdiParent = this;
            frmfs.Show();
        }

        private void flightStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightStatus frmfs2 = new FlightStatus();
            frmfs2.MdiParent = this;
            frmfs2.Show();
        }
    }
}
