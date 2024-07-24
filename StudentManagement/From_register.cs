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
    public partial class From_register : Form
    {
        public From_register()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string filePath = "D:\\C#\\StudentManagement\\register.txt";
            try
            {
                StreamWriter writer = new StreamWriter(filePath);
                string info = tb_username.Text + " " + tb_password.Text + " " + tb_phone.Text;
                writer.WriteLine(info);
                writer.Close();
                MessageBox.Show("You login with admin role successfully " +
                                "and the info saved to login.txt");
            }
            catch{}

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
