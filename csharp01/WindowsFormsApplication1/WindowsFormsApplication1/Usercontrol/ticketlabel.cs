using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1.Usercontrol
{
    public partial class ticketlabel : UserControl
    {
        private string rate;
        private int totalTickets;
        private int soldTickets;
        private int seatsSelected;

        public string Rate
        {
            get
            {
                return lblrate.Text;
            }

            set
            {
                rate = value;
                lblrate.Text = rate;
            }
        }

        public int TotalTickets
        {
            get
            {
                return Convert.ToInt32(lbltotal.Text);
            }

            set
            {
                totalTickets = value;
                lbltotal.Text = totalTickets.ToString();
            }
        }

        public int SoldTickets
        {
            get
            {
                return Convert.ToInt32(lblsold.Text);
            }

            set
            {
                soldTickets = value;
                lblsold.Text = soldTickets.ToString();
            }
        }

        public int SeatsSelected
        {
            get
            {
                return Convert.ToInt32(lblseat.Text);
            }

            set
            {
                seatsSelected = value;
                lblseat.Text = seatsSelected.ToString();
            }
        }

        public ticketlabel()
        {
            InitializeComponent();
        }

        private void ticketlabel_Load(object sender, EventArgs e)
        {

        }
    }
}
