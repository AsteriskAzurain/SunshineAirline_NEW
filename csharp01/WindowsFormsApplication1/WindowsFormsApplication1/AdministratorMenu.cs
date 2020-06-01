using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class AdministratorMenu : Form
    {
        public AdministratorMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void AdministratorMenu_Load(object sender, EventArgs e)
        {

        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            this.Hide();
            frmlogin.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Exit system?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }

        }

        private void userManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            admin_usermanagement frmum = new admin_usermanagement();
            frmum.MdiParent = this;
            frmum.Parent = panel1;
            frmum.Show();
        }

        private void ticketStatisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            admin_ticketstatisics frmts = new admin_ticketstatisics();
            frmts.MdiParent = this;
            frmts.Parent = panel1;
            frmts.Show();
        }

        private void flightsScheduleManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            admin_flightScheduleManagement frmfsm = new admin_flightScheduleManagement();
            frmfsm.MdiParent = this;
            frmfsm.Parent = panel1;
            frmfsm.Show();
            
        }
    }
}
