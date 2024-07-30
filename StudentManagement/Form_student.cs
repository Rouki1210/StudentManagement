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
    public partial class Form_student : Form
    {
        List<Student> students = new List<Student>();
        List<User> users;
        public Form_student()
        {
            InitializeComponent();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            string[] newrow = { tb_id.Text, tb_name.Text, tb_email.Text, tb_phone.Text, tb_course1.Text, tb_course2.Text, tb_precourse1.Text, tb_precourse2.Text };
            dataGridView1.Rows.Add(newrow);
            int id = Convert.ToInt32(tb_id.Text);
            string name = tb_name.Text;
            string email = tb_email.Text;
            string phone = tb_phone.Text;
            string course1 = tb_course1.Text;
            string course2 = tb_precourse2.Text;
            string precourse1 = tb_precourse1.Text;
            string precourse2 = tb_precourse2.Text;
            Student newStu = new Student(id, name, email, phone, course1, course2, precourse1, precourse2);
            User newUser = new User(id, name, email, phone);

            // Step 2: Adding the new student to the list students
            users.Add(newUser);
            students.Add(newStu);
            tb_id.Clear();
            tb_name.Clear();
            tb_email.Clear();
            tb_phone.Clear();
        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int row_index = dataGridView1.CurrentCell.RowIndex;
            if (row_index >= 0)
            {
                dataGridView1.Rows.RemoveAt(row_index);
            }
        }

        private void bt_logout_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
