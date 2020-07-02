using Application0604.global;
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
    public partial class searchFlight : Form
    {

        string sql;
        DataTable dt = new DataTable();

        public searchFlight()
        {
            InitializeComponent();

            loadcity();

            dateDEP.MinDate = DateTime.Today;
            dateRTN.MinDate = DateTime.Today;
        }

        private void loadcity()
        {
            sql = "select CityCode, CityName from City order by CityName";
            dt = SqlHelper.ExecuteDatatable(sql, null);

            cbfromcity.DataSource = dt;
            cbfromcity.DisplayMember = "CityName";
            cbfromcity.ValueMember = "CityCode";
            cbfromcity.SelectedIndex = 0;

            cbtocity.DataSource = dt.Copy();
            cbtocity.DisplayMember = "CityName";
            cbtocity.ValueMember = "CityCode";
            cbtocity.SelectedIndex = 0;

            sql = "select * from CabinType";
            dt = SqlHelper.ExecuteDatatable(sql, null);
            cbCabin.DataSource = dt;
            cbCabin.DisplayMember = "CabinTypeName";
            cbCabin.ValueMember = "CabinTypeId";
            cbCabin.SelectedIndex = 0;
        }
    }
}
