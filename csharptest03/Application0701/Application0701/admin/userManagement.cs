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
    public partial class userManagement : Form
    {
        List<OfficeUser> userlist = new List<OfficeUser>();

        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        DataTable userdata = new DataTable();
        DataTable showdata = new DataTable();
        DataTable ds = new DataTable();

        int totalIndex, totalPage;
        int currentIndex = 0, currentPage = 1,pagesize = 10;

        public userManagement()
        {
            InitializeComponent();

            showdata.Columns.Add("Email");
            showdata.Columns.Add("Name");
            showdata.Columns.Add("Gender");
            showdata.Columns.Add("DateOrBirth");
            showdata.Columns.Add("Phone");
            showdata.Columns.Add("Role");

            ds.Columns.Add("Email");
            ds.Columns.Add("Name");
            ds.Columns.Add("Gender");
            ds.Columns.Add("DateOrBirth");
            ds.Columns.Add("Phone");
            ds.Columns.Add("Role");
        }

        private void userManagement_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.FromArgb(255, 250, 203);

            string sql = "select * from Users";
            userdata = SqlHelper.ExecuteDatatable(sql, null);
            totalIndex = userdata.Rows.Count;
            totalPage = (totalIndex % pagesize == 0) ? totalIndex / pagesize : totalIndex / pagesize + 1;
            lbltotalpage.Text = totalPage.ToString();
            lbltotalrecord.Text = totalIndex.ToString();
            for(int a = 1; a <= totalPage; a++)
            {
                cbpage.Items.Add(a);
            }

            int i = 0;
            foreach(DataRow row in userdata.Rows)
            {
                OfficeUser user = new OfficeUser();
                user.Id = i;
                user.Email = Convert.ToString(row["Email"]);
                user.Firstname = Convert.ToString(row["FirstName"]);
                user.Lastname = Convert.ToString(row["Lastname"]);
                user.Gender = Convert.ToString(row["Gender"]).Equals("M") ? "Male" : "Female";
                user.Birthday = Convert.ToDateTime(row["DateOfBirth"]);
                user.Phone = Convert.ToString(row["Phone"]);
                user.Role = Convert.ToInt32(row["RoleId"]) == 1 ? "Office User" : "Administrator";

                user.Password = Convert.ToString(row["Password"]);
                user.Photo = null;

                userlist.Add(user);
                i++;
            }

            foreach (OfficeUser user in userlist)
            {
                DataRow dr = showdata.NewRow();
                dr["Email"] = user.Email;
                dr["Name"] = user.Firstname + " " + user.Lastname;
                dr["Gender"] = user.Gender;
                dr["DateOrBirth"] = user.Birthday.ToString("yyyy-MM-dd");
                dr["Phone"] = user.Phone;
                dr["Role"] = user.Role;

                showdata.Rows.Add(dr);
            }

            loadData();
        }

        private void picnext_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(currentIndex.ToString());
            currentIndex += pagesize;
            currentPage++;
            if (currentIndex >= totalIndex) currentIndex = (totalPage - 1) * pagesize;
            if (currentPage >= totalPage) currentPage = totalPage;
            loadData();
        }

        private void picpre_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(currentIndex.ToString());
            currentIndex -= pagesize;
            currentPage--;
            if (currentIndex <= 0) currentIndex = 0;
            if (currentPage <= 0) currentPage = 1;
            loadData();
        }

        private void picfirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            currentPage = 1;
            loadData();
        }

        private void piclast_Click(object sender, EventArgs e)
        {
            currentIndex = (totalPage - 1) * pagesize;
            currentPage = totalPage;
            loadData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            edituser frmadd = new edituser();
            frmadd.Show();
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {

        }

        public void loadData()
        {
            //cbpage.SelectedText = (currentIndex / pagesize + 1).ToString();
            //MessageBox.Show("c page"+currentPage.ToString());
            cbpage.SelectedIndex = currentPage-1;

            ds.Rows.Clear();
            dataGridView1.DataSource = ds;
            dataGridView1.Refresh();

            for (int b = 0; b < pagesize; b++)
            {
                if (currentIndex >= totalIndex) break;
                ds.ImportRow(showdata.Rows[currentIndex]);
                currentIndex++;
            }
            dataGridView1.DataSource = ds;
            dataGridView1.Refresh();
        }
    }
}
