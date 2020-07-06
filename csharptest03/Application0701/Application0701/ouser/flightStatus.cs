using Application0701.global;
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

namespace Application0701.ouser
{
    public partial class flightStatus : Form
    {
        public flightStatus()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flightStatus_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
            this.reportViewer1.RefreshReport();
            //this.reportViewer1.LocalReport.ReportPath = "Report1.rdlc";
            //DataTable dt = new DataTable();
            //ReportDataSource rdsitem = new ReportDataSource("DataSet1", dt);
            //this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date = this.dateTimePicker1.Value;
            string sql = @"select FlightNumber, c1.CityName+'/'+DepartureAirportIATA as 'From', c2.CityName+'/'+ArrivalAirportIATA as 'To',Time as 'ScheduleStart', DATEADD(minute,FlightTime,Time) as 'ScheduleArrival', ActualArrivalTime as 'ActualArrival', Gate, 
		                        DATEDIFF(mi,DATEADD(minute,FlightTime,Time),CONVERT(time(7),ActualArrivalTime,108)) as timediff
                        from FlightStatus fs
	                        join Schedule s on s.ScheduleId=fs.ScheduleId
	                        join Route r on r.RouteId=s.RouteId
	                        join Airport a1 on a1.IATACode=DepartureAirportIATA join City c1 on c1.CityCode=a1.CityCode
	                        join Airport a2 on a2.IATACode=ArrivalAirportIATA join City c2 on c2.CityCode=a2.CityCode
                        where Date='{0}'";
            sql = string.Format(sql, date.ToShortDateString());
            DataTable dt = SqlHelper.ExecuteDatatable(sql,null);
            
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Application0701.Report2.rdlc";
            this.reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", dt));
            this.reportViewer1.RefreshReport();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
