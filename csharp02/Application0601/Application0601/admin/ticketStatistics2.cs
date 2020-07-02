using Application0601.global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0601.admin
{
    public partial class ticketStatistics2 : Form
    {

        string sql;
        DataTable dt = new DataTable();

        public ticketStatistics2()
        {
            InitializeComponent();

            cbview.SelectedIndex = 0;
        }

        private void btnstics_Click(object sender, EventArgs e)
        {
            string viewtype = cbview.Text;
            DateTime datestart = dtpstart.Value;
            DateTime dateend = dtpend.Value;

            sql = @"select FORMAT(Date,'yyyy-MM') Month, COUNT(distinct f.ScheduleId) as 'FlightsAmount', COUNT(ReservationId) as 'TicketsAmount', SUM(Payment) as 'TicketsRevenue'
                    from FlightReservation as f
                    left join Schedule as s on s.ScheduleId=f.ScheduleId 
					where s.Status='Confirmed'
                    group by FORMAT(Date,'yyyy-MM') having FORMAT(Date,'yyyy-MM') between '{0}' and '{1}'
                    order by Month ";
            sql = string.Format(sql, datestart.ToString("yyyy-MM"), dateend.ToString("yyyy-MM"));
            dt = SQLhelper.ExecuteDatatable(sql, null);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            loadchart(dt, viewtype);
        }

        public void loadchart(DataTable datatable, string viewtype) {
            List<string> X = new List<string>();
            List<string> Y = new List<string>();

            if (dt != null && !viewtype.Equals(null)) {
                foreach (DataRow row in dt.Rows) {
                    X.Add(row["Month"].ToString());
                    Y.Add(row[viewtype].ToString());
                }
                Console.WriteLine("X: "+X.ToString());
                Console.WriteLine("Y: "+Y.ToString());

                chart1.Series[0].Points.DataBindXY(X, Y);
                chart1.ChartAreas[0].AxisX.Title = "Month";
                chart1.ChartAreas[0].AxisY.Title = viewtype;
                chart1.Series[0].LegendText = viewtype;
            }
        }

        private void cbshow_CheckedChanged(object sender, EventArgs e)
        {
            if (cbshow.Checked) chart1.Series[0].IsValueShownAsLabel = true;
            else chart1.Series[0].IsValueShownAsLabel = false;
        }

        private void cbview_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadchart(dt, cbview.Text);
        }
    }
}
