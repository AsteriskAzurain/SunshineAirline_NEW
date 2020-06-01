using Microsoft.Reporting.WinForms;
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
    public partial class ouser_flightStatus : Form
    {
        List<FlightInfo> list = new List<FlightInfo>();
        string sql;
        DataTable dt = new DataTable();
        DataTable dt1 = new DataTable();

        public ouser_flightStatus()
        {
            InitializeComponent();

            dateDEP.MaxDate = DateTime.Today;

            dt1.Columns.Add("No");
            dt1.Columns.Add("FlightNumber");
            dt1.Columns.Add("From");
            dt1.Columns.Add("To");
            dt1.Columns.Add("ScheduleStart");
            dt1.Columns.Add("ScheduleArrival");
            dt1.Columns.Add("ActualArrival");
            dt1.Columns.Add("Gate");
            dt1.Columns.Add("Status");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dt1.Clear();
            sql = @"select s.ScheduleId, FlightNumber, c1.CityName as depct,DepartureAirportIATA, c2.CityName as arrct,ArrivalAirportIATA, Date,Time,ActualArrivalTime,Gate,FlightTime
                    from FlightStatus f
                    join Schedule s on s.ScheduleId = f.ScheduleId
                    join Route r on s.RouteId = r.RouteId
                    join Airport a1 on DepartureAirportIATA = a1.IATACode join City c1 on a1.CityCode = c1.CityCode
                    join Airport a2 on ArrivalAirportIATA = a2.IATACode join City c2 on a2.CityCode = c2.CityCode
                    where Date < '{0}'
                    order by Date, FlightNumber";
            sql = string.Format(sql, dateDEP.Text);
            dt = SqlHelper.ExecuteDataTable(sql, null);
            //MessageBox.Show(dt.Rows.Count.ToString());
            int index;
            for (index = 0; index < dt.Rows.Count; index++) {
                DataRow dr = dt1.NewRow();
                //dr["No"] = dt.Rows[index]["ScheduleId"];
                dr["No"] = index+1;
                dr["FlightNumber"] = dt.Rows[index]["FlightNumber"];
                dr["From"] = dt.Rows[index]["depct"]+" / " + dt.Rows[index]["DepartureAirportIATA"];
                dr["To"] = dt.Rows[index]["arrct"] +" / "+ dt.Rows[index]["ArrivalAirportIATA"];
                dr["ScheduleStart"] = Convert.ToDateTime(dt.Rows[index]["Date"]).Add(TimeSpan.Parse(dt.Rows[index]["Time"].ToString())).TimeOfDay;
                int m = (dt.Rows[index]["FlightTime"] == DBNull.Value) ? 0 : Convert.ToInt32(dt.Rows[index]["FlightTime"]);
                dr["ScheduleArrival"] = Convert.ToDateTime(dr["ScheduleStart"]).Add(TimeSpan.FromMinutes(m)).TimeOfDay;
                dr["ActualArrival"] = Convert.ToDateTime(dt.Rows[index]["ActualArrivalTime"]).TimeOfDay;
                dr["Gate"] = dt.Rows[index]["Gate"];
                double ts = Convert.ToDateTime(dr["ScheduleArrival"]).Subtract(Convert.ToDateTime(dr["ActualArrival"])).TotalMinutes;
                if (ts == 0) dr["Status"] = "On time";
                else dr["Status"] = ts>0?"early "+ts+" minutes":"delay "+Math.Abs(ts)+" minutes";
                dt1.Rows.Add(dr);
            }
            //MessageBox.Show("count:" + dt1.Rows.Count + " index:" + index);


                //BindingSource bs = new BindingSource();
                //bs.DataSource = dt;
            ReportDataSource rds = new ReportDataSource("DataSet1",dt1);
            //rds.Name = "DataSet1";
            //DataSet dset = new DataSet();
            //dset.Tables.Add(dt1);
            //rds.Value = dset.Tables[0];
            reportViewer2.LocalReport.DataSources.Clear();
            reportViewer2.LocalReport.DataSources.Add(rds);
            reportViewer2.RefreshReport();
        }

        private void ouser_flightStatus_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'testDataSet.Schedule' table. You can move, or remove it, as needed.
            this.ScheduleTableAdapter.Fill(this.testDataSet.Schedule);

            this.reportViewer2.RefreshReport();
        }
    }
}
