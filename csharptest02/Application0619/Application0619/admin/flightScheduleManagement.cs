using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0619.admin
{
    public partial class flightScheduleManagement : Form
    {
        public flightScheduleManagement()
        {
            InitializeComponent();
        }

        private void flightScheduleManagement_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
        }
    }
}
