using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1.Usercontrol
{
    [Serializable]
    public class OfficeUser
    {
        private string email;
        private string password;
        private string lastdate;

        private string name;
        private string gender;
        private DateTime dateorbirth;
        private string phone;
        private Image photo;
        private string address;
        private string role;

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public string Lastdate
        {
            get { return lastdate; }
            set { lastdate = value; }
        }

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public string Gender
        {
            get
            {
                return gender;
            }

            set
            {
                gender = value;
            }
        }

        public DateTime Dateorbirth
        {
            get
            {
                return dateorbirth;
            }

            set
            {
                dateorbirth = value;
            }
        }

        public string Phone
        {
            get
            {
                return phone;
            }

            set
            {
                phone = value;
            }
        }

        public string Role
        {
            get
            {
                return role;
            }

            set
            {
                role = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }

            set
            {
                address = value;
            }
        }

        public Image Photo
        {
            get
            {
                return photo;
            }

            set
            {
                photo = value;
            }
        }
    }
}
