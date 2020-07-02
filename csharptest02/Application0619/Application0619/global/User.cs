using System;
using System.Drawing;

namespace Application0619
{
    public class User
    {
        private int id;

        private string email;
        private string pswd;
        private string lastdate;

        private string firstname;
        private string lastname;
        private string role;
        private string gender;
        private string tel;
        private string address;
        private DateTime birthday;
        private Image photo;


        public string Email
        {
            get
            {
                return email;
            }

            set
            {
                email = value;
            }
        }

        public string Pswd
        {
            get
            {
                return pswd;
            }

            set
            {
                pswd = value;
            }
        }

        public string Lastdate
        {
            get
            {
                return lastdate;
            }

            set
            {
                lastdate = value;
            }
        }

        public string Firstname
        {
            get
            {
                return firstname;
            }

            set
            {
                firstname = value;
            }
        }

        public string Lastname
        {
            get
            {
                return lastname;
            }

            set
            {
                lastname = value;
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

        public string Tel
        {
            get
            {
                return tel;
            }

            set
            {
                tel = value;
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

        public DateTime Birthday
        {
            get
            {
                return birthday;
            }

            set
            {
                birthday = value;
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

        public int Id
        {
            get
            {
                return id;
            }

            set
            {
                id = value;
            }
        }
    }
}