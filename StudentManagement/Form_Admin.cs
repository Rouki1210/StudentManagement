using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Runtime.InteropServices;
using System.IO;

namespace StudentManagement
{
    public partial class Form_Admin : Form
    {
        public List<User> users = new List<User>(); 
        public List<Student> students = new List<Student>();
        public List<Teacher> teachers = new List<Teacher>();
        public List<Admin> admins = new List<Admin>();
        public Form_Admin()
        {
            InitializeComponent();
            pl_stu.Hide();
            pl_admin.Hide();
            pl_teacher.Hide();
        }

        class RoundPictureBox: PictureBox
        {
            protected override void OnPaint(PaintEventArgs e)
            {
                GraphicsPath graphicPath = new GraphicsPath();
                graphicPath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new Region(graphicPath);
                base.OnPaint(e);
            }
        }

        private void addMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[] newrow = { tb_id.Text, tb_name.Text, tb_email.Text, tb_phone.Text, cb_role.Text };
            dataGridView1.Rows.Add(newrow);
            int id = Convert.ToInt32(tb_id.Text);
            string name = tb_name.Text;
            string email = tb_email.Text;
            string phone = tb_phone.Text;
            User newUser=  new User(id, name, email, phone);

            users.Add(newUser);
        }

        private void bt_edit_Click(object sender, EventArgs e)
        {
            int index = dataGridView1.CurrentCell.RowIndex;
            DataGridViewRow newdata = dataGridView1.Rows[index];
            newdata.Cells[0].Value = tb_id.Text;
            newdata.Cells[1].Value = tb_name.Text;
            newdata.Cells[2].Value = tb_email.Text;
            newdata.Cells[3].Value = tb_phone.Text;
            newdata.Cells[4].Value = cb_role.Text;

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int row_index = dataGridView1.CurrentCell.RowIndex;
            if (row_index >= 0)
            {
                dataGridView1.Rows.RemoveAt(row_index);
            }
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string[] newrow = { tb_id.Text, tb_name.Text, tb_email.Text, tb_phone.Text, cb_role.Text };
            dataGridView1.Rows.Add(newrow);

            if (cb_role.Text == "Student")
            {
                // Step 1: Creating a new student
                int id = Convert.ToInt32(tb_id.Text);
                string name = tb_name.Text;
                string email = tb_email.Text;
                string phone = tb_phone.Text;
                User newStu = new User(id, name, email, phone);

                // Step 2: Adding the new student to the list students
                users.Add(newStu);
            }
            tb_id.Clear();
            tb_name.Clear();
            tb_email.Clear();
            tb_phone.Clear();
        }

        private void bt_add_Click_Stu(object sender, EventArgs e)
        {
            string[] newrow = { tb_id.Text, tb_name.Text, tb_email.Text, tb_phone.Text, cb_role.Text };
            dataGridView1.Rows.Add(newrow);
            // Step 1: Creating a new student
            int id = Convert.ToInt32(tb_id.Text);
            string name = tb_name.Text;
            string email = tb_email.Text;
            string phone = tb_phone.Text;
            string course1 = tb_course1.Text;
            string course2 = tb_course2.Text;
            string precourse1 = tb_precourse1.Text;
            string precourse2 = tb_precourse2.Text;
            Student newStu = new Student(id, name,email, phone, course1, course2, precourse1, precourse2);
            User newUser = new User(id, name, email, phone);

                // Step 2: Adding the new student to the list students
            users.Add(newUser);
            students.Add(newStu);
            tb_id.Clear();
            tb_name.Clear();
            tb_email.Clear();
            tb_phone.Clear();
        }
        private void bt_add_Click_Teacher(object sender, EventArgs e)
        {
            string[] newrow = { tb_id.Text, tb_name.Text, tb_email.Text, tb_phone.Text, tb_subject1.Text, tb_subject2.Text, tb_salary.Text };
            dataGridView1.Rows.Add(newrow);
            // New teacher
                int id = Convert.ToInt32(tb_id.Text);
                string name = tb_name.Text;
                string email = tb_email.Text;
                string phone = tb_phone.Text;
                string role = cb_role.Text;
                string subject1 = tb_subject1.Text;
                string subject2 = tb_subject2.Text;
                string salary = tb_salary.Text;
                string className = tb_classname.Text;
                Teacher newTeacher = new Teacher(id, name, email, phone, subject1, subject2, salary, className);
                User newUser = new User(id, name, email, phone);

            // Add to list
            users.Add(newUser);
            teachers.Add(newTeacher);
            tb_id.Clear();
            tb_name.Clear();
            tb_email.Clear();
            tb_phone.Clear();
        }

