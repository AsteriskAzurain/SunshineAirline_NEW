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
    public partial class admin_ticketsalesdetail : Form
    {
        string sql;
        DataTable dt = new DataTable();
        
        int scheduleId;
        int aircraftid, cabintypeid;
        int seatamount;

        public admin_ticketsalesdetail()
        {
            InitializeComponent();
        }

        public admin_ticketsalesdetail(int scheduleid)
        {
            InitializeComponent();

            scheduleId = scheduleId;
        }

        private void ticketlabel2_Load(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void admin_ticketsalesdetail_Load(object sender, EventArgs e)
        {
            sql = @"select distinct AircraftId, CabinTypeId 
                    from FlightReservation
                    join Schedule on Schedule.ScheduleId = FlightReservation.ScheduleId
                    where FlightReservation.ScheduleId ="+scheduleId;
            dt = SqlHelper.ExecuteDataTable(sql, null);
            aircraftid = Convert.ToInt32(dt.Rows[0]["AircraftId"]);
            cabintypeid = Convert.ToInt32(dt.Rows[0]["CabinTypeId"]);
            sql = @"select COUNT(*) 
                    FROM[Session1].[dbo].[SeatLayout]
                    where AircraftId = {0} and CabinTypeId = {1}";
            sql = string.Format(sql, aircraftid, cabintypeid);
            seatamount = Convert.ToInt32(SqlHelper.ExecuteScalar(sql, null));

        }
    }
}
