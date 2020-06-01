using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Usercontrol;

namespace WindowsFormsApplication1
{
    public partial class admin_flightScheduleManagement : Form
    {
        string sql;
        DataTable dt = new DataTable();
        DataTable dtct = new DataTable();
        DataTable dtap = new DataTable();
        DataTable dtflt = new DataTable();
        DataTable ds = new DataTable();
        string DEPplace, ARRplace;
        DateTime DEPdate1, DEPdate2;
        List<int> ridarr = new List<int>();
        string ridstr;

        private void admin_flightScheduleManagement_Load(object sender, EventArgs e)
        {
            sql = "select * from City order by CityName";
            dtct = SqlHelper.ExecuteDataTable(sql, null);
            sql = "select * from Airport order by IATACode";
            dtap = SqlHelper.ExecuteDataTable(sql, null);
            rdoap.Checked = true;

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

        private void datedep1_ValueChanged(object sender, EventArgs e)
        {
            datedep2.MinDate = datedep1.Value;
        }

        private void rdoap_CheckedChanged(object sender, EventArgs e)
        {
            cbdepct.DataSource = dtap;
            cbdepct.DisplayMember = "IATACode";
            cbdepct.ValueMember = "IATACode";
            cbarrct.DataSource = dtap.Copy();
            cbarrct.DisplayMember = "IATACode";
            cbarrct.ValueMember = "IATACode";
        }

        private void rdoct_CheckedChanged(object sender, EventArgs e)
        {
            cbdepct.DataSource = dtct;
            cbdepct.DisplayMember = "CityName";
            cbdepct.ValueMember = "CityCode";
            cbarrct.DataSource = dtct.Copy();
            cbarrct.DisplayMember = "CityName";
            cbarrct.ValueMember = "CityCode";
        }

        public admin_flightScheduleManagement()
        {
            InitializeComponent();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            //dtflt.Clear();
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
            //dataGridView1 = new DataGridView();
            ds.Rows.Clear();
            dataGridView1.DataSource = ds;
            dataGridView1.Refresh();

            DEPdate1 = datedep1.Value;
            DEPdate2 = datedep2.Value;
            //DEPplace = cbdepct.SelectedValue.ToString();
            //ARRplace = cbarrct.SelectedValue.ToString();

            if (rdoap.Checked)
            {
                sql = string.Format("select RouteID from Route where DepartureAirportIATA='{0}' and ArrivalAirportIATA='{1}'", DEPplace, ARRplace);
            }
            else {
                sql = @"select RouteId from Route 
                        where DepartureAirportIATA in(select IATACode from Airport where CityCode='{0}')
                        and ArrivalAirportIATA in(select IATACode from Airport where CityCode ='{1}')";
                sql = string.Format(sql, DEPplace, ARRplace);
            }
            dtflt = SqlHelper.ExecuteDataTable(sql, null);

            ridarr.Clear();
            foreach (DataRow row in dtflt.Rows) {
                ridarr.Add(Convert.ToInt32(row["RouteId"]));
            }
            if (ridarr.Count == 0) return;

            ridstr = "";
            foreach (int rid in ridarr) {
                ridstr += (" s.RouteId ="+rid + " or");
            }
            ridstr = ridstr.TrimEnd("or".ToCharArray());

            getsid();

            getdatasource();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (dataGridView1.Columns[e.ColumnIndex].HeaderText == "Detail") {
                MessageBox.Show(dtflt.Rows[index]["ScheduleId"] + " / " + dtflt.Rows[index]["Gate"]);
                //todo: formdetail
                admin_ticketsalesdetail frmtsd = new admin_ticketsalesdetail(Convert.ToInt32(dtflt.Rows[index]["ScheduleId"]));
                frmtsd.Show();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string status = dataGridView1.CurrentRow.Cells["Status"].Value.ToString();
            if (status.Equals("Confirmed"))
            {
                status = "Canceled";
            }
            else
            {
                status = "Confirmed";
            }
            sql = string.Format("update Schedule set Status = '{0}' where ScheduleId = {1}", status, dtflt.Rows[dataGridView1.CurrentCell.RowIndex]["ScheduleId"]);
            SqlHelper.ExecuteonQuery(sql, null);
            MessageBox.Show(status);
            btnsearch.PerformClick();
        }

        private void cbdepct_SelectedIndexChanged(object sender, EventArgs e)
        {
            DEPplace = cbdepct.SelectedValue.ToString();
        }

        private void cbarrct_SelectedIndexChanged(object sender, EventArgs e)
        {
            ARRplace = cbarrct.SelectedValue.ToString();
        }

        private void btnex_Click(object sender, EventArgs e)
        {
            if (dataGridView1 == null) return;
            DEPplace = cbarrct.SelectedValue.ToString();
            ARRplace = cbdepct.SelectedValue.ToString();
            btnsearch.PerformClick();
        }

        private void getsid() {
            //测试条件
            DEPdate1 = Convert.ToDateTime("2019/9/19");
            DEPdate2 = Convert.ToDateTime("2019/9/23");

            sql = @"select s.ScheduleId,s.RouteId, Date,Time,DepartureAirportIATA,c1.CityName as depcity,ArrivalAirportIATA,c2.CityName as arrcity,Name,EconomyPrice,FlightNumber,Gate,Status
                    from Schedule as s
                    join Aircraft as a on a.AircraftId=s.AircraftId
                    join Route as r on r.RouteId=s.RouteId
                    join Airport as a1 on a1.IATACode=r.DepartureAirportIATA join city as c1 on c1.CityCode=a1.CityCode
                    join Airport as a2 on a2.IATACode=r.ArrivalAirportIATA join City as c2 on c2.CityCode=a2.CityCode
                    where Date between '{0}' and '{1}'
                    and ({2}) 
                    order by date,FlightTime";
            sql = string.Format(sql, DEPdate1.ToString("d"), DEPdate2.ToString("d"), ridstr);
            dtflt = SqlHelper.ExecuteDataTable(sql, null);
            lblts.Text = dtflt.Rows.Count.ToString();
            //dataGridView1.DataSource = dt;
            //dataGridView1.Refresh();
        }

        private void getdatasource() {

            ds.Clear();

            foreach (DataRow row in dtflt.Rows) {
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

            DataGridViewLinkColumn dlink = new DataGridViewLinkColumn();  //创建link列
            dlink.HeaderText = "Detail";
            dlink.Text = "Detail";
            dlink.Name = "detail";
            dlink.UseColumnTextForLinkValue = true;
           
            dataGridView1.DataSource = ds;
            if (!dataGridView1.Columns.Contains("detail")) {
                dataGridView1.Columns.Add(dlink); //将link列添加到datagridview
            }
            dataGridView1.Refresh();
        }
    }
}
