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
    public partial class Add_Member : Form
    {
        public Student Students { get; set; }
        public Add_Member()
        {
            InitializeComponent();

        }



        private void bt_sumbit_Click(object sender, EventArgs e)
        {
            Students.Id = Convert.ToInt32(tb_id.Text);
            Students.Name = tb_name.Text;
            Students.Email = tb_email.Text;
            Students.Phone_num = tb_phone.Text;
            string[] newStu = { tb_id.Text, tb_name.Text, tb_email.Text, tb_phone.Text };
            string newStuLine = string.Join(",", newStu);

            StreamWriter writer = new StreamWriter("students.txt");
            writer.WriteLine(newStuLine);
            writer.Close();


        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Add_Member add_member = new Add_Member();
            this.Hide();
        }

        private void Add_Member_Load(object sender, EventArgs e)
        {

        }
    }
}
