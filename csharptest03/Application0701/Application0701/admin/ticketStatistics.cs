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
    public partial class ticketStatistics : Form
    {
        DataTable dt = new DataTable();
        public ticketStatistics()
        {
            InitializeComponent();
        }

        private void ticketStatistics_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
            dateTimePicker1.MaxDate = DateTime.Today;
            comboBox1.SelectedIndex = 0;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dateTimePicker2.MinDate = dateTimePicker1.Value;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime date1 = dateTimePicker1.Value;
            DateTime date2 = dateTimePicker2.Value;
            string sql = @"select FORMAT(Date,'yyyy-MM') Month, COUNT(distinct f.ScheduleId) as 'FlightsAmount', COUNT(ReservationId) as 'TicketsAmount', SUM(Payment) as 'TicketsRevenue'
                    from FlightReservation as f
                    left join Schedule as s on s.ScheduleId=f.ScheduleId
                    group by FORMAT(Date,'yyyy-MM') having FORMAT(Date,'yyyy-MM') between '{0}' and '{1}'
                    order by Month";
            sql = string.Format(sql, date1.ToString("yyyy-MM"), date2.ToString("yyyy-MM"));
            dt = SqlHelper.ExecuteDatatable(sql, null);
            dataGridView1.DataSource = dt;
            dataGridView1.Refresh();

            updatechart(dt, comboBox1.Text);
        }

        public void updatechart(DataTable ds, string viewtype)
        {
            List<string> X = new List<string>();
            List<string> Y = new List<string>();

            if (ds != null)
            {
                foreach (DataRow row in ds.Rows)
                {
                    X.Add(row["Month"].ToString());
                    Y.Add(row[viewtype].ToString());
                }
                chart1.Series[0].Points.DataBindXY(X, Y);
                chart1.ChartAreas["ChartArea1"].AxisX.Title = "Month";
                chart1.ChartAreas["ChartArea1"].AxisY.Title = viewtype;
                chart1.Series[0].LegendText = viewtype;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dt != null) updatechart(dt, comboBox1.Text);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) chart1.Series[0].IsValueShownAsLabel = true;
            else chart1.Series[0].IsValueShownAsLabel = false;
        }
    }
}
