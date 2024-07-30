using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Teacher : User
    {
        public string Salary {  get; set; }
        public string Subject_1 { get; set; }
        public string Subject_2 { get; set; }

        public string ClassName {  get; set; }

        public Teacher(int id, string name, string email, string phone, string salary, string subject_1, string subject_2, string className) : base(id, name, email, phone)
        {
            this.Salary = salary;
            this.Subject_1 = subject_1;
            this.Subject_2 = subject_2;
            this.ClassName = className;
        }
    }
}
