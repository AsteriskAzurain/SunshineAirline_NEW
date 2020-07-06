using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0706.ouser
{
    public partial class SearchFlights : Form
    {
        public SearchFlights()
        {
            InitializeComponent();
        }

        private void SearchFlights_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);

            dateTimePicker1.MinDate = DateTime.Today;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }
    }
}
