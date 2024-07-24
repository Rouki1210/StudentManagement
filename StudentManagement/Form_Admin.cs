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
        private Add_Member add_member;
        List<Student> students = new List<Student>();
        public Form_Admin()
        {
            InitializeComponent();
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
            Add_Member add_Member = new Add_Member() { Students = new Student() };

            try
            {
                if (add_Member.ShowDialog() == DialogResult.OK)
                {
                    studentBindingSource.DataSource = add_Member.Students;
                }
            }
            catch { }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bt_edit_Click(object sender, EventArgs e)
        {

        }

        private void bt_delete_Click(object sender, EventArgs e)
        {
            int row_index = dataGridView1.CurrentCell.RowIndex;
            if (row_index >= 0)
            {
                dataGridView1.Rows.RemoveAt(row_index);
            }
        }
    }
}
