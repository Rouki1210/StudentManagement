namespace StudentManagement
{
    partial class Form_edit
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.bt_sumbit = new System.Windows.Forms.Button();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.lb_email = new System.Windows.Forms.Label();
            this.lb_role = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_id = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_phone
            // 
            this.tb_phone.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_phone.Location = new System.Drawing.Point(150, 143);
            this.tb_phone.Name = "tb_phone";
            this.tb_phone.Size = new System.Drawing.Size(164, 22);
            this.tb_phone.TabIndex = 32;
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(48, 145);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(58, 20);
            this.lb_phone.TabIndex = 31;
            this.lb_phone.Text = "Phone";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(150, 171);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 30;
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(239, 217);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(75, 23);
            this.bt_cancel.TabIndex = 29;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            // 
            // bt_sumbit
            // 
            this.bt_sumbit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.bt_sumbit.Location = new System.Drawing.Point(150, 217);
            this.bt_sumbit.Name = "bt_sumbit";
            this.bt_sumbit.Size = new System.Drawing.Size(75, 23);
            this.bt_sumbit.TabIndex = 28;
            this.bt_sumbit.Text = "Submit";
            this.bt_sumbit.UseVisualStyleBackColor = true;
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(150, 85);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(164, 22);
            this.tb_name.TabIndex = 27;
            // 
            // tb_id
            // 
            this.tb_id.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_id.Location = new System.Drawing.Point(150, 54);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(164, 22);
            this.tb_id.TabIndex = 26;
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(150, 115);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(164, 22);
            this.tb_email.TabIndex = 25;
            // 
            // lb_email
            // 
            this.lb_email.AutoSize = true;
            this.lb_email.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_email.Location = new System.Drawing.Point(48, 117);
            this.lb_email.Name = "lb_email";
            this.lb_email.Size = new System.Drawing.Size(54, 20);
            this.lb_email.TabIndex = 24;
            this.lb_email.Text = "Email";
            // 
            // lb_role
            // 
            this.lb_role.AutoSize = true;
            this.lb_role.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_role.Location = new System.Drawing.Point(48, 172);
            this.lb_role.Name = "lb_role";
            this.lb_role.Size = new System.Drawing.Size(45, 20);
            this.lb_role.TabIndex = 23;
            this.lb_role.Text = "Role";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(48, 87);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(85, 20);
            this.lb_name.TabIndex = 22;
            this.lb_name.Text = "FullName";
            // 
            // lb_id
            // 
            this.lb_id.AutoSize = true;
            this.lb_id.Font = new System.Drawing.Font("Mongolian Baiti", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_id.Location = new System.Drawing.Point(48, 56);
            this.lb_id.Name = "lb_id";
            this.lb_id.Size = new System.Drawing.Size(25, 20);
            this.lb_id.TabIndex = 21;
            this.lb_id.Text = "Id";
            // 
            // Form_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 278);
            this.Controls.Add(this.tb_phone);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_sumbit);
            this.Controls.Add(this.tb_name);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.tb_email);
            this.Controls.Add(this.lb_email);
            this.Controls.Add(this.lb_role);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_id);
            this.Name = "Form_edit";
            this.Text = "Form_edit";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_phone;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Button bt_sumbit;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.TextBox tb_id;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.Label lb_email;
        private System.Windows.Forms.Label lb_role;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_id;
    }
}