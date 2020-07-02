using Application0604.ouser;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0604
{
    public partial class ouserMenu : Form
    {
        public ouserMenu()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm exit?", "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                System.Environment.Exit(0);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void flightScheduleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flightStatus frm = new flightStatus();
            //frm.MdiParent = this;
            //frm.Parent = panel1;
            frm.Show();
        }

        private void foodServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foodServices frm = new foodServices();
            //frm.MdiParent = this;
            //frm.Parent = panel1;
            frm.Show();
        }

        private void searchFlightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchFlight frm = new searchFlight();
            //frm.MdiParent = this;
            //frm.Parent = panel1;
            frm.Show();
        }
    }
}
