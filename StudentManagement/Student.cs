using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student
    {
        private int id;
        private string name;
        private string email;
        private string phone_num;

        public int Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string Phone_num
        {
            get { return phone_num; }
            set { phone_num = value; }
        }
        public string getInfo()
        {
            string info = id.ToString() + ", " + name + ", " + email + ", " + phone_num;
            return info;
        }
    }
}
