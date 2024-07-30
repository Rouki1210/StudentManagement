using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Admin : User
    {
        private string salary;
        private string type;
        private string hour;

        public Admin(int id, string name, string email, string phone, string salary, string type, string hour) : base (id, name, email, phone)
        {
            this.salary = salary;
            this.type = type;
            this.hour = hour;
        }
        public string Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        public string Hour
        {
            get { return hour; }
            set { hour = value; }
        }
    }
}
