using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Usercontrol
{
    class FlightInfo
    {
        private int scheduleId;
        private DateTime date;
        private TimeSpan time;
        private int aircraftId;
        private int routeId;
        private double ePrice;
        private int flightNum;
        private string gate;
        private string status;

        private int first;
        private int business;
        private int economy;
        private string depcity;
        private string depap;
        private string arrcity;
        private string arrap;

        private DateTime deptime;
        private DateTime arrtime;
        private TimeSpan totaltime;
        private double bPrice;
        private double hPrice;

        private DateTime acttime;

        public int ScheduleId
        {
            get
            {
                return scheduleId;
            }

            set
            {
                scheduleId = value;
            }
        }

        public DateTime Date
        {
            get
            {
                return date;
            }

            set
            {
                date = value;
            }
        }

        public TimeSpan Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }

        public int AircraftId
        {
            get
            {
                return aircraftId;
            }

            set
            {
                aircraftId = value;
            }
        }

        public int RouteId
        {
            get
            {
                return routeId;
            }

            set
            {
                routeId = value;
            }
        }

        public double EPrice
        {
            get
            {
                return ePrice;
            }

            set
            {
                ePrice = value;
            }
        }

        public int FlightNum
        {
            get
            {
                return flightNum;
            }

            set
            {
                flightNum = value;
            }
        }

        public string Gate
        {
            get
            {
                return gate;
            }

            set
            {
                gate = value;
            }
        }

        public string Status
        {
            get
            {
                return status;
            }

            set
            {
                status = value;
            }
        }

        public int First
        {
            get
            {
                return first;
            }

            set
            {
                first = value;
            }
        }

        public int Business
        {
            get
            {
                return business;
            }

            set
            {
                business = value;
            }
        }

        public int Economy
        {
            get
            {
                return economy;
            }

            set
            {
                economy = value;
            }
        }

        public string Depcity
        {
            get
            {
                return depcity;
            }

            set
            {
                depcity = value;
            }
        }

        public string Depap
        {
            get
            {
                return depap;
            }

            set
            {
                depap = value;
            }
        }

        public string Arrcity
        {
            get
            {
                return arrcity;
            }

            set
            {
                arrcity = value;
            }
        }

        public string Arrap
        {
            get
            {
                return arrap;
            }

            set
            {
                arrap = value;
            }
        }

        public DateTime Deptime
        {
            get
            {
                return deptime;
            }

            set
            {
                deptime = date.Add(time);
            }
        }

        public DateTime Arrtime
        {
            get
            {
                return arrtime;
            }

            set
            {
                arrtime = value;
            }
        }

        public TimeSpan Totaltime
        {
            get
            {
                return totaltime;
            }

            set
            {
                totaltime = value;
            }
        }

        public double BPrice
        {
            get
            {
                return bPrice;
            }

            set
            {
                bPrice = ePrice*1.25;
            }
        }

        public double HPrice
        {
            get
            {
                return hPrice;
            }

            set
            {
                hPrice = bPrice*1.25;
            }
        }

        public DateTime Acttime
        {
            get
            {
                return acttime;
            }

            set
            {
                acttime = value;
            }
        }
    }
}
