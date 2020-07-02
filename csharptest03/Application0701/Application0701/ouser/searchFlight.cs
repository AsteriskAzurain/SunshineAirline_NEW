using Application0701.global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0701.ouser
{
    public partial class searchFlight : Form
    {
        public searchFlight()
        {
            InitializeComponent();
        }

        private void searchFlight_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
            dateDEP.MinDate = DateTime.Today;

            string sql = "select CityCode, CityName from City order by CityName";
            DataTable dt = new DataTable();
            dt = SqlHelper.ExecuteDatatable(sql, null);
            cbfrom.DataSource = dt;
            cbfrom.DisplayMember = "CityName";
            cbfrom.ValueMember = "CityCode";
            cbfrom.SelectedIndex = 0;
            cbto.DataSource = dt.Copy();
            cbto.DisplayMember = "CityName";
            cbto.ValueMember = "CityCode";
            cbto.SelectedIndex = 0;
        }

        private void dateDEP_ValueChanged(object sender, EventArgs e)
        {
            dateRTN.MinDate = dateDEP.Value;
        }

        private void cbfrom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
