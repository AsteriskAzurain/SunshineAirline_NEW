using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Global;
using WindowsFormsApplication1.Usercontrol;

namespace WindowsFormsApplication1
{
    public partial class ouser_foodService : Form
    {
        string sql;
        DataTable dtfood = new DataTable();
        DataTable dtflight = new DataTable();
        DataTable dttemp = new DataTable();

        int fcount,fline,findex;
        byte[] picbyte;
        string utype, uid,udate,utime;
        List<string> fidarr = new List<string>();

        List<CheckBox> listck ;
        List<food> listfood ;

        public static ouser_foodService mainFrm;
        public static void labelchange() {
            mainFrm.lblNum.Text = GlobalVariable.Foodcount.ToString();
            mainFrm.lblAmt.Text = GlobalVariable.Foodamount.ToString();
            mainFrm.lblPay.Text = "$ " + GlobalVariable.Foodprice.ToString("f2");
        }

        private void cbFLT_SelectionChangeCommitted(object sender, EventArgs e)
        {
                        
        }

        public ouser_foodService()
        {
            mainFrm = this;
            InitializeComponent();

            sql = "select * from FlightFood";
            dtfood = SqlHelper.ExecuteDataTable(sql, null);
            fcount = dtfood.Rows.Count;
            fline = fcount % 4 == 0 ? fcount / 4 : fcount / 4 + 1;

            cbIDtp.SelectedIndex = 0;

        }

