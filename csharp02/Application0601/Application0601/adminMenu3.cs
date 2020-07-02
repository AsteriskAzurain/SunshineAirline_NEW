using Application0601.admin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0601
{
    public partial class adminMenu3 : Form
    {
        public adminMenu3()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirn exit the system?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK) {
                System.Environment.Exit(0);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login1 frmlogin = new login1();
            this.Hide();
            frmlogin.Show();
        }

        private void flightScheduleManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flightScheduleManagement1 frmfsm = new flightScheduleManagement1();
            panel1.Controls.Clear();
            frmfsm.MdiParent = this;
            frmfsm.Parent = panel1;
            frmfsm.Show();
        }

        private void ticketStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ticketStatistics2 frmts = new ticketStatistics2();
            panel1.Controls.Clear();
            frmts.MdiParent = this;
            frmts.Parent = panel1;
            frmts.Show();
        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            userManagement3 frmum = new userManagement3();
            panel1.Controls.Clear();
            frmum.MdiParent = this;
            frmum.Parent = panel1;
            frmum.Show();
        }
    }
}