        private void bt_add_Click_Admin(object sender, EventArgs e)
        {
            string[] newrow = { tb_id.Text, tb_name.Text, tb_email.Text, tb_phone.Text, cb_role.Text };
            dataGridView1.Rows.Add(newrow);
            // Step 1: Creating a new student
            int id = Convert.ToInt32(tb_id.Text);
            string name = tb_name.Text;
            string email = tb_email.Text;
            string phone = tb_phone.Text;
            string type = cb_employ.Text;
            string hours = tb_hours.Text;
            string salary = tb_adsalary.Text;
            string course2 = tb_course2.Text;
            string precourse1 = tb_precourse1.Text;
            string precourse2 = tb_precourse2.Text;
            Admin newAdmin = new Admin(id, name, email, phone, type, hours, salary);
            User newUser = new User(id, name, email, phone);

            // Step 2: Adding the new student to the list students
            users.Add(newUser);
            admins.Add(newAdmin);
            tb_id.Clear();
            tb_name.Clear();
            tb_email.Clear();
            tb_phone.Clear();
        }

        private void WireUpEvents()
        {
            bt_add.Click += bt_add_Click_Stu;
        }

        private void WireUpEventsTeacher()
        {
            bt_add.Click += bt_add_Click_Teacher;
        }

        private void WireUpEventsAdmin()
        {
            bt_add.Click += bt_add_Click_Admin;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row  = this.dataGridView1.Rows[e.RowIndex];
                tb_id.Text = row.Cells[0].Value.ToString();
                tb_name.Text = row.Cells[1].Value.ToString();
                tb_email.Text = row.Cells[2].Value.ToString();
                tb_phone.Text = row.Cells["Phone"].Value.ToString();
                cb_role.Text = row.Cells["role"].Value.ToString();

            }
        }

        private void panel2_Paint(object sender, EventArgs e)
        {
            //Datagridview
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Phone", "Phone");
            dataGridView1.Columns.Add("Role", "Role");
            dataGridView1.Columns.Add("Course 1", "Courser 1");
            dataGridView1.Columns.Add("Course 2", "Course 2");
            dataGridView1.Columns.Add("PreCourse 1", "PreCourse 1");
            dataGridView1.Columns.Add("PreCourse 2", "Course 2");

            //Panel
            pl_stu.Show();
            pl_teacher.Hide();
            pl_admin.Hide();
            WireUpEvents();
        }

        private void panel3_Paint(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Phone", "Phone");
            dataGridView1.Columns.Add("Role", "Role");
            dataGridView1.Columns.Add("Subject 1", "Subject 1");
            dataGridView1.Columns.Add("Subject 2", "Subject 2");
            dataGridView1.Columns.Add("ClassName", "Class Name");
            dataGridView1.Columns.Add("Salary", "Salary");

            pl_teacher.Show();
            pl_admin.Hide();
            pl_stu.Hide();
            WireUpEventsTeacher();
            
        }

        private void panel4_Click(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            dataGridView1.Columns.Add("Id", "Id");
            dataGridView1.Columns.Add("Name", "Name");
            dataGridView1.Columns.Add("Email", "Email");
            dataGridView1.Columns.Add("Phone", "Phone");
            dataGridView1.Columns.Add("Role", "Role");
            dataGridView1.Columns.Add("EmployType", "EmployType");
            dataGridView1.Columns.Add("Hours", "Hours");
            dataGridView1.Columns.Add("Salary", "Salary");

            pl_admin.Show();
            pl_teacher.Hide();
            pl_stu.Hide();
            WireUpEventsAdmin();
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Log out successfully");
            Form1 form1 = new Form1();
            this.Hide();
            form1.ShowDialog();
            this.Close();
        }
    }
}
