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
    public partial class flightStatus : Form
    {
        public flightStatus()
        {
            InitializeComponent();
        }

        private void flightStatus_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
            this.reportViewer1.RefreshReport();
        }
    }
}
