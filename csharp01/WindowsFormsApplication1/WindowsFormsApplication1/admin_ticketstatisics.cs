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
    public partial class admin_ticketstatisics : Form
    {
        string sql;
        DataTable dt = new DataTable();
        DataTable dtstat = new DataTable();
        public admin_ticketstatisics()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 0;
            //chart1.Legends[0].Position = new System.Windows.Forms.DataVisualization.Charting.ElementPosition(0, 0, 100, 100);
        }

        private void btnstat_Click(object sender, EventArgs e)
        {
            string viewtype = comboBox1.Text;
            DateTime m1 = dateTimePicker1.Value;
            DateTime m2 = dateTimePicker2.Value;
            sql = @"select FORMAT(Date,'yyyy-MM') Month, COUNT(distinct f.ScheduleId) as 'FlightsAmount', COUNT(ReservationId) as 'TicketsAmount', SUM(Payment) as 'TicketsRevenue'
                    from FlightReservation as f
                    left join Schedule as s on s.ScheduleId=f.ScheduleId
                    group by FORMAT(Date,'yyyy-MM') having FORMAT(Date,'yyyy-MM') between '{0}' and '{1}'
                    order by Month";
            sql = string.Format(sql, m1.ToString("yyyy-MM"), m2.ToString("yyyy-MM"));
            dt = SqlHelper.ExecuteDataTable(sql, null);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            chartupdate(dt,viewtype);
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void chartupdate(DataTable source, string viewtype) {
            //添加坐标点
            List<string> X = new List<string>();
            List<string> Y = new List<string>();

            if (dt != null) {
                foreach (DataRow row in dt.Rows) {
                    X.Add(row["Month"].ToString());
                    Y.Add(row[viewtype].ToString());
                }
                chart1.Series[0].Points.DataBindXY(X, Y);
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Month";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = viewtype;
                chart1.Series[0].LegendText = viewtype;
            }
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            chartupdate(dt, comboBox1.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            chartupdate(dt, comboBox1.Text);
        }

        private void ckamt_CheckedChanged(object sender, EventArgs e)
        {
            if (ckamt.Checked) chart1.Series[0].IsValueShownAsLabel = true;
            else chart1.Series[0].IsValueShownAsLabel = false;
        }
    }
}
