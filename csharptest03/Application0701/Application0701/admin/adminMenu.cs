using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0701.admin
{
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Confirm Exit?", "Confirm", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Environment.Exit(0);
            }
        }

        private void adminMenu_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            this.Hide();
            frm.Show();
        }

        private void flightScheduleManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flightScheduleManagement frm1 = new flightScheduleManagement();
            frm1.MdiParent = this;
            frm1.Show();
        }

        private void ticketStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticketStatistics frm2 = new ticketStatistics();
            frm2.MdiParent = this;
            frm2.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userManagement frm3 = new userManagement();
            frm3.MdiParent = this;
            frm3.Show();
        }
    }
}
