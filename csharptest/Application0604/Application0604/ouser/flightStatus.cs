using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0604.ouser
{
    public partial class flightStatus : Form
    {
        public flightStatus()
        {
            InitializeComponent();
        }

        private void flightStatus_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
