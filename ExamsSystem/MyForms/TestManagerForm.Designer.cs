namespace ExamsSystem.MyForms
{
    partial class TestManagerForm
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
            this.btn_search = new System.Windows.Forms.Button();
            this.txt_time_open = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.data_tests_list = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_create_test = new System.Windows.Forms.Button();
            this.btn_test_detail = new System.Windows.Forms.Button();
            this.cb_subjects = new System.Windows.Forms.ComboBox();
            this.btn_clearsearh = new System.Windows.Forms.Button();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_testid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_test_print = new System.Windows.Forms.Button();
            this.txt_openstate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_examid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_openstate = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_tests_list)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(601, 100);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 33);
            this.btn_search.TabIndex = 34;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // txt_time_open
            // 
            this.txt_time_open.Enabled = false;
            this.txt_time_open.Location = new System.Drawing.Point(26, 200);
            this.txt_time_open.Name = "txt_time_open";
            this.txt_time_open.Size = new System.Drawing.Size(282, 20);
            this.txt_time_open.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Môn học:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // data_tests_list
            // 
            this.data_tests_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_tests_list.BackgroundColor = System.Drawing.Color.White;
            this.data_tests_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_tests_list.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data_tests_list.Location = new System.Drawing.Point(5, 142);
            this.data_tests_list.Name = "data_tests_list";
            this.data_tests_list.RowHeadersVisible = false;
            this.data_tests_list.Size = new System.Drawing.Size(768, 390);
            this.data_tests_list.TabIndex = 33;
            this.data_tests_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_tests_list_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(23, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(102, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Thời gian mở";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(23, 133);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 15;
            this.label8.Text = "Môn học";
            // 
            // btn_create_test
            // 
            this.btn_create_test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_create_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_test.ForeColor = System.Drawing.Color.White;
            this.btn_create_test.Location = new System.Drawing.Point(26, 354);
            this.btn_create_test.Name = "btn_create_test";
            this.btn_create_test.Size = new System.Drawing.Size(282, 32);
            this.btn_create_test.TabIndex = 13;
            this.btn_create_test.Tag = "TeacherRegister";
            this.btn_create_test.Text = "Tạo bài thi";
            this.btn_create_test.UseVisualStyleBackColor = false;
            this.btn_create_test.Click += new System.EventHandler(this.btn_create_test_Click);
            // 
            // btn_test_detail
            // 
            this.btn_test_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_test_detail.Enabled = false;
            this.btn_test_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_test_detail.ForeColor = System.Drawing.Color.White;
            this.btn_test_detail.Location = new System.Drawing.Point(26, 316);
            this.btn_test_detail.Name = "btn_test_detail";
            this.btn_test_detail.Size = new System.Drawing.Size(282, 32);
            this.btn_test_detail.TabIndex = 11;
            this.btn_test_detail.Text = "Chi tiết bài thi";
            this.btn_test_detail.UseVisualStyleBackColor = false;
            this.btn_test_detail.Click += new System.EventHandler(this.btn_test_detail_Click);
            // 
            // cb_subjects
            // 
            this.cb_subjects.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_subjects.FormattingEnabled = true;
            this.cb_subjects.Items.AddRange(new object[] {
            "Tất cả",
            "Giáo dục công dân",
            "Lịch sử",
            "Địa lý"});
            this.cb_subjects.Location = new System.Drawing.Point(79, 107);
            this.cb_subjects.Name = "cb_subjects";
            this.cb_subjects.Size = new System.Drawing.Size(165, 21);
            this.cb_subjects.TabIndex = 38;
            // 
            // btn_clearsearh
            // 
            this.btn_clearsearh.BackColor = System.Drawing.Color.Gray;
            this.btn_clearsearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearsearh.ForeColor = System.Drawing.Color.White;
            this.btn_clearsearh.Location = new System.Drawing.Point(690, 100);
            this.btn_clearsearh.Name = "btn_clearsearh";
            this.btn_clearsearh.Size = new System.Drawing.Size(83, 33);
            this.btn_clearsearh.TabIndex = 35;
            this.btn_clearsearh.Text = "Làm mới";
            this.btn_clearsearh.UseVisualStyleBackColor = false;
            this.btn_clearsearh.Click += new System.EventHandler(this.btn_clearsearh_Click);
            // 
            // txt_subject
            // 
            this.txt_subject.Enabled = false;
            this.txt_subject.Location = new System.Drawing.Point(26, 153);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(282, 20);
            this.txt_subject.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(23, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã bài thi";
            // 
            // txt_testid
            // 
            this.txt_testid.Enabled = false;
            this.txt_testid.Location = new System.Drawing.Point(26, 59);
            this.txt_testid.Name = "txt_testid";
            this.txt_testid.Size = new System.Drawing.Size(282, 20);
            this.txt_testid.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thông tin bài thi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_test_print);
            this.panel1.Controls.Add(this.txt_openstate);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txt_time_open);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_subject);
            this.panel1.Controls.Add(this.btn_create_test);
            this.panel1.Controls.Add(this.btn_test_detail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_examid);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_testid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(779, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 432);
            this.panel1.TabIndex = 32;
            // 
            // btn_test_print
            // 
            this.btn_test_print.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_test_print.Enabled = false;
            this.btn_test_print.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_test_print.ForeColor = System.Drawing.Color.White;
            this.btn_test_print.Location = new System.Drawing.Point(26, 392);
            this.btn_test_print.Name = "btn_test_print";
            this.btn_test_print.Size = new System.Drawing.Size(282, 32);
            this.btn_test_print.TabIndex = 20;
            this.btn_test_print.Text = "In bài thi";
            this.btn_test_print.UseVisualStyleBackColor = false;
            this.btn_test_print.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_openstate
            // 
            this.txt_openstate.Enabled = false;
            this.txt_openstate.Location = new System.Drawing.Point(26, 247);
            this.txt_openstate.Name = "txt_openstate";
            this.txt_openstate.Size = new System.Drawing.Size(282, 20);
            this.txt_openstate.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(23, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 17);
            this.label6.TabIndex = 18;
            this.label6.Text = "Trạng thái mở";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Mã đề thi";
            // 
            // txt_examid
            // 
            this.txt_examid.Enabled = false;
            this.txt_examid.Location = new System.Drawing.Point(26, 106);
            this.txt_examid.Name = "txt_examid";
            this.txt_examid.Size = new System.Drawing.Size(282, 20);
            this.txt_examid.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1164, 48);
            this.label2.TabIndex = 31;
            this.label2.Text = "Quản lý bài thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cb_openstate
            // 
            this.cb_openstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_openstate.FormattingEnabled = true;
            this.cb_openstate.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa mở",
            "Mở"});
            this.cb_openstate.Location = new System.Drawing.Point(362, 107);
            this.cb_openstate.Name = "cb_openstate";
            this.cb_openstate.Size = new System.Drawing.Size(140, 21);
            this.cb_openstate.TabIndex = 40;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 108);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 41;
            this.label7.Text = "Trạng thái mở:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // TestManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 536);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_openstate);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data_tests_list);
            this.Controls.Add(this.cb_subjects);
            this.Controls.Add(this.btn_clearsearh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1180, 575);
            this.MinimumSize = new System.Drawing.Size(1180, 575);
            this.Name = "TestManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý bài thi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.TestManagerForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_tests_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.TextBox txt_time_open;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView data_tests_list;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_create_test;
        private System.Windows.Forms.Button btn_test_detail;
        private System.Windows.Forms.ComboBox cb_subjects;
        private System.Windows.Forms.Button btn_clearsearh;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_testid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_examid;
        private System.Windows.Forms.TextBox txt_openstate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_openstate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_test_print;
    }
}