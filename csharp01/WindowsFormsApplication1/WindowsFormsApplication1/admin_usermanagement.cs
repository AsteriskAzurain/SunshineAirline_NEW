using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication1.Usercontrol;

namespace WindowsFormsApplication1
{
    public partial class admin_usermanagement : Form
    {
        string sql;
        DataTable dt = new DataTable();
        DataTable dt_bak = new DataTable();
        DataTable dt1 = new DataTable();
        DataTable dt2 = new DataTable();
        List<OfficeUser> list = new List<OfficeUser>();

        int recordIndex = 0;
        int recordperPage = 10;
        int currentPage = 0;
        int pages;
        int count;

        public admin_usermanagement()
        {
            InitializeComponent();

            dt1.Columns.Add("Email");
            dt1.Columns.Add("Name");
            dt1.Columns.Add("Gender");
            dt1.Columns.Add("DateOrBirth");
            dt1.Columns.Add("Phone");
            dt1.Columns.Add("Role");

            sql = "select * from Role";
            dt = SqlHelper.ExecuteDataTable(sql, null);
            cbrole.DataSource = dt;
            cbrole.DisplayMember = "RoleName";
            cbrole.ValueMember = "RoldId";
            cbrole.SelectedIndex = 0;
        }

        private void btnsearch_Click(object sender, EventArgs e)
        {
            dt2 = dt_bak.Copy();
            string role = cbrole.Text;
            string likename = tbname.Text;
            sql = string.Format("Name like '%{0}%' and Role = '{1}'", likename.Trim(),role);
            DataRow[] rowarr = dt2.Select(sql);
            //dt2.Clear();
            //dataGridView1.DataSource = dt2;
            //dataGridView1.Refresh();
            dt1.Rows.Clear();
            foreach (DataRow row in rowarr) {
                //DataRow newrow = dt1.NewRow();
                //newrow.ItemArray = row.ItemArray;
                //dt1.Rows.Add(newrow);
                dt1.ImportRow(row);
            }

            recordIndex = 0;
            currentPage = 0;
            count = dt1.Rows.Count;

            if (count > 0)
            {
                pages = (count % 10 == 0 ? count / 10 : count / 10 + 1);
                lbltpages.Text = pages.ToString();
                lbltrecords.Text = count.ToString();
                cbpage.Items.Clear();
                for (int i = 1; i <= pages; i++)
                {
                    cbpage.Items.Add(i);
                }
                //cbpage.SelectedIndex = 0;

                loadData();
            }
            else {
                dt2.Rows.Clear();
                dataGridView1.DataSource = dt2;
                dataGridView1.Refresh();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string editemail = dataGridView1.CurrentRow.Cells["Email"].Value.ToString();
            admin_adduser frmedit = new admin_adduser(editemail);
            frmedit.Show();
        }

        private void admin_usermanagement_Load(object sender, EventArgs e)
        {
            sql = "select * from Users";
            dt = SqlHelper.ExecuteDataTable(sql, null);
            foreach (DataRow row in dt.Rows) {

                OfficeUser user = new OfficeUser();

                user.Email = Convert.ToString(row["Email"]);
                user.Name = Convert.ToString(row["FirstName"]) + " " + Convert.ToString(row["Lastname"]);
                user.Gender = Convert.ToString(row["Gender"]).Equals("M") ? "Male" : "Female";
                user.Dateorbirth = Convert.ToDateTime(row["DateOfBirth"]);
                user.Phone = Convert.ToString(row["Phone"]);
                user.Role = Convert.ToInt32(row["RoleId"]) == 1 ? "Office User" : "Administrator";

                user.Password = Convert.ToString(row["Password"]);
                user.Photo = null; //todo

                list.Add(user);

            }
            foreach (OfficeUser user in list) {
                DataRow dr = dt1.NewRow();
                dr["Email"] = user.Email;
                dr["Name"] = user.Name;
                dr["Gender"] = user.Gender;
                dr["DateOrBirth"] = user.Dateorbirth.ToString("yyyy-MM-dd");
                dr["Phone"] = user.Phone;
                dr["Role"] = user.Role;

                dt1.Rows.Add(dr);
            }
            dt_bak = dt1.Copy();
            dt2 = dt1.Copy();

            count = list.Count;
            pages = (count % 10 == 0 ? count / 10 : count / 10 + 1);
            lbltpages.Text = pages.ToString();
            lbltrecords.Text = count.ToString();
            for(int i = 1; i <= pages; i++)
            {
                cbpage.Items.Add(i);
            }
            //cbpage.SelectedIndex = 0;

            loadData();
        }

        public void loadData() {

            currentPage = recordIndex / recordperPage;
            //currentPage = recordIndex % recordperPage == 0 ? recordIndex / recordperPage : recordIndex / recordperPage + 1;
            if (currentPage >= pages) { //超出范围 
                currentPage = pages - 1; //currentpage=最后一页
                recordIndex = count - recordperPage; //index=倒数第十条数据
            }
           
            cbpage.SelectedIndex = currentPage;

            dt2.Clear();

            for (int i = 0; i < 10; i++) {
                if (recordIndex >= count) break;
                dt2.ImportRow(dt1.Rows[recordIndex]);
                recordIndex++;
            }
            //recordIndex是下一页第一条的index

            dataGridView1.DataSource = dt2;
            //dataGridView1.DataMember = "Users";
            dataGridView1.Refresh();
        }

        private void pbnext_Click(object sender, EventArgs e)
        {
            //recordIndex -= 10;
            loadData();
        }

        private void pbprevious_Click(object sender, EventArgs e)
        {
            recordIndex -= 2*recordperPage;
            if (recordIndex < 0) recordIndex = 0;
            loadData();
        }

        private void pbfirst_Click(object sender, EventArgs e)
        {
            recordIndex = 0;
            loadData();
        }

        private void pblast_Click(object sender, EventArgs e)
        {
            recordIndex = count - recordperPage;
            loadData();
        }

        private void cbpage_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int n = cbpage.SelectedIndex;
            //if (n == -1) { cbpage.SelectedIndex = 0; return; }
            //recordIndex = cbpage.SelectedIndex * 10;
            //loadData();
            ////(cbpage.SelectedIndex>0) cbpage.SelectedIndex -= 1;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cbpage_SelectionChangeCommitted(object sender, EventArgs e)
        {
            recordIndex = cbpage.SelectedIndex * 10;
            loadData();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            admin_adduser frmadd = new admin_adduser();
            frmadd.Show();
            this.Hide();
            this.Close();
        }

        private void cbrole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
