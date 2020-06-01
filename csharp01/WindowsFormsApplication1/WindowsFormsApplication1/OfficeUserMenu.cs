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
    public partial class OfficeUserMenu : Form
    {
        public OfficeUserMenu()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
        }
         
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmlogin frmlogin = new frmlogin();
            this.Hide();
            frmlogin.Show();
        }

        private void searchFlightsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ouser_searchflights frmsf = new ouser_searchflights();
            frmsf.MdiParent = this;
            frmsf.Parent = panel1;
            frmsf.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Exit system?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                this.Close();
            }
        }

        private void flightStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ouser_flightStatus frmflts = new ouser_flightStatus();
            frmflts.MdiParent = this;
            frmflts.Parent = panel1;
            frmflts.Show();
        }

        private void foodServicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            ouser_foodService frmfds = new ouser_foodService();
            frmfds.MdiParent = this;
            frmfds.Parent = panel1;
            frmfds.Show();
        }

        private void OfficeUserMenu_Resize(object sender, EventArgs e)
        {
            //panel1.Size = this.Size;
        }

        private void panel1_Resize(object sender, EventArgs e)
        {

        }
    }
}
