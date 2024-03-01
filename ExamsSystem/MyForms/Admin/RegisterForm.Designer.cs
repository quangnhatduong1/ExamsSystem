namespace ExamsSystem.MyForms.Admin
{
    partial class RegisterForm
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.group_subjects = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.cb_classname = new System.Windows.Forms.ComboBox();
            this.lb_classname = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_phonenumber = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datetime_birthday = new System.Windows.Forms.DateTimePicker();
            this.groupbox_rolename = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_fullname = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            this.group_subjects.SuspendLayout();
            this.groupbox_rolename.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.group_subjects);
            this.panel2.Controls.Add(this.cb_classname);
            this.panel2.Controls.Add(this.lb_classname);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txt_phonenumber);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_email);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.datetime_birthday);
            this.panel2.Controls.Add(this.groupbox_rolename);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_register);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.txt_fullname);
            this.panel2.Controls.Add(this.txt_username);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(800, 505);
            this.panel2.TabIndex = 5;
            // 
            // group_subjects
            // 
            this.group_subjects.Controls.Add(this.checkBox3);
            this.group_subjects.Controls.Add(this.checkBox2);
            this.group_subjects.Controls.Add(this.checkBox1);
            this.group_subjects.Location = new System.Drawing.Point(139, 259);
            this.group_subjects.Name = "group_subjects";
            this.group_subjects.Size = new System.Drawing.Size(546, 69);
            this.group_subjects.TabIndex = 20;
            this.group_subjects.TabStop = false;
            this.group_subjects.Text = "Môn học giảng dạy";
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(157, 29);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(117, 17);
            this.checkBox3.TabIndex = 2;
            this.checkBox3.Tag = "1";
            this.checkBox3.Text = "Giáo dục công dân";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(86, 29);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(52, 17);
            this.checkBox2.TabIndex = 1;
            this.checkBox2.Tag = "3";
            this.checkBox2.Text = "Địa lý";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(6, 29);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(60, 17);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "2";
            this.checkBox1.Text = "Lịch sử";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // cb_classname
            // 
            this.cb_classname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_classname.FormattingEnabled = true;
            this.cb_classname.Items.AddRange(new object[] {
            "LT-1",
            "LT-2",
            "LT-3",
            "LT-4",
            "LT-5"});
            this.cb_classname.Location = new System.Drawing.Point(432, 212);
            this.cb_classname.Name = "cb_classname";
            this.cb_classname.Size = new System.Drawing.Size(253, 21);
            this.cb_classname.TabIndex = 19;
            // 
            // lb_classname
            // 
            this.lb_classname.AutoSize = true;
            this.lb_classname.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_classname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lb_classname.Location = new System.Drawing.Point(429, 194);
            this.lb_classname.Name = "lb_classname";
            this.lb_classname.Size = new System.Drawing.Size(66, 17);
            this.lb_classname.TabIndex = 18;
            this.lb_classname.Text = "Lớp học";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(429, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 17);
            this.label3.TabIndex = 13;
            this.label3.Text = "Số điện thoại";
            // 
            // txt_phonenumber
            // 
            this.txt_phonenumber.Location = new System.Drawing.Point(432, 157);
            this.txt_phonenumber.Name = "txt_phonenumber";
            this.txt_phonenumber.Size = new System.Drawing.Size(253, 20);
            this.txt_phonenumber.TabIndex = 12;
            this.txt_phonenumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_phonenumber_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(429, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 17);
            this.label2.TabIndex = 11;
            this.label2.Text = "Địa chỉ Email";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(432, 105);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(253, 20);
            this.txt_email.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(139, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Ngày sinh";
            // 
            // datetime_birthday
            // 
            this.datetime_birthday.CustomFormat = "dd/MM/yyyy";
            this.datetime_birthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datetime_birthday.Location = new System.Drawing.Point(139, 213);
            this.datetime_birthday.MaxDate = new System.DateTime(2021, 4, 6, 0, 0, 0, 0);
            this.datetime_birthday.MinDate = new System.DateTime(1960, 1, 1, 0, 0, 0, 0);
            this.datetime_birthday.Name = "datetime_birthday";
            this.datetime_birthday.Size = new System.Drawing.Size(253, 20);
            this.datetime_birthday.TabIndex = 8;
            this.datetime_birthday.Value = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // groupbox_rolename
            // 
            this.groupbox_rolename.Controls.Add(this.radioButton3);
            this.groupbox_rolename.Controls.Add(this.radioButton2);
            this.groupbox_rolename.Controls.Add(this.radioButton1);
            this.groupbox_rolename.Location = new System.Drawing.Point(142, 343);
            this.groupbox_rolename.Name = "groupbox_rolename";
            this.groupbox_rolename.Size = new System.Drawing.Size(543, 92);
            this.groupbox_rolename.TabIndex = 7;
            this.groupbox_rolename.TabStop = false;
            this.groupbox_rolename.Text = "Quyền tài khoản";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(5, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(92, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "HV";
            this.radioButton3.Text = "Phòng học vụ";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.group_rolename_click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(6, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(70, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "GV";
            this.radioButton2.Text = "Giáo viên";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.group_rolename_click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(67, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "HS";
            this.radioButton1.Text = "Học sinh";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.group_rolename_click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(138, 137);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 17);
            this.label6.TabIndex = 6;
            this.label6.Text = "Họ và tên";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label7.Location = new System.Drawing.Point(136, 85);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 17);
            this.label7.TabIndex = 5;
            this.label7.Text = "Tài khoản";
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(234, 461);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(363, 32);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Đăng ký";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(3, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(794, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Đăng ký tài khoản cho người dùng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_fullname
            // 
            this.txt_fullname.Location = new System.Drawing.Point(139, 157);
            this.txt_fullname.Name = "txt_fullname";
            this.txt_fullname.Size = new System.Drawing.Size(253, 20);
            this.txt_fullname.TabIndex = 1;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(139, 105);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(253, 20);
            this.txt_username.TabIndex = 0;
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 505);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 544);
            this.MinimumSize = new System.Drawing.Size(816, 544);
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegisterForm_FormClosed);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.group_subjects.ResumeLayout(false);
            this.group_subjects.PerformLayout();
            this.groupbox_rolename.ResumeLayout(false);
            this.groupbox_rolename.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupbox_rolename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_fullname;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_phonenumber;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datetime_birthday;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cb_classname;
        private System.Windows.Forms.Label lb_classname;
        private System.Windows.Forms.GroupBox group_subjects;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}