        private void btnCL_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Confirm Cancel?", "Confirm Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                GlobalVariable.Foodcount = 0;
                GlobalVariable.Foodamount = 0;
                GlobalVariable.Foodprice = 0f;
                this.Close();
            }
        }

        private void btnCfm_Click(object sender, EventArgs e)
        {
            if (uid == null) return;
            sql = "IDTypeNumber=" + uid + " and IDType='" + utype+"'";
            DataRow[] rowarr = dtflight.Select(sql);
            DataRow row = rowarr[0];
            if (Convert.ToDateTime(row["Date"]).Equals(DateTime.Today))
            {
                if (Convert.ToDateTime(row["Time"].ToString()).Subtract(DateTime.Now).TotalHours < 6f)
                {
                    MessageBox.Show("Departure time is less than six hours. Submission failed");
                    return;
                }
            }
            //DateTime d1 = Convert.ToDateTime("11/4/2019 10:00:00 AM");
            //DateTime d2 = Convert.ToDateTime(row["Time"].ToString());
            //TimeSpan ts = d1.Subtract(d2);
            //double h = ts.TotalHours;
            //if (Convert.ToDateTime(row["Date"]).Equals(Convert.ToDateTime("11/4/2019 12:00:00 AM")))
            //{
            //    if (Convert.ToDateTime("11/4/2019 10:00:00 AM").Subtract(Convert.ToDateTime(row["Time"].ToString())).TotalHours < 6f)
            //    {
            //        MessageBox.Show("Departure time is less than six hours. Submission failed");
            //        return;
            //    }
            //}

            //MessageBox.Show("ck:" + listck.Count + " food:" + listfood.Count);
            for (int index = 0; index < listck.Count; index++) {
                if (listck[index].Checked) {
                    int reservationid = Convert.ToInt32(dtflight.Rows[cbFLT.SelectedIndex]["ReservationId"]); 
                    int foodid = Convert.ToInt32(dtfood.Rows[index]["FoodId"]);
                    int amount=listfood[index].FoodNum;
                    //MessageBox.Show("reservationid:" + reservationid + ", foodid" + foodid + ", amount" + amount);
                    string sql_select =string.Format("select count(*) from FlightFoodReservation where ReservationId={0} and FoodId={1}", reservationid, foodid);
                    int n = (int)SqlHelper.ExecuteScalar(sql_select, null);
                    if (n == 0)
                    {
                        string sql_add = string.Format("insert into FlightFoodReservation values({0}, {1}, {2})", reservationid, foodid, amount);
                        SqlHelper.ExecuteonQuery(sql_add, null);
                    }
                    else {
                        string sql_mod = string.Format("update FlightFoodReservation set Amount ={0} where ReservationId = {1} and FoodId = {2}", amount, reservationid, foodid);
                        SqlHelper.ExecuteonQuery(sql_mod, null);
                    }
                }
            }
            MessageBox.Show("Submit Succeed.");
            btnLoad.PerformClick();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (dtflight.Rows.Count==0) return;

            panel3.Controls.Clear();
            fidarr.Clear();
            GlobalVariable.Foodcount = 0; 
            GlobalVariable.Foodamount = 0;
            GlobalVariable.Foodprice = 0f;
            labelchange();
            listck = new List<CheckBox>();
            listfood = new List<food>();

            int rid = Convert.ToInt32(dtflight.Rows[cbFLT.SelectedIndex]["ReservationId"]);
            sql = string.Format("select * from FlightFoodReservation where ReservationId='{0}'", rid);
            dttemp = SqlHelper.ExecuteDataTable(sql, null);
            if (dttemp.Rows.Count == 0) fidarr.Add("");
            else {
                foreach (DataRow row in dttemp.Rows) {
                    fidarr.Add(row["FoodId"].ToString());
                }
            }
            findex = 0;
            for (int y = 0; y < fline; y++)
            {
                for (int x = 0; x < 4; x++)
                {
                    CheckBox ck = new CheckBox();
                    ck.Text = "";
                    ck.Location = new Point(40 + 220 * x, 50 + 170 * y);
                    food food = new food();
                    food.Location = new Point(40 + 220 * x, 5 + 170 * y);
                    //food.BorderStyle = BorderStyle.Fixed3D;
                    //food.BringToFront();
                    ck.Size = new Size(15, 15);
                    ck.SendToBack();

                    if (findex >= fcount) break;
                    DataRow row = dtfood.Rows[findex];
                    food.FoodName = row["Name"].ToString();
                    food.FoodPrice = Convert.ToDouble(row["Price"]);
                    food.FoodPic = row["Img"].ToString();

                    //picbyte = (byte[])row["Photo"];
                    //MemoryStream ms = new MemoryStream(picbyte, true);
                    //ms.Write(picbyte, 0, picbyte.Length);
                    //food.FoodPic = new Bitmap(ms);
                    //ms.Close();

                    ck.Checked = false;
                    food.FoodNum = 0;
                    ck.CheckedChanged += new EventHandler(foodCheckedChanged);

                    if (fidarr.Contains(row["FoodId"].ToString())) {
                        ck.Checked = true;
                        DataRow[] rowarr = dttemp.Select("FoodId =" + row["FoodId"].ToString());
                        if(rowarr.Length>0)food.FoodNum = Convert.ToInt32(rowarr[0]["Amount"]);
                        //GlobalVariable.Foodcount++;
                        //GlobalVariable.Foodamount += Convert.ToInt32(rowarr[0]["Amount"]);
                        //GlobalVariable.Foodprice += (food.FoodPrice * Convert.ToInt32(rowarr[0]["Amount"]));
                    }

                    findex++;
                    listck.Add(ck);
                    listfood.Add(food);

                    panel3.Controls.Add(ck);
                    panel3.Controls.Add(food);
                }
            }
            //lblNum.Text= GlobalVariable.Foodcount.ToString();
            //lblAmt.Text = GlobalVariable.Foodamount.ToString();
            //lblPay.Text = "$ "+GlobalVariable.Foodprice.ToString("f2");
        }

        private void foodCheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).CheckState.ToString() == "Checked")
            {
                GlobalVariable.Foodcount++;
                lblNum.Text = GlobalVariable.Foodcount.ToString();
            }
            else {
                GlobalVariable.Foodcount--;
                lblNum.Text = GlobalVariable.Foodcount.ToString();
            }
            
            //throw new NotImplementedException();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cbFLT.Items.Clear();

            utype = cbIDtp.Text;
            uid = tbIDn.Text;
            udate = DateTime.Now.Date.ToString("d");
            utime = DateTime.Now.AddHours(6).ToString("t");

            //测试数据
            uid = "34135204";
            utype = "Passport";
            udate = "11/1/2019";
            utime = "8:00 AM";            

            sql = @"select IDTypeNumber, FlightNumber,DepartureAirportIATA,ArrivalAirportIATA,Date,Time,SeatLayoutId,ReservationId,IDType
                    FROM FlightReservation as f
                         join Schedule as s on f.ScheduleId=s.ScheduleId 
                         join Route as r on r.RouteId= s.RouteId
                    where IDTypeNumber='{0}' and IDType='{1}'
		                and (Date > '{2}' or(Date='{3}' and Time >'{4}'))";
            sql = string.Format(sql, uid, utype, udate, udate, utime);
            dtflight = SqlHelper.ExecuteDataTable(sql, null);

            foreach (DataRow row in dtflight.Rows) {
                int c = row["SeatLayoutId"]==DBNull.Value?0:Convert.ToInt32(row["SeatLayoutId"]);
                string cabintype = "";
                if ((1 <= c && c <= 8) || (189 <= c && c <= 200)) cabintype = "First";
                else if ((9 <= c && c <= 68) || (201 <= c && c <= 260)) cabintype = "Business";
                else cabintype = "Economy";

                string item = row["FlightNumber"].ToString() + ", "
                    + row["DepartureAirportIATA"].ToString() + " - "
                    + row["ArrivalAirportIATA"].ToString() + ", "
                    + Convert.ToDateTime(row["Date"]).ToString("yyyy-MM-dd") + ", "
                    + TimeSpan.Parse(row["Time"].ToString()).ToString(@"hh\:mm") + ", "
                    + cabintype;

                cbFLT.Items.Add(item);
            }
            if(cbFLT.Items.Count>0)cbFLT.SelectedIndex = 0;

            //访问航班的ReservationId
            //MessageBox.Show(dtflight.Rows[cbFLT.SelectedIndex]["ReservationId"].ToString());

        }

        private void ouser_foodService_Load(object sender, EventArgs e)
        {
            
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
