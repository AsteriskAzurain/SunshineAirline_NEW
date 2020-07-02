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

namespace Application0701.admin
{
    public partial class flightScheduleManagement : Form
    {
        string sql;
        DataTable dt = new DataTable();
        DataTable dtct = new DataTable();
        DataTable dtap = new DataTable();
        string depplace, arrplace;

        public flightScheduleManagement()
        {
            InitializeComponent();

            dateTimePicker1.MinDate = DateTime.Now;
            dateTimePicker2.MinDate = DateTime.Now;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            cbfrom.DataSource = dtap;
            cbfrom.DisplayMember = "IATACode";
            cbfrom.ValueMember = "IATACode";
            cbfrom.SelectedIndex = 0;

            cbto.DataSource = dtap.Copy();
            cbto.DisplayMember = "IATACode";
            cbto.ValueMember = "IATACode";
            cbto.SelectedIndex = 0;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            cbfrom.DataSource = dtct;
            cbfrom.DisplayMember = "CityName";
            cbfrom.ValueMember = "IATACode";
            cbfrom.SelectedIndex = 0;

            cbto.DataSource = dtct.Copy();
            cbto.DisplayMember = "CityName";
            cbto.ValueMember = "IATACode";
            cbto.SelectedIndex = 0;
        }

        private void flightScheduleManagement_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
            sql = "select * from City order by CityName";
            dtct = SqlHelper.ExecuteDatatable(sql, null);
            sql = "select * from Airport order by IATACode";
            dtap = SqlHelper.ExecuteDatatable(sql, null);
        }
    }
}
