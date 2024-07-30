namespace StudentManagement
{
    partial class Form_student
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
            this.tb_precourse2 = new System.Windows.Forms.TextBox();
            this.lb_precouse2 = new System.Windows.Forms.Label();
            this.tb_course2 = new System.Windows.Forms.TextBox();
            this.tb_course1 = new System.Windows.Forms.TextBox();
            this.tb_precourse1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_course2 = new System.Windows.Forms.Label();
            this.lb_course1 = new System.Windows.Forms.Label();
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_edit = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cousre1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Course2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreCourse1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PreCourse2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(107, 122);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(149, 22);
            this.tb_phone.TabIndex = 68;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(52, 123);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(47, 16);
            this.lb_phone.TabIndex = 67;
            this.lb_phone.Text = "Phone";
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Admin",
            "Student",
            "Teacher"});
            this.cb_role.Location = new System.Drawing.Point(107, 150);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(107, 21);
            this.cb_role.TabIndex = 66;
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(55, 186);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(91, 23);
            this.bt_add.TabIndex = 65;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(107, 64);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(149, 22);
            this.tb_name.TabIndex = 64;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(107, 33);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(107, 22);
            this.tb_id.TabIndex = 63;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(107, 94);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(149, 22);
            this.tb_email.TabIndex = 62;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(52, 95);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(44, 16);
            this.lb_email.TabIndex = 61;
            this.lb_email.Text = "Email";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.Location = new System.Drawing.Point(52, 150);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(37, 16);
            this.lb_role.TabIndex = 60;
            this.lb_role.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 59;
            this.label2.Text = "Name";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(52, 34);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(20, 16);
            this.lb_id.TabIndex = 58;
            this.lb_id.Text = "Id";
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(187, 186);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(91, 23);
            this.bt_delete.TabIndex = 57;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // tb_precourse2
            // 
            this.tb_precourse2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precourse2.Location = new System.Drawing.Point(425, 122);
            this.tb_precourse2.Name = "tb_precourse2";
            this.tb_precourse2.Size = new System.Drawing.Size(107, 22);
            this.tb_precourse2.TabIndex = 76;
            // 
            // lb_precouse2
            // 
            this.lb_precouse2.AutoSize = true;
            this.lb_precouse2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precouse2.Location = new System.Drawing.Point(334, 123);
            this.lb_precouse2.Name = "lb_precouse2";
            this.lb_precouse2.Size = new System.Drawing.Size(85, 16);
            this.lb_precouse2.TabIndex = 75;
            this.lb_precouse2.Text = "PreCourse 2";
            // 
            // tb_course2
            // 
            this.tb_course2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_course2.Location = new System.Drawing.Point(425, 63);
            this.tb_course2.Name = "tb_course2";
            this.tb_course2.Size = new System.Drawing.Size(107, 22);
            this.tb_course2.TabIndex = 74;
            // 
            // tb_course1
            // 
            this.tb_course1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_course1.Location = new System.Drawing.Point(425, 35);
            this.tb_course1.Name = "tb_course1";
            this.tb_course1.Size = new System.Drawing.Size(107, 22);
            this.tb_course1.TabIndex = 73;
            // 
            // tb_precourse1
            // 
            this.tb_precourse1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precourse1.Location = new System.Drawing.Point(425, 91);
            this.tb_precourse1.Name = "tb_precourse1";
            this.tb_precourse1.Size = new System.Drawing.Size(107, 22);
            this.tb_precourse1.TabIndex = 72;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(334, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 71;
            this.label4.Text = "PreCourse 1";
            // 
            // lb_course2
            // 
            this.lb_course2.AutoSize = true;
            this.lb_course2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_course2.Location = new System.Drawing.Point(334, 65);
            this.lb_course2.Name = "lb_course2";
            this.lb_course2.Size = new System.Drawing.Size(64, 16);
            this.lb_course2.TabIndex = 70;
            this.lb_course2.Text = "Course 2";
            // 
            // lb_course1
            // 
            this.lb_course1.AutoSize = true;
            this.lb_course1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_course1.Location = new System.Drawing.Point(334, 34);
            this.lb_course1.Name = "lb_course1";
            this.lb_course1.Size = new System.Drawing.Size(64, 16);
            this.lb_course1.TabIndex = 69;
            this.lb_course1.Text = "Course 1";
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(457, 186);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(91, 23);
            this.bt_logout.TabIndex = 78;
            this.bt_logout.Text = "Log Out";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(328, 186);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(91, 23);
            this.bt_edit.TabIndex = 77;
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
            this.Cousre1,
            this.Course2,
            this.PreCourse1,
            this.PreCourse2});
            this.dataGridView1.Location = new System.Drawing.Point(55, 237);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(599, 201);
            this.dataGridView1.TabIndex = 79;
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
            // Cousre1
            // 
            this.Cousre1.HeaderText = "Course 1";
            this.Cousre1.Name = "Cousre1";
            this.Cousre1.ReadOnly = true;
            // 
            // Course2
            // 
            this.Course2.HeaderText = "Course 2";
            this.Course2.Name = "Course2";
            this.Course2.ReadOnly = true;
            // 
            // PreCourse1
            // 
            this.PreCourse1.HeaderText = "PreCourse 1";
            this.PreCourse1.Name = "PreCourse1";
            this.PreCourse1.ReadOnly = true;
            // 
            // PreCourse2
            // 
            this.PreCourse2.HeaderText = "PreCourse 2";
            this.PreCourse2.Name = "PreCourse2";
            this.PreCourse2.ReadOnly = true;
            // 
            // Form_student
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.tb_precourse2);
            this.Controls.Add(this.lb_precouse2);
            this.Controls.Add(this.tb_course2);
            this.Controls.Add(this.tb_course1);
            this.Controls.Add(this.tb_precourse1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_course2);
            this.Controls.Add(this.lb_course1);
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
            this.Name = "Form_student";
            this.Text = "Form_student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

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
        private System.Windows.Forms.TextBox tb_precourse2;
        private System.Windows.Forms.Label lb_precouse2;
        private System.Windows.Forms.TextBox tb_course2;
        private System.Windows.Forms.TextBox tb_course1;
        private System.Windows.Forms.TextBox tb_precourse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_course2;
        private System.Windows.Forms.Label lb_course1;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cousre1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Course2;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreCourse1;
        private System.Windows.Forms.DataGridViewTextBoxColumn PreCourse2;
    }
}