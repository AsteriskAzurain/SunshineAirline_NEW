using Application0619.global;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application0619.admin
{
    public partial class userManagement : Form
    {
        string sql;
        DataTable userdata = new DataTable();
        List<User> userlist = new List<User>();

        DataTable showdata = new DataTable();
        DataTable ds = new DataTable();

        int totalIndex, totalPage;
        int currentIndex = 0, currentPage = 1, pageSize = 10;
        //int recordIndex = 0;

        public userManagement()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 250, 203);

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

        private void btnsearch_Click(object sender, EventArgs e)
        {
            int roleid = cbrole.SelectedIndex;
            string likename = txtname.Text;
            ds.Rows.Clear();
            dataGridView1.DataSource = ds;
            dataGridView1.Refresh();

            sql = "Name like '%" + likename.Trim() + "%'";
            if (roleid > 0) {
                string role = cbrole.Text;
                sql += " and Role = '" + role + "'";                
            }
            DataRow[] rowarr = showdata.Select(sql);
            foreach (DataRow row in rowarr)
            {
                ds.ImportRow(row);
            }
            if (ds.Rows.Count > 0) {
                currentIndex = 0;
                dataGridView1.DataSource = ds;
                dataGridView1.Refresh();
            }

        }

        private void cbpage_SelectedIndexChanged(object sender, EventArgs e)
        {
            int cinum = cbpage.SelectedIndex * 10;
            currentIndex = cinum;
            Console.WriteLine("selected index: "+currentIndex.ToString());
            
        }

        private void pbnext_Click(object sender, EventArgs e)
        {
            int cinum = cbpage.SelectedIndex * 10;
            currentIndex = cinum + pageSize;
            if (currentIndex > totalIndex) currentIndex = (totalPage - 1) * pageSize;
            loadData();
        }

        private void pbprevious_Click(object sender, EventArgs e)
        {
            int cinum = cbpage.SelectedIndex * 10;
            currentIndex = cinum-pageSize;
            if (currentIndex <= 0) currentIndex = 0;
            loadData();
        }

        private void pbfirst_Click(object sender, EventArgs e)
        {
            currentIndex = 0;
            loadData();
        }

        private void pblast_Click(object sender, EventArgs e)
        {
            currentIndex = (totalPage - 1) * pageSize;
            loadData();
        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void userManagement_Load(object sender, EventArgs e)
        {
            sql = "select * from Users";
            userdata = SqlHelper.ExecuteDataTable(sql, null);
            //dataGridView1.DataSource = userdata;
            //dataGridView1.Refresh();

            totalIndex = userdata.Rows.Count;
            totalPage = (totalIndex % pageSize == 0) ? totalIndex / pageSize : totalIndex / pageSize + 1;
            Console.WriteLine("total: index "+totalIndex+"; pages "+totalPage);
            lbltpages.Text = totalPage.ToString();
            lbltrecords.Text = totalIndex.ToString();
            for (int a = 1; a <= totalPage; a++) {
                cbpage.Items.Add(a);
            }

            int i = 0;
            foreach (DataRow row in userdata.Rows) {
                User user = new User();
                user.Id=i;

                user.Email = Convert.ToString(row["Email"]);
                user.Firstname = Convert.ToString(row["FirstName"]);
                user.Lastname = Convert.ToString(row["Lastname"]);
                user.Gender = Convert.ToString(row["Gender"]).Equals("M") ? "Male" : "Female";
                user.Birthday = Convert.ToDateTime(row["DateOfBirth"]);
                user.Tel = Convert.ToString(row["Phone"]);
                user.Role = Convert.ToInt32(row["RoleId"]) == 1 ? "Office User" : "Administrator";

                user.Pswd = Convert.ToString(row["Password"]);
                user.Photo = null; //todo

                userlist.Add(user);
                i++;
            }
            Console.WriteLine("list size:"+userlist.Count);

            foreach (User user in userlist) {
                DataRow dr = showdata.NewRow();
                dr["Email"] = user.Email;
                dr["Name"] = user.Firstname + " " + user.Lastname;
                dr["Gender"] = user.Gender;
                dr["DateOrBirth"] = user.Birthday.ToString("yyyy-MM-dd");
                dr["Phone"] = user.Tel;
                dr["Role"] = user.Role;

                showdata.Rows.Add(dr);
                //Console.WriteLine("showdata rows: " + showdata.Rows.Count.ToString());
            }
            Console.WriteLine("total showdata rows: " + showdata.Rows.Count.ToString());

            loadData();
        }

        public void getPagenum() {
            if (currentIndex < 0) currentIndex = 0;
            //currentPage = (currentIndex % pageSize==0)? currentIndex / pageSize: currentIndex / pageSize + 1;
            currentPage = currentIndex / pageSize + 1;
            if (currentPage < 0) currentPage = 0;
            Console.WriteLine("current: index " + currentIndex + "; page " + currentPage);
            cbpage.Text = currentPage.ToString();

        }

        public void loadData()
        {
            Console.WriteLine("current: index " + currentIndex + "; page " + currentPage);
            cbpage.SelectedText = (currentIndex / pageSize + 1).ToString();

            ds.Rows.Clear();
            dataGridView1.DataSource = ds;
            dataGridView1.Refresh();

            for (int b = 0; b < pageSize; b++) {
                if (currentIndex >= totalIndex) break;
                ds.ImportRow(showdata.Rows[currentIndex]);
                currentIndex++;
            }
            Console.WriteLine("ds count: "+ds.Rows.Count);
            dataGridView1.DataSource = ds;
            dataGridView1.Refresh();
        }
    }
}
