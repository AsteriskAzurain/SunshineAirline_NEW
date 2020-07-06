using Application0701.global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0701.admin
{
    public partial class edituser : Form
    {
        static OfficeUser user;
        static string useremail;
        public edituser()
        {
            InitializeComponent();
        }

        public edituser(string email)
        {
            InitializeComponent();
            useremail = email;
            string sql = "  select * from Users where Email = '"+email+"' ";
            DataRow row = SqlHelper.ExecuteDatatable(sql, null).Rows[0];
            txtemail.Text = row[1].ToString(); txtemail.Enabled = false;
            txtfname.Text = row[2].ToString();
            txtlname.Text = row[3].ToString();
            txttel.Text = row[7].ToString();
            txtaddress.Text = row[9].ToString();
            datebirth.Value = Convert.ToDateTime(row[6]);
            if (row[10].Equals("1")) rdorole1.Checked = true;
            else rdorole2.Checked = true;
            if (row[5].Equals("M")) rdosexm.Checked = true;
            else rdosexf.Checked = true;
            
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void edituser_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            string email = txtemail.Text;
            string firstname = txtfname.Text;
            string lastname = txtlname.Text;
            string gender = rdosexm.Checked ? "M" : "F";
            int roleid = rdorole1.Checked ? 1 : 2;
            DateTime birthday = datebirth.Value;
            
            if(email==""|| firstname==""|| lastname == "")
            {
                MessageBox.Show("missing required fields");
                return;
            }
            string pswd = email.Split('@')[0];
            pswd = pswd.Length > 6 ? pswd.Substring(0, 6) : pswd;

            string sql = "";
            if ((int)SqlHelper.ExecuteScalar(string.Format("select COUNT(0) from Users where Email='{0}'", email), null) > 0)
            {
                // update
                sql = string.Format("insert into Users([Email] ,[FirstName] ,[LastName],[Password],[Gender],[DateOfBirth],[Phone],[Photo],[Address],[RoleId]) values('useruser@user.com','fff','lll','useruser','M','2020-07-06','','','',2)");
            }
            else
            {
                // insert

            }
        }
    }
}
