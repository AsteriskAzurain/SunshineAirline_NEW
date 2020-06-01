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
using System.Xml.Serialization;
using WindowsFormsApplication1.Usercontrol;

namespace WindowsFormsApplication1
{
    public partial class frmlogin : Form
    {
        int verify_count = 0;
        Timer timerautologin ;
        string code;
        

        public frmlogin()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (grpverify.Visible == true) {
                string vcode = tbverify.Text;
                if (vcode.ToLower() != code.ToLower()) {
                    MessageBox.Show("CAPTCHA ERROR");
                    tbemail.Text = "";
                    tbpswd.Text = "";
                    tbverify.Text = "";
                }
            }
            string email = tbemail.Text;
            string pswd = tbpswd.Text;
            string sql = string.Format("select RoleId from Users where Email='{0}' and Password='{1}'", email, pswd);
            object role = SqlHelper.ExecuteScalar(sql, null);
            if (role !=null)
            {
                //验证通过        
                if ((int)role == 1)
                {
                    //office user
                    OfficeUserMenu frmouser = new OfficeUserMenu();
                    this.Hide();
                    frmouser.Show();
                }
                else {
                    //admin
                    AdministratorMenu frmadmin = new AdministratorMenu();
                    this.Hide();
                    frmadmin.Show();
                }
                if (ckbautologin.Checked) {
                    FileStream fs = new FileStream("autoLogin.xml", FileMode.Create);
                    //filemode.create:if file already exists, it will be overwritten.
                    XmlSerializer xs = new XmlSerializer(typeof(OfficeUser));
                    OfficeUser user = new OfficeUser();
                    user.Email = email;
                    user.Password = pswd;
                    user.Lastdate = DateTime.Now.ToString();
                    xs.Serialize(fs, user);
                    fs.Close();

                }
            }
            else {
                tbemail.Text = "";
                tbpswd.Text = "";
                tbverify.Text = "";
                verify_count++;
                VerifyUpdate();
                string msg = "Validation failed.";
                if (verify_count > 2)
                {
                    grpverify.Visible = true;
                    msg += "please enter the validation code and try again.";
                }
                MessageBox.Show(msg);
            }
            


        }

        private void btnlogclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmlogin_Load(object sender, EventArgs e)
        {
            VerifyUpdate();

            timerautologin = new Timer();
            timerautologin.Interval = 3000;

            FileStream fs = new FileStream("autoLogin.xml", FileMode.OpenOrCreate);
            //open a file if it exists
            //otherwise, a new file will be created
            if (fs.Length > 0) {
                //反序列化
                XmlSerializer xs = new XmlSerializer(typeof(OfficeUser));
                OfficeUser lastuser = xs.Deserialize(fs) as OfficeUser;
                DateTime lastdate = Convert.ToDateTime(lastuser.Lastdate);
                TimeSpan ts = DateTime.Now - lastdate;
                if (ts.Days <= 7) {
                    tbemail.Text = lastuser.Email;
                    tbpswd.Text = lastuser.Password;
                    grpalt.Visible = true;
                    timerautologin.Tick += new EventHandler(timerautologin_Tick);
                    timerautologin.Start();
                    
                }
            }
            fs.Close();
        }

        private void btnalt_Click(object sender, EventArgs e)
        {
            timerautologin.Stop();
            grpalt.Visible = false;
            tbemail.Text = "";
            tbpswd.Text = "";
        }

        void timerautologin_Tick(object sender, EventArgs e) {
            timerautologin.Stop();
            btnlogin.PerformClick();//使用代码调用控件的点击事件
            this.Hide();
        }
        void VerifyUpdate()
        {
            Random r = new Random();
            string codes = "1234567890abcdefghijklmnopqostuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            Bitmap bmp = new Bitmap(90,40); //画布 用于储存图像
            Graphics g = Graphics.FromImage(bmp); //工具 用于绘制图像

            code = "";
            for (int i = 0; i < 4; i++) {
                code += codes[r.Next(0, codes.Length - 1)]; //随机得到四个字符
                Point p = new Point(i * 20, 0); //设置每个字符的起始坐标
                Font f = new Font("Arial", 20, FontStyle.Bold);
                SolidBrush b = new SolidBrush(Color.Black);
                g.DrawString(code[i].ToString(), f, b, p); //绘制当前字符
            }

            verifycode.Image = bmp;

        }

        private void verifycode_Click(object sender, EventArgs e)
        {
            VerifyUpdate();
        }
    }
}
