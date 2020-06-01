using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Global;

namespace WindowsFormsApplication1.Usercontrol
{
    public partial class food : UserControl
    {
        private string foodName;
        private string foodPic;
        private int foodNum;
        private double foodPrice;

        public string FoodName
        {
            get
            {
                return lblFoodName.Text;
            }

            set
            {
                foodName = value;
                lblFoodName.Text = foodName;
            }
        }

        public string FoodPic
        {
            get
            {
                return picfood.ImageLocation;
                //path or url for the img to dispaly in the picbox
            }

            set
            {
                string tempdir = Application.StartupPath;
                //D:\fbw\test1\WindowsFormsApplication10117\WindowsFormsApplication1\WindowsFormsApplication1\bin\Debug
                for (int i = 0; i < 2; i++) { //获取上两级的dir
                    int tempindex = tempdir.LastIndexOf("\\"); 
                    tempdir = tempdir.Substring(0, tempindex);
                    //95 D:\fbw\test1\WindowsFormsApplication10117\WindowsFormsApplication1\WindowsFormsApplication1\bin
                    //91 D:\fbw\test1\WindowsFormsApplication10117\WindowsFormsApplication1\WindowsFormsApplication1
                }
                string dir= tempdir + "\\foodpic\\"+ value;
                //D:\fbw\test1\WindowsFormsApplication10117\WindowsFormsApplication1\WindowsFormsApplication1\foodpic\S01.jpg
                picfood.Image = Image.FromFile(dir);
            }
        }

        public int FoodNum
        {
            get
            {
                return (int)numfood.Value;
            }

            set
            {
                foodNum = value;
                numfood.Value = foodNum;
            }
        }

        public double FoodPrice
        {
            get
            {
                return Convert.ToDouble(lblPrice.Text.TrimStart('$'));
            }

            set
            {
                foodPrice = value;
                lblPrice.Text ="$ "+ foodPrice.ToString("f2");
            }
        }

        public food()
        {
            InitializeComponent();
        }

        private void numfood_ValueChanged(object sender, EventArgs e)
        {
            if (Convert.ToInt32(numfood.Text) < numfood.Value)
            {
                //old<new 增加 
                GlobalVariable.Foodamount++;
                GlobalVariable.Foodprice += foodPrice;
                ouser_foodService.labelchange();
            }
            else {
                //old>new 减少
                GlobalVariable.Foodamount--;
                GlobalVariable.Foodprice -= foodPrice;
                ouser_foodService.labelchange();
            }
            //MessageBox.Show("Text:"+numfood.Text +" Value:"+ numfood.Value);
        }
    }
}
