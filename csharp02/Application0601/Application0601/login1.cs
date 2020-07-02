using Application0601.global;
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

namespace Application0601
{
    public partial class login1 : Form
    {
        private int ver_count = 0;
        private string ver_code = "";
        private Timer timer;

        public login1()
        {
            InitializeComponent();
            // select roleid 
            // go to menu by roleid
            // login failed -> show verity
            // add verity code 
            // click the verity code to change one
            // store a user info when ckb=true
            // auto login (show grp_auto), when click "cancel": hide
        }

        private void login_Load(object sender, EventArgs e)
        {
            grp1_auto.Visible = false;
            grp1_vercode.Visible = false;

            // load stored user info
            // and auto login in 3s
            timer = new Timer();
            timer.Interval = 3000;
            FileStream fs = new FileStream("autorecord.xml", FileMode.OpenOrCreate);
            // open file when existed
            if (fs.Length > 0) {
                XmlSerializer xs = new XmlSerializer(typeof(User));
                User u = xs.Deserialize(fs) as User;
                DateTime lastdate = Convert.ToDateTime(u.Lastdate);
                TimeSpan ts = DateTime.Now - lastdate;
                if (ts.Days <= 7)
                {
                    grp1_auto.Visible = true;
                    tb1_email.Text = u.Email;
                    tb1_pswd.Text = u.Password;
                    //ckb1_login.Checked = true;
                    ckb1_login.Visible = false;
                    timer.Tick += new EventHandler(timer_Tick);
                    timer.Start();
                }
            }
            fs.Close();
           
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            timer.Stop();
            btn1_login.PerformClick(); // pretend that the btn is clicked
            //this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_clz_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn1_login_Click(object sender, EventArgs e)
        {
            if (grp1_vercode.Visible == true) {
                string code = tb1_vercode.Text;
                if (!code.ToLower().Equals(ver_code.ToLower())) {
                    MessageBox.Show("Verity Code wrong.");
                    return;
                }
            }

            string email = tb1_email.Text;
            string pswd = tb1_pswd.Text;
            string sql = string.Format("  select RoleId from Users where Email = '{0}' and Password = '{1}' ", email, pswd);
            Console.WriteLine(sql);
            object role = SQLhelper.ExecuteScalar(sql, null);
            if (role != null)
            {
                if (ckb1_login.Checked)
                {
                    FileStream fs = new FileStream("autorecord.xml", FileMode.Create);
                    // filemode==create means: if existed, overwrote
                    XmlSerializer xs = new XmlSerializer(typeof(User));
                    User u = new User();
                    u.Email = email;
                    u.Password = pswd;
                    u.Lastdate = DateTime.Now.ToString();
                    Console.WriteLine(u.Lastdate);
                    xs.Serialize(fs, u);
                    fs.Close();
                }

                if ((int)role == 1)
                {
                    ouserMenu2 frmadmin = new ouserMenu2();
                    this.Hide();
                    frmadmin.Show();
                }
                else
                {
                    adminMenu3 frmouser = new adminMenu3();
                    this.Hide();
                    frmouser.Show();
                }


            }
            else {
                tb1_pswd.Text = "";
                string msg = "Login failed.";
                ver_count++;
                if (ver_count == 3)
                {
                    msg += " you have to enter the verity code.";
                    ver_count = 0;
                    grp1_vercode.Visible = true;
                    load_verity_code();

                }
                MessageBox.Show(msg);
            }

        }

        private void grp1_auto_Enter(object sender, EventArgs e)
        {

        }

        public void load_verity_code() {

            string alphas = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            Random r = new Random();
            Bitmap bmp = new Bitmap(90,40);
            Graphics g = Graphics.FromImage(bmp);

            string code = "";
            for(int i=0; i < 4; i++)
            {
                code += alphas[r.Next(0, alphas.Length - 1)];
                Point p = new Point(i * 20, 0);
                Font f = new Font("Arial", 20, FontStyle.Bold);
                SolidBrush b = new SolidBrush(Color.Black);
                g.DrawString(code[i].ToString(), f, b, p);
            }
            Console.WriteLine("verity code: "+code);
            ver_code = code;
            pic1_ver.Image = bmp;

        }

        private void pic1_ver_Click(object sender, EventArgs e)
        {
            load_verity_code();
        }

        private void ckb1_login_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void btn1_cancel_Click(object sender, EventArgs e)
        {
            timer.Stop();
            grp1_auto.Visible = false;
            ckb1_login.Visible = true;
            ckb1_login.Checked = false;
        }
    }
}
