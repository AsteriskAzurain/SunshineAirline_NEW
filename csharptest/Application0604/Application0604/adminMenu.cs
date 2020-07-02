using Application0604.admin;
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
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();

            IsMdiContainer = true;
        }

        private void flightScheduleManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flightScheduleManagement frm = new flightScheduleManagement();
            frm.MdiParent = this;
            frm.Parent = panel1;
            frm.Show();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login frm = new login();
            frm.Show();
            this.Hide();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm exit?", "confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK) {
                System.Environment.Exit(0);
            }
        }

        private void ticketStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticketStatistics frm = new ticketStatistics();
            frm.MdiParent = this;
            frm.Parent = panel1;
            frm.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userManagement frm = new userManagement();
            frm.MdiParent = this;
            frm.Parent = panel1;
            frm.Show();
        }
    }
}
