using Application0706.global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0706
{
    public partial class Login : Form
    {
        int v_count = 0;
        string v_code;

        public Login()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string pswd = txtpswd.Text;
            string vcode = txtvcode.Text;

            if (groupBox1.Visible&&!vcode.Equals(v_code))
            {
                MessageBox.Show("verity code wrong");
                return;
            }

            string sql= string.Format("select RoleId from Users where Email='{0}' and Password='{1}'",email,pswd);
            object role = SqlHelper.ExecuteScalar(sql, null);
            if (role != null)
            {
                // get user
                if ((int)role == 1)
                {
                    // office user

                }
                else
                {
                    // admin
                }
            }else
            {
                string msg = "Login failed. ";
                v_count++;
                if (v_count > 2)
                {
                    msg += "you have to enter the verity code first";
                    v_count = 0;
                    groupBox1.Visible = true;
                }
                MessageBox.Show(msg);
            }
        }

        public void loadVcode()
        {
            string alpha = "ABCDEFGHIJLMNOPQRSTUVWXYZabcdefghjklmnopqrstuvwxyz0123456789";
            Random r = new Random();
            string str = "";
            for(int i = 0; i < 4; i++)
            {
                str += alpha[r.Next(0, alpha.Length)];
            }
            lblvcode.Text = str;
            v_code = str;
        }

        private void Login_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
            loadVcode();
        }
    }
}
