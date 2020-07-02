using Application0604.global;
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

namespace Application0604
{
    public partial class login : Form
    {
        int v_count = 0;
        string ver_code;

        Timer timer;

        public login()
        {
            InitializeComponent();

        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            string email = tbemail.Text;
            string pswd = tbpswd.Text;

            if (grpvcode.Visible == true) {
                string vcode = tbvcode.Text;
                if (!ver_code.ToLower().Equals(vcode.ToLower())) {
                    MessageBox.Show("verity code wrong.");
                    tbvcode.Text = "";
                    loadvcode();
                    return;
                }
            }

            string sql = "select RoleId from Users where Email='{0}' and Password='{1}'";
            sql = string.Format(sql, email, pswd);
            object roieid = SqlHelper.ExecuteScalar(sql, null);
            if (roieid != null)
            {
                if ((int)roieid == 1)
                {
                    ouserMenu frm = new ouserMenu();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    adminMenu frm = new adminMenu();
                    frm.Show();
                    this.Hide();
                }
                if (ckbauto.Checked) {
                    FileStream fs = new FileStream("autouserlogin.xml", FileMode.Create);
                    XmlSerializer xs = new XmlSerializer(typeof(User));
                    User u = new User();
                    u.Email = email;
                    u.Password = pswd;
                    u.Lastdate = DateTime.Now.ToString();
                    xs.Serialize(fs, u);
                    fs.Close();
                }
            }
            else {
                tbpswd.Text = "";
                string msg = "login failed.";
                v_count++;
                if (v_count == 3)
                {
                    v_count = 0;
                    msg += " you have to enter the verity code first";
                    grpvcode.Visible = true;
                    loadvcode();
                }
                MessageBox.Show(msg);
            }

        }

        private void loadvcode()
        {
            Random r = new Random();
            string alphas = "1234567890ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz";

            Bitmap bmp = new Bitmap(90, 40);
            Graphics g = Graphics.FromImage(bmp);

            string code = "";
            for (int i = 0; i < 4; i++) {
                code += (alphas[r.Next(0, alphas.Length - 1)]);
                Point p = new Point(20 * i, 0);
                Font f = new Font("Arial", 20, FontStyle.Bold);
                SolidBrush b = new SolidBrush(Color.Black);
                g.DrawString(code[i].ToString(), f, b, p);
            }
            ver_code = code;
            pictureBox2.Image = bmp;
        }

        private void btnclz_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            loadvcode();
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            timer.Stop();
            grpauto.Visible = false;
            tbpswd.Text = "";
        }

        private void login_Load(object sender, EventArgs e)
        {
            timer = new Timer();
            timer.Interval = 3000;
            FileStream fs = new FileStream("autouserlogin.xml", FileMode.OpenOrCreate);

            if (fs.Length > 0) {
                XmlSerializer xs = new XmlSerializer(typeof(User));
                User u = xs.Deserialize(fs) as User;
                DateTime lt = Convert.ToDateTime(u.Lastdate);
                TimeSpan ts = DateTime.Now - lt;
                if (ts.Days <= 7) {
                    grpauto.Visible = true;
                    tbemail.Text = u.Email;
                    tbpswd.Text = u.Password;
                    ckbauto.Checked = true;
                    grpvcode.Visible = false;
                    timer.Tick += new EventHandler(timeraction);
                    timer.Start();
                }
            }
            fs.Close();

        }

        public void timeraction(object sender, EventArgs e) {
            timer.Stop();
            btnlogin.PerformClick();
        }
    }
}
