using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form_teacher : Form
    {
        List<Teacher> teachers = new List<Teacher>();
        List<User> users;
        public Form_teacher()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string[] newrow = { tb_id.Text, tb_name.Text, tb_email.Text, tb_phone.Text, cb_role.Text };
            dataGridView1.Rows.Add(newrow);
            // Step 1: Creating a new student
            int id = Convert.ToInt32(tb_id.Text);
            string name = tb_name.Text;
            string email = tb_email.Text;
            string phone = tb_phone.Text;
            string subject1 = tb_subject1.Text;
            string subject2 = tb_subject2.Text;
            string salary = tb_salary.Text;
            string className = tb_classname.Text;
            Teacher newTeacher = new Teacher(id, name, email, phone, subject1, subject2, salary, className);
            User newUser = new User(id, name, email, phone);

            // Step 2: Adding the new student to the list students
            users.Add(newUser);
            teachers.Add(newTeacher);
            tb_id.Clear();
            tb_name.Clear();
            tb_email.Clear();
            tb_phone.Clear();

        }
    }
}
