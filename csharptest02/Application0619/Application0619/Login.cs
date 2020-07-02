using Application0619.admin;
using Application0619.global;
using Application0619.ouser;
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

namespace Application0619
{
    public partial class Login : Form
    {
        int v_count = 0;
        Timer timeautologin;
        string vcode;

        public Login()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 250, 203);
            updateVCode();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            if (grpvcode.Visible) {
                if (!vcode.ToLower().Equals(txtvcode.Text.ToLower())) {
                    txtvcode.Text = "";
                    return;
                }
            }

            string email = txtemail.Text;
            string pswd = txtpswd.Text;
            string sql = string.Format("select RoleId from Users where Email='{0}' and Password='{1}'", email, pswd);
            object role = SqlHelper.ExecuteScalar(sql, null);
            if (role != null)
            {
                if ((int)role == 1)
                {
                    //office user
                    ouserMenu frm = new ouserMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    //admin
                    adminMenu frm = new adminMenu();
                    frm.Show();
                    this.Hide();
                }
                if (ckautologin.Checked)
                {
                    FileStream fs = new FileStream("autoLogin.xml", FileMode.Create);
                    XmlSerializer xs = new XmlSerializer(typeof(User));
                    User user = new User();
                    user.Email = email;
                    user.Pswd = pswd;
                    user.Lastdate = DateTime.Now.ToString();
                    xs.Serialize(fs, user);
                    fs.Close();
                }
            }
            else {
                updateVCode();
                txtpswd.Text = "";
                txtvcode.Text = "";
                v_count++;
                string msg = "login failed.";
                if (v_count > 2) {
                    v_count = 0;
                    grpvcode.Visible = true;
                    msg += "please input the verity code first.";
                }
                MessageBox.Show(msg);
            }
        }

        public void updateVCode() {
            Random r = new Random();
            string alphas = "1234567890abcdefghijklmnopqostuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            string code = "";
            for (int i = 0; i < 4; i++) {
                code += (alphas[r.Next(0, alphas.Length - 1)]);
            }
            Console.WriteLine(code);
            vcode = code;

            lblvcode.Text = code;

        }

        private void lblvcode_Click(object sender, EventArgs e)
        {
            updateVCode();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            timeautologin = new Timer();
            timeautologin.Interval = 3000;

            FileStream fs = new FileStream("autoLogin.xml", FileMode.OpenOrCreate);
            if (fs.Length > 0)
            {
                //反序列化
                XmlSerializer xs = new XmlSerializer(typeof(User));
                User lastuser = xs.Deserialize(fs) as User;
                DateTime lastdate = Convert.ToDateTime(lastuser.Lastdate);
                TimeSpan ts = DateTime.Now - lastdate;
                if (ts.Days <= 7)
                {
                    txtemail.Text = lastuser.Email;
                    txtpswd.Text = lastuser.Pswd;
                    grp3s.Visible = true;
                    timeautologin.Tick += new EventHandler(timerautologin_Tick);
                    timeautologin.Start();
                }
            }
            fs.Close();

        }

        public void timerautologin_Tick(object sender, EventArgs e) {
            timeautologin.Stop();
            btnlogin.PerformClick();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            timeautologin.Stop();
            txtpswd.Text = "";
            grp3s.Visible = false;
        }
    }
}
