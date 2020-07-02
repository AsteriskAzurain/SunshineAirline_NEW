using Application0601.ouser;
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
    public partial class ouserMenu2 : Form
    {
        public ouserMenu2()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm exit the system?","Confirm",MessageBoxButtons.OKCancel,MessageBoxIcon.Question) == DialogResult.OK) {
                System.Environment.Exit(0);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login1 frmlogin = new login1();
            this.Hide();
            frmlogin.Show();
        }

        private void searchFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            searchFlights1 frmsf = new searchFlights1();
            panel1.Controls.Clear();
            frmsf.MdiParent = this;
            frmsf.Parent = panel1;
            frmsf.Show();
        }

        private void foodServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foodServices2 frmfs = new foodServices2();
            panel1.Controls.Clear();
            frmfs.MdiParent = this;
            frmfs.Parent = panel1;
            frmfs.Show();
        }

        private void flightStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            flightStatus3 frmflts = new flightStatus3();
            panel1.Controls.Clear();
            frmflts.MdiParent = this;
            frmflts.Parent = panel1;
            frmflts.Show();
        }
    }
}
