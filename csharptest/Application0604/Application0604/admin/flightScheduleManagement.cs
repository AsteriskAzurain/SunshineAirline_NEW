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

namespace Application0604.admin
{
    public partial class flightScheduleManagement : Form
    {
        string sql;
        DataTable dt = new DataTable();

        DataTable dtct = new DataTable();
        DataTable dtap = new DataTable();
        string depplace, arrplace;

        DataTable ds = new DataTable();

        public flightScheduleManagement()
        {
            InitializeComponent();

            datefrom.MinDate = DateTime.Now;
            dateto.MinDate = DateTime.Now;

            ds.Columns.Add("Date");
            ds.Columns.Add("Time");
            ds.Columns.Add("From");
            ds.Columns.Add("To");
            ds.Columns.Add("Aircroft");
            ds.Columns.Add("EconomyPrice");
            ds.Columns.Add("FlightNumber");
            ds.Columns.Add("Gate");
            ds.Columns.Add("Status");
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            ds.Rows.Clear();
            dataGridView1.DataSource = ds;
            dataGridView1.Refresh();

            DateTime date1 = datefrom.Value;
            DateTime date2 = dateto.Value;

            if (rbiata.Checked)
            {
                sql = string.Format("select RouteID from Route where DepartureAirportIATA='{0}' and ArrivalAirportIATA='{1}'", depplace, arrplace);
            }
            else {
                sql = @"select RouteId from Route 
                        where DepartureAirportIATA in(select IATACode from Airport where CityCode='{0}')
                        and ArrivalAirportIATA in(select IATACode from Airport where CityCode ='{1}')";
                sql = string.Format(sql, depplace, arrplace);
            }
            dt = SqlHelper.ExecuteDatatable(sql, null);

            List<int> routeidlist = new List<int>();
            foreach (DataRow row in dt.Rows) {
                routeidlist.Add(Convert.ToInt32(row["RouteId"]));
            }
            if (routeidlist.Count == 0)
            {
                MessageBox.Show("No such flight.");
                return;
            }

            string ridstr = "";
            foreach (int rid in routeidlist)
            {
                ridstr += (" s.RouteId =" + rid + " or");
            }
            ridstr = ridstr.TrimEnd("or".ToCharArray());

            getsid(ridstr);
        }

        private void rbiata_CheckedChanged(object sender, EventArgs e)
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

        private void rbcity_CheckedChanged(object sender, EventArgs e)
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
            sql = "select * from City order by CityName";
            dtct = SqlHelper.ExecuteDatatable(sql, null);
            sql = "select * from Airport order by IATACode";
            dtap = SqlHelper.ExecuteDatatable(sql, null);

            rbiata.Checked = true;
        }

        private void cbfrom_SelectedIndexChanged(object sender, EventArgs e)
        {
            depplace = cbfrom.SelectedValue.ToString();
        }

        private void cbto_SelectedIndexChanged(object sender, EventArgs e)
        {
            arrplace = cbto.SelectedValue.ToString();
        }

        private void btntest_Click(object sender, EventArgs e)
        {
            datefrom.MinDate = Convert.ToDateTime("2018-1-1");
            dateto.MinDate = Convert.ToDateTime("2018-1-1");
        }


        private void getsid(string ridstr)
        {
            DateTime date1 = datefrom.Value;
            DateTime date2 = dateto.Value;

            sql = @"select s.ScheduleId,s.RouteId, Date,Time,DepartureAirportIATA,c1.CityName as depcity,ArrivalAirportIATA,c2.CityName as arrcity,Name,EconomyPrice,FlightNumber,Gate,Status
                    from Schedule as s
                    join Aircraft as a on a.AircraftId=s.AircraftId
                    join Route as r on r.RouteId=s.RouteId
                    join Airport as a1 on a1.IATACode=r.DepartureAirportIATA join city as c1 on c1.CityCode=a1.CityCode
                    join Airport as a2 on a2.IATACode=r.ArrivalAirportIATA join City as c2 on c2.CityCode=a2.CityCode
                    where Date between '{0}' and '{1}'
                    and ({2}) 
                    order by date,FlightTime";
            sql = string.Format(sql, date1.ToString("d"), date2.ToString("d"), ridstr);
            dt = SqlHelper.ExecuteDatatable(sql, null);
            lblnum.Text = dt.Rows.Count.ToString();

            getdatasource(dt);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            string tmpplace = depplace;
            depplace = arrplace;
            arrplace = tmpplace;
            btnsearch.PerformClick();
        }

        private void getdatasource(DataTable dtflt)
        {
            ds.Clear();
            MessageBox.Show(dtflt.Rows.Count.ToString());


            foreach (DataRow row in dtflt.Rows)
            {
                DataRow newrow = ds.NewRow();
                newrow["Date"] = Convert.ToDateTime(row["Date"]).ToString("yyyy-MM-dd");
                newrow["Time"] = TimeSpan.Parse(row["Time"].ToString()).ToString(@"hh\:mm");
                newrow["From"] = row["depcity"].ToString() + " / " + row["DepartureAirportIATA"].ToString();
                newrow["To"] = row["arrcity"].ToString() + " / " + row["ArrivalAirportIATA"].ToString();
                newrow["Aircroft"] = row["Name"];
                newrow["EconomyPrice"] = row["EconomyPrice"];
                newrow["FlightNumber"] = row["FlightNumber"];
                newrow["Gate"] = row["Gate"];
                newrow["Status"] = row["Status"];

                ds.Rows.Add(newrow);
            }
            MessageBox.Show(dt.Rows.Count.ToString());

            DataGridViewLinkColumn dlink = new DataGridViewLinkColumn();
            dlink.HeaderText = "Detail";
            dlink.Text = "Detail";
            dlink.Name = "detail";
            dlink.UseColumnTextForLinkValue = true;

            dataGridView1.DataSource = ds;
            if (!dataGridView1.Columns.Contains("detail")) {
                dataGridView1.Columns.Add(dlink);
            }
            dataGridView1.Refresh();
        }


    }
}
