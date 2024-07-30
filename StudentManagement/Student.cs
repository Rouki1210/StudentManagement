using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagement
{
    public class Student : User
    {
        private string course_1;
        private string course_2;
        private string precourse_1;
        private string precourse_2;

        public Student(int id, string name, string email, string phone ,string course_1, string course_2, string precourse_1, string precourse_2) : base (id, name, email, phone)
        {
            this.course_1 = course_1;
            this.course_2 = course_2;
            this.precourse_1 = precourse_1;
            this.precourse_2 = precourse_2;
        }

        public string Course_1 {
            get { return course_1; }
            set { course_1 = value; }
        }

        public string Course_2
        {
            get { return course_2; }
            set { course_2 = value; }
        }

        public string PreCourse_1
        {
            get { return precourse_1; }
            set { precourse_1 = value; }
        }

        public string PreCourse_2
        {
            get { return precourse_2; }
            set { precourse_1 = value; }
        }



    }
}
