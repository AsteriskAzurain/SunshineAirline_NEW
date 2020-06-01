using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Usercontrol;

namespace WindowsFormsApplication1
{
    public partial class admin_adduser : Form
    {
        string sql;

        OfficeUser user = new OfficeUser();
        string firstname, lastname, email,password;
        DateTime birthday;
        int roleid;
        Image pic;
        SqlParameter[] pms;

        private void btnphoto_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK) {
                ComponentResourceManager resources = new ComponentResourceManager(typeof(admin_adduser));
                picphoto.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            admin_usermanagement frmum = new admin_usermanagement();
            frmum.Show();
            this.Close();
        }

        private void admin_adduser_Load(object sender, EventArgs e)
        {
            rdoouser.Checked = true;
            rdom.Checked = true;

            if (!string.IsNullOrEmpty(email)) {
                tbemail.Text = email;
                tbemail.ReadOnly = true;

                sql = "select * from Users where Email = '{0}'";
                sql = string.Format(sql, email);
                DataTable dt = new DataTable();
                dt = SqlHelper.ExecuteDataTable(sql, null);
                DataRow row = dt.Rows[0];

                tbfname.Text = row["FirstName"].ToString();
                tblname.Text = row["LastName"].ToString();
                tbaddr.Text = row["Address"].ToString();
                tbtel.Text = row["Phone"].ToString();
                datebirth.Value = Convert.ToDateTime(row["DateOfBirth"]);
                if (row["RoleId"].Equals("1")) rdoouser.Checked = true;
                else rdoadmin.Checked = true;
                if (row["Gender"].Equals("M")) rdom.Checked = true;
                else rdof.Checked = true;
                if (row["Photo"].ToString()!="") {
                    byte[] loadpicbyte = (byte[])row["Photo"];
                    MemoryStream stream = new MemoryStream(loadpicbyte, true); //param：byte[] buffe, bool writable
                    stream.Write(loadpicbyte, 0, loadpicbyte.Length);
                    picphoto.Image = new Bitmap(stream);
                    stream.Close();
                }
            }
        }

        public admin_adduser()
        {
            InitializeComponent();
        }

        private void datebirth_ValueChanged(object sender, EventArgs e)
        {

        }

        public admin_adduser(string editemail)
        {
            InitializeComponent();

            email = editemail;       
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            firstname = tbfname.Text;
            lastname = tblname.Text;
            email= tbemail.Text;
            birthday = Convert.ToDateTime(datebirth.Text);
            password= email.Split('@')[0];
            if (password.Length >= 6) password = password.Substring(0, 6);
            pic = picphoto.Image;
            byte[] picByte = null;
            if (pic != null) {
                MemoryStream ms = new MemoryStream(); //创建内存流，将图片转为二进制流
                Image img = new Bitmap(picphoto.Width,picphoto.Height);
                Graphics draw = Graphics.FromImage(img);
                draw.DrawImage(pic, 0, 0);
                pic.Dispose();
                img.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg); //以jepg方式保存二进制流
                if (ms.Length > 100 * 1024) //ms的长度大于100kb
                {
                    MessageBox.Show("The Picture shouldn't be bigger than 100KB");
                    return;
                }
                else {
                    picByte = ms.ToArray();
                    ms.Close();
                }

            }
            Regex re = new Regex(@"^\w+([-.+]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"); //正则表达式
            if (firstname == "" || lastname == "" || email == "" || birthday.Equals(null))
            {
                MessageBox.Show("Missing Required Information。");
                return;
            }
            else if (!re.IsMatch(email)) {
                MessageBox.Show("Invaild Email.");
                return;
            }
            else
            {
                user.Name = firstname + " " + lastname;
                user.Email = email;
                user.Dateorbirth = birthday;
                user.Address = tbaddr.Text;
                user.Role = rdoouser.Checked ? "Office User" : "Administrator";
                roleid = rdoouser.Checked ? 1 : 2;
                user.Gender = rdom.Checked ? "M" : "F";
                user.Phone = tbtel.Text;
                user.Password = password;
                user.Photo = null;

                sql = string.Format("select count(*) from Users where Email = '{0}'",email);
                int count = Convert.ToInt32(SqlHelper.ExecuteScalar(sql, null));
                if (count == 0)
                {
                    sql = @"insert into Users(Email,Password,FirstName,LastName,DateOfBirth,Phone,RoleId,Gender,Address,Photo) 
                        values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}', {6}, '{7}', '{8}', @pic)";
                    sql = string.Format(sql, user.Email, user.Password, user.Name.Split(' ')[0], user.Name.Split(' ')[1], user.Dateorbirth, user.Phone, roleid, user.Gender, user.Address);
                }
                else if (count > 1) return;
                else {
                    sql = @"update Users 
                            set
                            FirstName='{0}',LastName='{1}',DateOfBirth='{2}',Phone='{3}',RoleId={4},Gender='{5}',Address='{6}',Photo=@pic
                            where Email = '{7}'";
                    sql=string.Format(sql, user.Name.Split(' ')[0], user.Name.Split(' ')[1], user.Dateorbirth, user.Phone, roleid, user.Gender, user.Address,user.Email);
                }
                if (pic!=null)
                {
                    pms = new SqlParameter[] { new SqlParameter("@pic", SqlDbType.Image) { Value = picByte } };
                }
                else {
                    pms = new SqlParameter[] { new SqlParameter("@pic", SqlDbType.Image) { Value = null } };
                }
                int rt=SqlHelper.ExecuteonQuery(sql, pms);
                if (rt == 1)
                {
                    MessageBox.Show("Submit Succeed.");
                }
                else {
                    MessageBox.Show("Submit Failed");
                }

                admin_usermanagement frmum = new admin_usermanagement();
                frmum.Show();
                this.Close();
            }


        }
    }
}
