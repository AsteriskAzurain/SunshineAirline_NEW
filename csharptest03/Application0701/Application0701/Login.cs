using Application0701.admin;
using Application0701.global;
using Application0701.ouser;
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

namespace Application0701
{
    public partial class Login : Form
    {
        int v_count = 0;
        string vcode;
        Timer timer;
        public object XmlSeaializer { get; private set; }

        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        public void timer_tick(object sender, EventArgs e)
        {
            timer.Stop();
            btnlogin.PerformClick();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
            updateVcode();

            timer = new Timer();
            timer.Interval = 3000;

            FileStream fs = new FileStream("userlogin.xml", FileMode.OpenOrCreate);
            if (fs.Length > 0)
            {
                XmlSerializer xs = new XmlSerializer(typeof(OfficeUser));
                OfficeUser user = xs.Deserialize(fs) as OfficeUser;
                DateTime lastdate = Convert.ToDateTime(user.Lastdate);
                TimeSpan ts = DateTime.Now - lastdate;
                if (ts.Days <= 7)
                {
                    txtemail.Text = user.Email;
                    txtpswd.Text = user.Password;
                    btnautologin.Visible = true;
                    timer.Tick += new EventHandler(timer_tick);
                    timer.Start();
                }
            }
            fs.Close();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {

            if (groupBox1.Visible == true)
            {
                string inputcode = txtvcode.Text;
                if (!inputcode.ToLower().Equals(vcode.ToLower()))
                {
                    MessageBox.Show("Wrong Verity Code.");
                    txtvcode.Text = "";
                    return;
                }
            }

            string email = txtemail.Text;
            string pswd = txtpswd.Text;
            string sql = "select RoleId from Users where Email='{0}' and Password='{1}'";
            sql = string.Format(sql, email, pswd);
            object role = SqlHelper.ExecuteScalar(sql, null);
            if (role != null)
            {
                if ((int)role == 1)
                {
                    // office user
                    ouserMenu frmouser = new ouserMenu();
                    this.Hide();
                    frmouser.Show();
                }
                else
                {
                    // admin
                    adminMenu frmadmin = new adminMenu();
                    this.Hide();
                    frmadmin.Show();
                }
                if (ckbauto.Checked)
                {
                    FileStream fs = new FileStream("userlogin.xml", FileMode.Create);
                    XmlSerializer xs = new XmlSerializer(typeof(OfficeUser));
                    OfficeUser user = new OfficeUser();
                    user.Email = email;
                    user.Password = pswd;
                    user.Lastdate = DateTime.Now.ToString();
                    xs.Serialize(fs, user);
                    fs.Close();
                }
            }
            else
            {
                txtpswd.Text = "";
                txtvcode.Text = "";
                string msg = "login failed.";
                v_count++;
                updateVcode();
                if (v_count == 3)
                {
                    v_count = 0;
                    msg += " You have to input the verity code first.";
                    groupBox1.Visible = true;
                }
                MessageBox.Show(msg);
            }
        }

        public void updateVcode()
        {
            string alpha = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";
            Random r = new Random();
            string code = "";
            for(int i = 0; i < 4; i++)
            {
                code += alpha[r.Next(0, alpha.Length - 1)];
            }
            Console.WriteLine(code);
            vcode = code;
            lblvcode.Text = code;
        }

        private void btnclz_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void lblvcode_Click(object sender, EventArgs e)
        {
            updateVcode();
        }

        private void ckbauto_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnautologin_Click(object sender, EventArgs e)
        {
            timer.Stop();
            btnautologin.Visible = false;
        }
    }
}
