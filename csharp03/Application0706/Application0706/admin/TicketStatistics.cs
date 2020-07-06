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
    public partial class TicketStatistics : Form
    {
        public TicketStatistics()
        {
            InitializeComponent();
        }

        private void TicketStatistics_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
            dateTimePicker1.MaxDate = DateTime.Today;
            dateTimePicker2.MaxDate = DateTime.Today;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }
    }
}
