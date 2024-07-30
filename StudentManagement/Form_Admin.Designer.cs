namespace StudentManagement
{
    partial class Form_Admin
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lb_val_stu = new System.Windows.Forms.Label();
            this.lb_student = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.lb_teacher = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.lb_admin = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Role = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_delete = new System.Windows.Forms.Button();
            this.tb_phone = new System.Windows.Forms.TextBox();
            this.lb_phone = new System.Windows.Forms.Label();
            this.cb_role = new System.Windows.Forms.ComboBox();
            this.bt_logout = new System.Windows.Forms.Button();
            this.bt_add = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.pl_stu = new System.Windows.Forms.Panel();
            this.pl_admin = new System.Windows.Forms.Panel();
            this.cb_employ = new System.Windows.Forms.ComboBox();
            this.tb_hours = new System.Windows.Forms.TextBox();
            this.tb_adsalary = new System.Windows.Forms.TextBox();
            this.lb_adsalary = new System.Windows.Forms.Label();
            this.lb_hours = new System.Windows.Forms.Label();
            this.lb_employ = new System.Windows.Forms.Label();
            this.tb_precourse2 = new System.Windows.Forms.TextBox();
            this.lb_precouse2 = new System.Windows.Forms.Label();
            this.tb_course2 = new System.Windows.Forms.TextBox();
            this.tb_course1 = new System.Windows.Forms.TextBox();
            this.tb_precourse1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_course2 = new System.Windows.Forms.Label();
            this.lb_course1 = new System.Windows.Forms.Label();
            this.pl_teacher = new System.Windows.Forms.Panel();
            this.tb_classname = new System.Windows.Forms.TextBox();
            this.lb_classname = new System.Windows.Forms.Label();
            this.tb_subject1 = new System.Windows.Forms.TextBox();
            this.tb_salary = new System.Windows.Forms.TextBox();
            this.tb_subject2 = new System.Windows.Forms.TextBox();
            this.lb_subject2 = new System.Windows.Forms.Label();
            this.lb_subject1 = new System.Windows.Forms.Label();
            this.lb_salary = new System.Windows.Forms.Label();
            this.studentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.pl_stu.SuspendLayout();
            this.pl_admin.SuspendLayout();
            this.pl_teacher.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(200, 629);
            this.panel1.TabIndex = 0;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei Light", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome Back,";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.lb_val_stu);
            this.panel2.Controls.Add(this.lb_student);
            this.panel2.Location = new System.Drawing.Point(237, 112);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(150, 79);
            this.panel2.TabIndex = 2;
            this.panel2.Click += new System.EventHandler(this.panel2_Paint);
            // 
            // lb_val_stu
            // 
            this.lb_val_stu.AutoSize = true;
            this.lb_val_stu.Location = new System.Drawing.Point(16, 45);
            this.lb_val_stu.Name = "lb_val_stu";
            this.lb_val_stu.Size = new System.Drawing.Size(35, 13);
            this.lb_val_stu.TabIndex = 1;
            this.lb_val_stu.Text = "label3";
            // 
            // lb_student
            // 
            this.lb_student.AutoSize = true;
            this.lb_student.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_student.Location = new System.Drawing.Point(15, 13);
            this.lb_student.Name = "lb_student";
            this.lb_student.Size = new System.Drawing.Size(73, 20);
            this.lb_student.TabIndex = 0;
            this.lb_student.Text = "Student";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.lb_teacher);
            this.panel3.Location = new System.Drawing.Point(460, 112);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 79);
            this.panel3.TabIndex = 3;
            this.panel3.Click += new System.EventHandler(this.panel3_Paint);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "label6";
            // 
            // lb_teacher
            // 
            this.lb_teacher.AutoSize = true;
            this.lb_teacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_teacher.Location = new System.Drawing.Point(14, 13);
            this.lb_teacher.Name = "lb_teacher";
            this.lb_teacher.Size = new System.Drawing.Size(74, 20);
            this.lb_teacher.TabIndex = 2;
            this.lb_teacher.Text = "Teacher";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.lb_admin);
            this.panel4.Location = new System.Drawing.Point(686, 112);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 79);
            this.panel4.TabIndex = 3;
            this.panel4.Click += new System.EventHandler(this.panel4_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 45);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "label7";
            // 
            // lb_admin
            // 
            this.lb_admin.AutoSize = true;
            this.lb_admin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_admin.Location = new System.Drawing.Point(12, 13);
            this.lb_admin.Name = "lb_admin";
            this.lb_admin.Size = new System.Drawing.Size(59, 20);
            this.lb_admin.TabIndex = 3;
            this.lb_admin.Text = "Admin";
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
            this.Role});
            this.dataGridView1.Location = new System.Drawing.Point(237, 407);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(599, 201);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
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
            // Role
            // 
            this.Role.HeaderText = "Role";
            this.Role.Name = "Role";
            this.Role.ReadOnly = true;
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(503, 372);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(91, 23);
            this.bt_edit.TabIndex = 6;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            this.bt_edit.Click += new System.EventHandler(this.bt_edit_Click);
            // 
            // bt_delete
            // 
            this.bt_delete.Location = new System.Drawing.Point(369, 372);
            this.bt_delete.Name = "bt_delete";
            this.bt_delete.Size = new System.Drawing.Size(91, 23);
            this.bt_delete.TabIndex = 7;
            this.bt_delete.Text = "Delete";
            this.bt_delete.UseVisualStyleBackColor = true;
            this.bt_delete.Click += new System.EventHandler(this.bt_delete_Click);
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(289, 308);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(149, 22);
            this.tb_phone.TabIndex = 44;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(234, 309);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(47, 16);
            this.lb_phone.TabIndex = 43;
            this.lb_phone.Text = "Phone";
            // 
            // cb_role
            // 
            this.cb_role.FormattingEnabled = true;
            this.cb_role.Items.AddRange(new object[] {
            "Admin",
            "Student",
            "Teacher"});
            this.cb_role.Location = new System.Drawing.Point(289, 336);
            this.cb_role.Name = "cb_role";
            this.cb_role.Size = new System.Drawing.Size(107, 21);
            this.cb_role.TabIndex = 42;
            // 
            // bt_logout
            // 
            this.bt_logout.Location = new System.Drawing.Point(632, 372);
            this.bt_logout.Name = "bt_logout";
            this.bt_logout.Size = new System.Drawing.Size(91, 23);
            this.bt_logout.TabIndex = 41;
            this.bt_logout.Text = "Log Out";
            this.bt_logout.UseVisualStyleBackColor = true;
            this.bt_logout.Click += new System.EventHandler(this.bt_logout_Click);
            // 
            // bt_add
            // 
            this.bt_add.Location = new System.Drawing.Point(237, 372);
            this.bt_add.Name = "bt_add";
            this.bt_add.Size = new System.Drawing.Size(91, 23);
            this.bt_add.TabIndex = 40;
            this.bt_add.Text = "Add";
            this.bt_add.UseVisualStyleBackColor = true;
            this.bt_add.Click += new System.EventHandler(this.bt_add_Click);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(289, 250);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(149, 22);
            this.tb_name.TabIndex = 39;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(289, 219);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(107, 22);
            this.tb_id.TabIndex = 38;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(289, 280);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(149, 22);
            this.tb_email.TabIndex = 37;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(234, 281);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(44, 16);
            this.lb_email.TabIndex = 36;
            this.lb_email.Text = "Email";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.Location = new System.Drawing.Point(234, 336);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(37, 16);
            this.lb_role.TabIndex = 35;
            this.lb_role.Text = "Role";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(234, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 34;
            this.label2.Text = "Name";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(234, 220);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(20, 16);
            this.lb_id.TabIndex = 33;
            this.lb_id.Text = "Id";
            // 
            // pl_stu
            // 
            this.pl_stu.Controls.Add(this.tb_precourse2);
            this.pl_stu.Controls.Add(this.lb_precouse2);
            this.pl_stu.Controls.Add(this.tb_course2);
            this.pl_stu.Controls.Add(this.tb_course1);
            this.pl_stu.Controls.Add(this.tb_precourse1);
            this.pl_stu.Controls.Add(this.label4);
            this.pl_stu.Controls.Add(this.lb_course2);
            this.pl_stu.Controls.Add(this.lb_course1);
            this.pl_stu.Location = new System.Drawing.Point(460, 210);
            this.pl_stu.Name = "pl_stu";
            this.pl_stu.Size = new System.Drawing.Size(231, 147);
            this.pl_stu.TabIndex = 45;
            this.pl_stu.Visible = false;
            // 
            // pl_admin
            // 
            this.pl_admin.Controls.Add(this.cb_employ);
            this.pl_admin.Controls.Add(this.tb_hours);
            this.pl_admin.Controls.Add(this.tb_adsalary);
            this.pl_admin.Controls.Add(this.lb_adsalary);
            this.pl_admin.Controls.Add(this.lb_hours);
            this.pl_admin.Controls.Add(this.lb_employ);
            this.pl_admin.Location = new System.Drawing.Point(460, 210);
            this.pl_admin.Name = "pl_admin";
            this.pl_admin.Size = new System.Drawing.Size(231, 147);
            this.pl_admin.TabIndex = 56;
            // 
            // cb_employ
            // 
            this.cb_employ.AutoCompleteCustomSource.AddRange(new string[] {
            "Full-time",
            "Part-time"});
            this.cb_employ.FormattingEnabled = true;
            this.cb_employ.Items.AddRange(new object[] {
            "Full-time",
            "Part-time"});
            this.cb_employ.Location = new System.Drawing.Point(120, 85);
            this.cb_employ.Name = "cb_employ";
            this.cb_employ.Size = new System.Drawing.Size(95, 21);
            this.cb_employ.TabIndex = 52;
            // 
            // tb_hours
            // 
            this.tb_hours.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_hours.Location = new System.Drawing.Point(120, 25);
            this.tb_hours.Name = "tb_hours";
            this.tb_hours.Size = new System.Drawing.Size(92, 22);
            this.tb_hours.TabIndex = 51;
            // 
            // tb_adsalary
            // 
            this.tb_adsalary.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_adsalary.Location = new System.Drawing.Point(120, 56);
            this.tb_adsalary.Name = "tb_adsalary";
            this.tb_adsalary.Size = new System.Drawing.Size(95, 22);
            this.tb_adsalary.TabIndex = 49;
            // 
            // lb_adsalary
            // 
            this.lb_adsalary.AutoSize = true;
            this.lb_adsalary.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_adsalary.Location = new System.Drawing.Point(8, 57);
            this.lb_adsalary.Name = "lb_adsalary";
            this.lb_adsalary.Size = new System.Drawing.Size(47, 16);
            this.lb_adsalary.TabIndex = 48;
            this.lb_adsalary.Text = "Salary";
            // 
            // lb_hours
            // 
            this.lb_hours.AutoSize = true;
            this.lb_hours.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hours.Location = new System.Drawing.Point(8, 26);
            this.lb_hours.Name = "lb_hours";
            this.lb_hours.Size = new System.Drawing.Size(106, 16);
            this.lb_hours.TabIndex = 46;
            this.lb_hours.Text = "Working Hours";
            // 
            // lb_employ
            // 
            this.lb_employ.AutoSize = true;
            this.lb_employ.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_employ.Location = new System.Drawing.Point(8, 86);
            this.lb_employ.Name = "lb_employ";
            this.lb_employ.Size = new System.Drawing.Size(57, 16);
            this.lb_employ.TabIndex = 45;
            this.lb_employ.Text = "Employ";
            // 
            // tb_precourse2
            // 
            this.tb_precourse2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precourse2.Location = new System.Drawing.Point(106, 103);
            this.tb_precourse2.Name = "tb_precourse2";
            this.tb_precourse2.Size = new System.Drawing.Size(107, 22);
            this.tb_precourse2.TabIndex = 54;
            // 
            // lb_precouse2
            // 
            this.lb_precouse2.AutoSize = true;
            this.lb_precouse2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_precouse2.Location = new System.Drawing.Point(15, 104);
            this.lb_precouse2.Name = "lb_precouse2";
            this.lb_precouse2.Size = new System.Drawing.Size(85, 16);
            this.lb_precouse2.TabIndex = 53;
            this.lb_precouse2.Text = "PreCourse 2";
            // 
            // tb_course2
            // 
            this.tb_course2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_course2.Location = new System.Drawing.Point(106, 44);
            this.tb_course2.Name = "tb_course2";
            this.tb_course2.Size = new System.Drawing.Size(107, 22);
            this.tb_course2.TabIndex = 51;
            // 
            // tb_course1
            // 
            this.tb_course1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_course1.Location = new System.Drawing.Point(106, 16);
            this.tb_course1.Name = "tb_course1";
            this.tb_course1.Size = new System.Drawing.Size(107, 22);
            this.tb_course1.TabIndex = 50;
            // 
            // tb_precourse1
            // 
            this.tb_precourse1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_precourse1.Location = new System.Drawing.Point(106, 72);
            this.tb_precourse1.Name = "tb_precourse1";
            this.tb_precourse1.Size = new System.Drawing.Size(107, 22);
            this.tb_precourse1.TabIndex = 49;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 16);
            this.label4.TabIndex = 48;
            this.label4.Text = "PreCourse 1";
            // 
            // lb_course2
            // 
            this.lb_course2.AutoSize = true;
            this.lb_course2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_course2.Location = new System.Drawing.Point(15, 46);
            this.lb_course2.Name = "lb_course2";
            this.lb_course2.Size = new System.Drawing.Size(64, 16);
            this.lb_course2.TabIndex = 46;
            this.lb_course2.Text = "Course 2";
            // 
            // lb_course1
            // 
            this.lb_course1.AutoSize = true;
            this.lb_course1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_course1.Location = new System.Drawing.Point(15, 15);
            this.lb_course1.Name = "lb_course1";
            this.lb_course1.Size = new System.Drawing.Size(64, 16);
            this.lb_course1.TabIndex = 45;
            this.lb_course1.Text = "Course 1";
            // 
            // pl_teacher
            // 
            this.pl_teacher.Controls.Add(this.tb_classname);
            this.pl_teacher.Controls.Add(this.lb_classname);
            this.pl_teacher.Controls.Add(this.tb_subject1);
            this.pl_teacher.Controls.Add(this.tb_salary);
            this.pl_teacher.Controls.Add(this.tb_subject2);
            this.pl_teacher.Controls.Add(this.lb_subject2);
            this.pl_teacher.Controls.Add(this.lb_subject1);
            this.pl_teacher.Controls.Add(this.lb_salary);
            this.pl_teacher.Location = new System.Drawing.Point(460, 210);
            this.pl_teacher.Name = "pl_teacher";
            this.pl_teacher.Size = new System.Drawing.Size(231, 147);
            this.pl_teacher.TabIndex = 55;
            this.pl_teacher.Visible = false;
            // 
            // tb_classname
            // 
            this.tb_classname.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_classname.Location = new System.Drawing.Point(106, 103);
            this.tb_classname.Name = "tb_classname";
            this.tb_classname.Size = new System.Drawing.Size(107, 22);
            this.tb_classname.TabIndex = 54;
            // 
            // lb_classname
            // 
            this.lb_classname.AutoSize = true;
            this.lb_classname.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_classname.Location = new System.Drawing.Point(15, 104);
            this.lb_classname.Name = "lb_classname";
            this.lb_classname.Size = new System.Drawing.Size(79, 16);
            this.lb_classname.TabIndex = 53;
            this.lb_classname.Text = "ClassName";
            // 
            // tb_subject1
            // 
            this.tb_subject1.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subject1.Location = new System.Drawing.Point(106, 22);
            this.tb_subject1.Name = "tb_subject1";
            this.tb_subject1.Size = new System.Drawing.Size(107, 22);
            this.tb_subject1.TabIndex = 51;
            // 
            // tb_salary
            // 
            this.tb_salary.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_salary.Location = new System.Drawing.Point(106, 77);
            this.tb_salary.Name = "tb_salary";
            this.tb_salary.Size = new System.Drawing.Size(107, 22);
            this.tb_salary.TabIndex = 50;
            // 
            // tb_subject2
            // 
            this.tb_subject2.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_subject2.Location = new System.Drawing.Point(106, 50);
            this.tb_subject2.Name = "tb_subject2";
            this.tb_subject2.Size = new System.Drawing.Size(107, 22);
            this.tb_subject2.TabIndex = 49;
            // 
            // lb_subject2
            // 
            this.lb_subject2.AutoSize = true;
            this.lb_subject2.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subject2.Location = new System.Drawing.Point(15, 56);
            this.lb_subject2.Name = "lb_subject2";
            this.lb_subject2.Size = new System.Drawing.Size(66, 16);
            this.lb_subject2.TabIndex = 48;
            this.lb_subject2.Text = "Subject 2";
            // 
            // lb_subject1
            // 
            this.lb_subject1.AutoSize = true;
            this.lb_subject1.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subject1.Location = new System.Drawing.Point(15, 28);
            this.lb_subject1.Name = "lb_subject1";
            this.lb_subject1.Size = new System.Drawing.Size(66, 16);
            this.lb_subject1.TabIndex = 46;
            this.lb_subject1.Text = "Subject 1";
            // 
            // lb_salary
            // 
            this.lb_salary.AutoSize = true;
            this.lb_salary.Font = new System.Drawing.Font("Mongolian Baiti", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_salary.Location = new System.Drawing.Point(15, 83);
            this.lb_salary.Name = "lb_salary";
            this.lb_salary.Size = new System.Drawing.Size(47, 16);
            this.lb_salary.TabIndex = 45;
            this.lb_salary.Text = "Salary";
            // 
            // studentBindingSource
            // 
            this.studentBindingSource.DataSource = typeof(StudentManagement.Student);
            // 
            // Form_Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1032, 633);
            this.Controls.Add(this.pl_admin);
            this.Controls.Add(this.pl_teacher);
            this.Controls.Add(this.pl_stu);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.cb_role);
            this.Controls.Add(this.bt_logout);
            this.Controls.Add(this.bt_add);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_id);
            this.Controls.Add(this.bt_delete);
            this.Controls.Add(this.bt_edit);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Name = "Form_Admin";
            this.Text = "Form_admin";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.pl_stu.ResumeLayout(false);
            this.pl_stu.PerformLayout();
            this.pl_admin.ResumeLayout(false);
            this.pl_admin.PerformLayout();
            this.pl_teacher.ResumeLayout(false);
            this.pl_teacher.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lb_val_stu;
        private System.Windows.Forms.Label lb_student;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lb_teacher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lb_admin;
        private System.Windows.Forms.BindingSource studentBindingSource;
        private System.Windows.Forms.Button bt_edit;
        private System.Windows.Forms.Button bt_delete;
        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.ComboBox cb_role;
        private System.Windows.Forms.Button bt_logout;
        private System.Windows.Forms.Button bt_add;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.DataGridViewTextBoxColumn Phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn Role;
        private System.Windows.Forms.Panel pl_stu;
        private System.Windows.Forms.TextBox tb_precourse2;
        private System.Windows.Forms.Label lb_precouse2;
        private System.Windows.Forms.TextBox tb_course2;
        private System.Windows.Forms.TextBox tb_course1;
        private System.Windows.Forms.TextBox tb_precourse1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_course2;
        private System.Windows.Forms.Label lb_course1;
        private System.Windows.Forms.Panel pl_teacher;
        private System.Windows.Forms.TextBox tb_classname;
        private System.Windows.Forms.Label lb_classname;
        private System.Windows.Forms.TextBox tb_subject1;
        private System.Windows.Forms.TextBox tb_salary;
        private System.Windows.Forms.TextBox tb_subject2;
        private System.Windows.Forms.Label lb_subject2;
        private System.Windows.Forms.Label lb_subject1;
        private System.Windows.Forms.Label lb_salary;
        private System.Windows.Forms.Panel pl_admin;
        private System.Windows.Forms.TextBox tb_hours;
        private System.Windows.Forms.TextBox tb_adsalary;
        private System.Windows.Forms.Label lb_adsalary;
        private System.Windows.Forms.Label lb_hours;
        private System.Windows.Forms.Label lb_employ;
        private System.Windows.Forms.ComboBox cb_employ;
    }
}