using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application0604.global
{
    //[Serializable]
    public class User
    {
        private string email;
        private string password;
        private string lastdate;

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

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
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
    }
}
