namespace ExamsSystem.MyForms.Admin
{
    partial class AccountManagerForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_teacher_register = new System.Windows.Forms.Button();
            this.btn_account_detail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_rolename = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.data_students_list = new System.Windows.Forms.DataGridView();
            this.btn_clearsearh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.cb_search_rolename = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txt_search_username = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_students_list)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1001, 48);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quản lý tài khoản";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_teacher_register);
            this.panel1.Controls.Add(this.btn_account_detail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_rolename);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(661, 80);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 358);
            this.panel1.TabIndex = 4;
            // 
            // btn_teacher_register
            // 
            this.btn_teacher_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_teacher_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_teacher_register.ForeColor = System.Drawing.Color.White;
            this.btn_teacher_register.Location = new System.Drawing.Point(26, 323);
            this.btn_teacher_register.Name = "btn_teacher_register";
            this.btn_teacher_register.Size = new System.Drawing.Size(282, 32);
            this.btn_teacher_register.TabIndex = 13;
            this.btn_teacher_register.Tag = "TeacherRegister";
            this.btn_teacher_register.Text = "Đăng ký tài khoản";
            this.btn_teacher_register.UseVisualStyleBackColor = false;
            this.btn_teacher_register.Click += new System.EventHandler(this.register_Click);
            // 
            // btn_account_detail
            // 
            this.btn_account_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_account_detail.Enabled = false;
            this.btn_account_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_account_detail.ForeColor = System.Drawing.Color.White;
            this.btn_account_detail.Location = new System.Drawing.Point(26, 153);
            this.btn_account_detail.Name = "btn_account_detail";
            this.btn_account_detail.Size = new System.Drawing.Size(282, 32);
            this.btn_account_detail.TabIndex = 11;
            this.btn_account_detail.Text = "Chi tiết tài khoản";
            this.btn_account_detail.UseVisualStyleBackColor = false;
            this.btn_account_detail.Click += new System.EventHandler(this.btn_account_detail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(23, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(127, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Quyền tài khoản";
            // 
            // txt_rolename
            // 
            this.txt_rolename.Enabled = false;
            this.txt_rolename.Location = new System.Drawing.Point(26, 118);
            this.txt_rolename.Name = "txt_rolename";
            this.txt_rolename.Size = new System.Drawing.Size(282, 20);
            this.txt_rolename.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(23, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tài khoản";
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Location = new System.Drawing.Point(26, 71);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(282, 20);
            this.txt_username.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông tin tài khoản";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // data_students_list
            // 
            this.data_students_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_students_list.BackgroundColor = System.Drawing.Color.White;
            this.data_students_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_students_list.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data_students_list.Location = new System.Drawing.Point(5, 127);
            this.data_students_list.Name = "data_students_list";
            this.data_students_list.Size = new System.Drawing.Size(639, 311);
            this.data_students_list.TabIndex = 11;
            this.data_students_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_students_list_CellClick);
            // 
            // btn_clearsearh
            // 
            this.btn_clearsearh.BackColor = System.Drawing.Color.Gray;
            this.btn_clearsearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearsearh.ForeColor = System.Drawing.Color.White;
            this.btn_clearsearh.Location = new System.Drawing.Point(561, 90);
            this.btn_clearsearh.Name = "btn_clearsearh";
            this.btn_clearsearh.Size = new System.Drawing.Size(83, 33);
            this.btn_clearsearh.TabIndex = 13;
            this.btn_clearsearh.Text = "Làm mới";
            this.btn_clearsearh.UseVisualStyleBackColor = false;
            this.btn_clearsearh.Click += new System.EventHandler(this.btn_clearsearh_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(472, 90);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 33);
            this.btn_search.TabIndex = 12;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // cb_search_rolename
            // 
            this.cb_search_rolename.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_search_rolename.FormattingEnabled = true;
            this.cb_search_rolename.Items.AddRange(new object[] {
            "Tất cả",
            "AM",
            "HV",
            "GV",
            "HS"});
            this.cb_search_rolename.Location = new System.Drawing.Point(292, 100);
            this.cb_search_rolename.Name = "cb_search_rolename";
            this.cb_search_rolename.Size = new System.Drawing.Size(124, 21);
            this.cb_search_rolename.TabIndex = 15;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(241, 101);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Quyền:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_search_username
            // 
            this.txt_search_username.Location = new System.Drawing.Point(90, 101);
            this.txt_search_username.Name = "txt_search_username";
            this.txt_search_username.Size = new System.Drawing.Size(127, 20);
            this.txt_search_username.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(2, 100);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 19;
            this.label5.Text = "Tên tài khoản:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AccountManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1001, 450);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_search_username);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cb_search_rolename);
            this.Controls.Add(this.btn_clearsearh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.data_students_list);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1017, 489);
            this.MinimumSize = new System.Drawing.Size(1017, 489);
            this.Name = "AccountManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AccountManager";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.AccountManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.AccountManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_students_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_rolename;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Button btn_account_detail;
        private System.Windows.Forms.DataGridView data_students_list;
        private System.Windows.Forms.Button btn_clearsearh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ComboBox cb_search_rolename;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txt_search_username;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_teacher_register;
    }
}