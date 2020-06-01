using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Global
{
    class GlobalVariable
    {
        private static int foodcount = 0;
        private static int foodamount = 0;
        private static double foodprice = 0f;

        public static int Foodcount
        {
            get
            {
                return foodcount;
            }

            set
            {
                foodcount = value;
            }
        }

        public static int Foodamount
        {
            get
            {
                return foodamount;
            }

            set
            {
                foodamount = value;
            }
        }

        public static double Foodprice
        {
            get
            {
                return foodprice;
            }

            set
            {
                foodprice = value;
            }
        }
    }
}
