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
    public partial class flightOneWay : UserControl
    {
        private string price;
        private string cabinType;
        private string fltNum;
        private string dep;
        private string depTime;
        private string arr;
        private string arrTime;
        private string fltType;
        private string totalTime;
        private string availableTickets;

        public string Price {
            get { return lblPrice.Text; }
            set
            {
                price = value;
                lblPrice.Text = price;
            }
        }
        public string CabinType {
            get { return lblCabin.Text; }
            set
            {
                cabinType = value;
                lblCabin.Text = cabinType;
            }
        }
        public string FLTnum
        {
            get { return lblFLTnum.Text; }
            set
            {
                fltNum = value;
                lblFLTnum.Text = "Flight" + fltNum + " (95%)";
            }
        }
        public string DEP
        {
            get { return lblDEP.Text; }
            set
            {
                dep = value;
                lblDEP.Text = dep;
            }
        }
        public string DEPtime
        {
            get { return lbltimeDEP.Text; }
            set
            {
                depTime = value;
                lbltimeDEP.Text = depTime;
            }
        }
        public string ARR
        {
            get { return lblARR.Text; }
            set
            {
                arr = value;
                lblARR.Text = arr;
            }
        }
        public string ARRtime
        {
            get { return lbltimeARR.Text; }
            set
            {
                arrTime = value;
                lbltimeARR.Text = arrTime;
            }
        }
        public string FLTtype
        {
            get { return lblFLTtp.Text; }
            set
            {
                fltType = value;
                lblFLTtp.Text = fltType;
            }
        }
        public string TotalTime
        {
            get { return lbltt.Text; }
            set
            {
                totalTime = value;
                lbltt.Text = totalTime;
            }
        }
        public string AvailableTickets
        {
            get { return (lblavl.Text.Substring(0, lbltt.Text.IndexOf("available tickets")).Trim()); }
            set
            {
                availableTickets = value;
                lblavl.Text = availableTickets + " available tickets";
                if (Convert.ToInt32(value) <= 3) {
                    lblavl.ForeColor = Color.Red;
                }
            }
        }

        public flightOneWay()
        {
            InitializeComponent();
        }

        private void flightOneWay_Load(object sender, EventArgs e)
        {

        }
    }
}
