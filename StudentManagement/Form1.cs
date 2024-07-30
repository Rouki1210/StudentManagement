using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tb_password.PasswordChar = '*';
            try
            {
                StreamReader reader = new StreamReader("login.txt");
                string line = reader.ReadLine();
                if (line != null)
                {
                    string[] info = line.Split(' ');
                    tb_username.Text = info[0];
                    tb_password.Text = info[1];
                    cb_role.Text = info[2];
                }
                reader.Close();
            }
            catch { }
        } 

        private bool check_login()
        {
            string filePath = "user.txt";
            try
            {
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        string text =  tb_username.Text + " " + tb_password.Text + " " + cb_role.Text;
                        if (text == line)
                        {
                            return true;
                        }
                        line = reader.ReadLine();
                    }

                }
            }
            catch { }
            return false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
           if (check_login())
            {
                if(cb_role.Text == "Admin")
                {
                Form_Admin form_Admin = new Form_Admin();
                this.Hide();
                form_Admin.ShowDialog();
                this.Close();
                }
                else if (cb_role.Text == "Student")
                {
                    Form_student form_Student = new Form_student();
                    this.Hide(); 
                    form_Student.ShowDialog(); 
                    this.Close();
                }
                else
                {
                    Form_teacher form_Teacher = new Form_teacher();
                    this.Hide();
                    form_Teacher.ShowDialog();  
                    this.Close();
                }
            }
            else
            {
                Label error = new Label();
                error.Text = "Invalid username or password!";
                error.AutoSize = true;
                error.Font = new Font("Microsoft Sans Serif", 10);
                error.ForeColor = Color.Black;
                error.BackColor = Color.Red;

                panel1.Controls.Add(error);
                tb_username.Clear();
                tb_password.Clear();
                tb_username.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            From_register form_Register = new From_register();
            this.Hide();
            form_Register.ShowDialog();
            this.Close();
        }
    }
}
