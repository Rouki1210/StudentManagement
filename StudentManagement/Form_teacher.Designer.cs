namespace StudentManagement
{
    partial class Form_teacher
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.bt_delete = new System.Windows.Forms.Button();
            this.tb_classname = new System.Windows.Forms.TextBox();
            this.lb_classname = new System.Windows.Forms.Label();
            this.tb_subject1 = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.tb_subject2 = new System.Windows.Forms.TextBox();
            this.lb_subject2 = new System.Windows.Forms.Label();
            this.lb_subject1 = new System.Windows.Forms.Label();
            this.lb_salary = new System.Windows.Forms.Label();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClassName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 449);
            this.panel1.TabIndex = 1;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Nirmala UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(21, 223);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(137, 20);
            this.lb_name.TabIndex = 2;
            this.lb_name.Text = "Nguyen Thanh Vinh";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::StudentManagement.Properties.Resources.University_of_Greenwich;
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(272, 132);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(149, 22);
            this.tb_phone.TabIndex = 56;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(217, 133);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(47, 16);
            this.lb_phone.TabIndex = 55;
            this.lb_phone.Text = "Phone";
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Admin",
            "Student",
            "Teacher"});
            this.cb_role.Location = new System.Drawing.Point(272, 160);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(107, 21);
            this.cb_role.TabIndex = 54;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(220, 196);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(91, 23);
            this.bt_add.TabIndex = 53;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(272, 74);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(149, 22);
            this.tb_name.TabIndex = 52;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(272, 43);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(107, 22);
            this.tb_id.TabIndex = 51;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(272, 104);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(149, 22);
            this.tb_email.TabIndex = 50;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(217, 105);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(44, 16);
            this.lb_email.TabIndex = 49;
            this.lb_email.Text = "Email";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.Location = new System.Drawing.Point(217, 160);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(37, 16);
            this.lb_role.TabIndex = 48;
            this.lb_role.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(217, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 47;
            this.label2.Text = "Name";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(217, 44);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(20, 16);
            this.lb_id.TabIndex = 46;
            this.lb_id.Text = "Id";
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(352, 196);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(91, 23);
            this.bt_delete.TabIndex = 45;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            // 
            // tb_classname
            // 
            this.tb_classname.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_classname.Location = new System.Drawing.Point(584, 119);
            this.tb_classname.Name = "tb_classname";
            this.tb_classname.Size = new System.Drawing.Size(107, 22);
            this.tb_classname.TabIndex = 64;
            // 
            // lb_classname
            // 
            this.lb_classname.AutoSize = true;
            this.lb_classname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_classname.Location = new System.Drawing.Point(493, 120);
            this.lb_classname.Name = "lb_classname";
            this.lb_classname.Size = new System.Drawing.Size(79, 16);
            this.lb_classname.TabIndex = 63;
            this.lb_classname.Text = "ClassName";
            // 
            // tb_subject1
            // 
            this.tb_subject1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subject1.Location = new System.Drawing.Point(584, 38);
            this.tb_subject1.Name = "tb_subject1";
            this.tb_subject1.Size = new System.Drawing.Size(107, 22);
            this.tb_subject1.TabIndex = 62;
            // 
            // tb_salary
            // 
            this.tb_salary.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salary.Location = new System.Drawing.Point(584, 93);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(107, 22);
            this.tb_salary.TabIndex = 61;
            // 
            // tb_subject2
            // 
            this.tb_subject2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subject2.Location = new System.Drawing.Point(584, 66);
            this.tb_subject2.Name = "tb_subject2";
            this.tb_subject2.Size = new System.Drawing.Size(107, 22);
            this.tb_subject2.TabIndex = 60;
            // 
            // lb_subject2
            // 
            this.lb_subject2.AutoSize = true;
            this.lb_subject2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subject2.Location = new System.Drawing.Point(493, 72);
            this.lb_subject2.Name = "lb_subject2";
            this.lb_subject2.Size = new System.Drawing.Size(66, 16);
            this.lb_subject2.TabIndex = 59;
            this.lb_subject2.Text = "Subject 2";
            // 
            // lb_subject1
            // 
            this.lb_subject1.AutoSize = true;
            this.lb_subject1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subject1.Location = new System.Drawing.Point(493, 44);
            this.lb_subject1.Name = "lb_subject1";
            this.lb_subject1.Size = new System.Drawing.Size(66, 16);
            this.lb_subject1.TabIndex = 58;
            this.lb_subject1.Text = "Subject 1";
            // 
            // lb_salary
            // 
            this.lb_salary.AutoSize = true;
            this.lb_salary.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salary.Location = new System.Drawing.Point(493, 99);
            this.lb_salary.Name = "lb_salary";
            this.lb_salary.Size = new System.Drawing.Size(47, 16);
            this.lb_salary.TabIndex = 57;
            this.lb_salary.Text = "Salary";
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(600, 196);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(91, 23);
            this.bt_cancel.TabIndex = 66;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(471, 196);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(91, 23);
            this.bt_edit.TabIndex = 65;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FullName,
            this.Email,
            this.Phone,
            this.Subject1,
            this.Subject2,
            this.ClassName,
            this.Salary});
            this.dataGridView1.Location = new System.Drawing.Point(193, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(599, 201);
            this.dataGridView1.TabIndex = 67;
            // 
            // Id
            // 
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Name";
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // Email
            // 
            this.Email.HeaderText = "Email";
            this.Email.Name = "Email";
            this.Email.ReadOnly = true;
            // 
            // Phone
            // 
            this.Phone.HeaderText = "Phone";
            this.Phone.Name = "Phone";
            this.Phone.ReadOnly = true;
            // 
            // Subject1
            // 
            this.Subject1.HeaderText = "Subject 1";
            this.Subject1.Name = "Subject1";
            this.Subject1.ReadOnly = true;
            // 
            // Subject2
            // 
            this.Subject2.HeaderText = "Subject 2";
            this.Subject2.Name = "Subject2";
            this.Subject2.ReadOnly = true;
            // 
            // ClassName
            // 
            this.ClassName.HeaderText = "ClassName";
            this.ClassName.Name = "ClassName";
            this.ClassName.ReadOnly = true;
            // 
            // Salary
            // 
            this.Salary.HeaderText = "Salary";
            this.Salary.Name = "Salary";
            this.Salary.ReadOnly = true;
            // 
            // Form_teacher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.tb_classname);
            this.Controls.Add(this.lb_classname);
            this.Controls.Add(this.tb_subject1);
            this.Controls.Add(this.tb_salary);
            this.Controls.Add(this.tb_subject2);
            this.Controls.Add(this.lb_subject2);
            this.Controls.Add(this.lb_subject1);
            this.Controls.Add(this.lb_salary);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form_teacher";
            this.Text = "Form_teacher";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox tb_classname;
        private System.Windows.Forms.Label lb_classname;
        private System.Windows.Forms.TextBox tb_subject1;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.TextBox tb_subject2;
        private System.Windows.Forms.Label lb_subject2;
        private System.Windows.Forms.Label lb_subject1;
        private System.Windows.Forms.Label lb_salary;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClassName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salary;
    }
}