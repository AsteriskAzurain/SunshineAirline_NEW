using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0706.admin
{
    public partial class adminMenu : Form
    {
        public adminMenu()
        {
            InitializeComponent();
        }

        private void adminMenu_Load(object sender, EventArgs e)
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

        private void flightScheduleManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FlightScheduleManagement frmfsm = new FlightScheduleManagement();
            frmfsm.MdiParent = this;
            frmfsm.Show();
        }

        private void ticketStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TicketStatistics frmts = new TicketStatistics();
            frmts.MdiParent = this;
            frmts.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserManagement frmum = new UserManagement();
            frmum.MdiParent = this;
            frmum.Show();
        }
    }
}
