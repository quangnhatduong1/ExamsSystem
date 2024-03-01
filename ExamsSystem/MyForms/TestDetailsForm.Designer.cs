namespace ExamsSystem.MyForms
{
    partial class TestDetailsForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_delete_test = new System.Windows.Forms.Button();
            this.txt_testid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.checkbox_tested = new System.Windows.Forms.CheckBox();
            this.txt_examid = new System.Windows.Forms.TextBox();
            this.txt_questionscount = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_subjectname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_exam_details = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_search = new System.Windows.Forms.ComboBox();
            this.txt_search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_clearsearh = new System.Windows.Forms.Button();
            this.data_exams_list = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_openstate = new System.Windows.Forms.ComboBox();
            this.time_datestart = new System.Windows.Forms.DateTimePicker();
            this.btn_clear_test = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_save_test = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.data_students_tests = new System.Windows.Forms.DataGridView();
            this.label10 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_exams_list)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_students_tests)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1085, 552);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1077, 526);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chi tiết bài thi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btn_delete_test);
            this.panel2.Controls.Add(this.txt_testid);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.checkbox_tested);
            this.panel2.Controls.Add(this.txt_examid);
            this.panel2.Controls.Add(this.txt_questionscount);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.txt_subjectname);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.btn_exam_details);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.cb_search);
            this.panel2.Controls.Add(this.txt_search);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.btn_search);
            this.panel2.Controls.Add(this.btn_clearsearh);
            this.panel2.Controls.Add(this.data_exams_list);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cb_openstate);
            this.panel2.Controls.Add(this.time_datestart);
            this.panel2.Controls.Add(this.btn_clear_test);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_save_test);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1071, 520);
            this.panel2.TabIndex = 9;
            // 
            // btn_delete_test
            // 
            this.btn_delete_test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_delete_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_test.ForeColor = System.Drawing.Color.White;
            this.btn_delete_test.Location = new System.Drawing.Point(105, 483);
            this.btn_delete_test.Name = "btn_delete_test";
            this.btn_delete_test.Size = new System.Drawing.Size(200, 32);
            this.btn_delete_test.TabIndex = 60;
            this.btn_delete_test.Text = "Xóa";
            this.btn_delete_test.UseVisualStyleBackColor = false;
            this.btn_delete_test.Click += new System.EventHandler(this.btn_delete_test_Click);
            // 
            // txt_testid
            // 
            this.txt_testid.Enabled = false;
            this.txt_testid.Location = new System.Drawing.Point(105, 69);
            this.txt_testid.Name = "txt_testid";
            this.txt_testid.Size = new System.Drawing.Size(200, 20);
            this.txt_testid.TabIndex = 59;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(102, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(79, 17);
            this.label11.TabIndex = 58;
            this.label11.Text = "Mã bài thi";
            // 
            // checkbox_tested
            // 
            this.checkbox_tested.AutoSize = true;
            this.checkbox_tested.Enabled = false;
            this.checkbox_tested.Location = new System.Drawing.Point(105, 370);
            this.checkbox_tested.Name = "checkbox_tested";
            this.checkbox_tested.Size = new System.Drawing.Size(125, 17);
            this.checkbox_tested.TabIndex = 57;
            this.checkbox_tested.Text = "Đã được đưa vào thi";
            this.checkbox_tested.UseVisualStyleBackColor = true;
            // 
            // txt_examid
            // 
            this.txt_examid.Enabled = false;
            this.txt_examid.Location = new System.Drawing.Point(105, 221);
            this.txt_examid.Name = "txt_examid";
            this.txt_examid.Size = new System.Drawing.Size(200, 20);
            this.txt_examid.TabIndex = 56;
            // 
            // txt_questionscount
            // 
            this.txt_questionscount.Enabled = false;
            this.txt_questionscount.Location = new System.Drawing.Point(105, 333);
            this.txt_questionscount.Name = "txt_questionscount";
            this.txt_questionscount.Size = new System.Drawing.Size(200, 20);
            this.txt_questionscount.TabIndex = 55;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(102, 313);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 54;
            this.label9.Text = "Số câu hỏi";
            // 
            // txt_subjectname
            // 
            this.txt_subjectname.Enabled = false;
            this.txt_subjectname.Location = new System.Drawing.Point(105, 278);
            this.txt_subjectname.Name = "txt_subjectname";
            this.txt_subjectname.Size = new System.Drawing.Size(200, 20);
            this.txt_subjectname.TabIndex = 53;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label6.Location = new System.Drawing.Point(102, 258);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 51;
            this.label6.Text = "Môn thi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(102, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 50;
            this.label4.Text = "Mã đề thi";
            // 
            // btn_exam_details
            // 
            this.btn_exam_details.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_exam_details.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exam_details.ForeColor = System.Drawing.Color.White;
            this.btn_exam_details.Location = new System.Drawing.Point(833, 393);
            this.btn_exam_details.Name = "btn_exam_details";
            this.btn_exam_details.Size = new System.Drawing.Size(201, 32);
            this.btn_exam_details.TabIndex = 48;
            this.btn_exam_details.Text = "Xem chi tiết đề thi";
            this.btn_exam_details.UseVisualStyleBackColor = false;
            this.btn_exam_details.Click += new System.EventHandler(this.btn_exam_details_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(453, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(397, 46);
            this.label3.TabIndex = 46;
            this.label3.Text = "Chọn đề thi";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(328, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 21);
            this.label5.TabIndex = 43;
            this.label5.Text = "Dữ liệu tìm:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_search
            // 
            this.cb_search.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_search.FormattingEnabled = true;
            this.cb_search.Items.AddRange(new object[] {
            "Mã bài thi"});
            this.cb_search.Location = new System.Drawing.Point(406, 82);
            this.cb_search.Name = "cb_search";
            this.cb_search.Size = new System.Drawing.Size(95, 21);
            this.cb_search.TabIndex = 42;
            // 
            // txt_search
            // 
            this.txt_search.Location = new System.Drawing.Point(605, 82);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(251, 20);
            this.txt_search.TabIndex = 45;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(527, 78);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 27);
            this.label7.TabIndex = 44;
            this.label7.Text = "Nhập dữ liệu";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(862, 75);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 33);
            this.btn_search.TabIndex = 36;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_clearsearh
            // 
            this.btn_clearsearh.BackColor = System.Drawing.Color.Gray;
            this.btn_clearsearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearsearh.ForeColor = System.Drawing.Color.White;
            this.btn_clearsearh.Location = new System.Drawing.Point(951, 75);
            this.btn_clearsearh.Name = "btn_clearsearh";
            this.btn_clearsearh.Size = new System.Drawing.Size(83, 33);
            this.btn_clearsearh.TabIndex = 37;
            this.btn_clearsearh.Text = "Làm mới";
            this.btn_clearsearh.UseVisualStyleBackColor = false;
            this.btn_clearsearh.Click += new System.EventHandler(this.btn_clearsearh_Click);
            // 
            // data_exams_list
            // 
            this.data_exams_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_exams_list.BackgroundColor = System.Drawing.Color.White;
            this.data_exams_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_exams_list.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data_exams_list.Location = new System.Drawing.Point(331, 114);
            this.data_exams_list.Name = "data_exams_list";
            this.data_exams_list.RowHeadersVisible = false;
            this.data_exams_list.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.data_exams_list.Size = new System.Drawing.Size(703, 273);
            this.data_exams_list.TabIndex = 24;
            this.data_exams_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_exams_list_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(102, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Trạng thái mở";
            // 
            // cb_openstate
            // 
            this.cb_openstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_openstate.FormattingEnabled = true;
            this.cb_openstate.Items.AddRange(new object[] {
            "Chưa mở",
            "Mở"});
            this.cb_openstate.Location = new System.Drawing.Point(105, 165);
            this.cb_openstate.Name = "cb_openstate";
            this.cb_openstate.Size = new System.Drawing.Size(200, 21);
            this.cb_openstate.TabIndex = 22;
            // 
            // time_datestart
            // 
            this.time_datestart.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.time_datestart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_datestart.Location = new System.Drawing.Point(105, 112);
            this.time_datestart.Name = "time_datestart";
            this.time_datestart.Size = new System.Drawing.Size(200, 20);
            this.time_datestart.TabIndex = 21;
            // 
            // btn_clear_test
            // 
            this.btn_clear_test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_clear_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_test.ForeColor = System.Drawing.Color.White;
            this.btn_clear_test.Location = new System.Drawing.Point(105, 409);
            this.btn_clear_test.Name = "btn_clear_test";
            this.btn_clear_test.Size = new System.Drawing.Size(200, 32);
            this.btn_clear_test.TabIndex = 19;
            this.btn_clear_test.Text = "Làm mới";
            this.btn_clear_test.UseVisualStyleBackColor = false;
            this.btn_clear_test.Click += new System.EventHandler(this.btn_clear_test_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(102, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thời gian mở";
            // 
            // btn_save_test
            // 
            this.btn_save_test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_save_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_test.ForeColor = System.Drawing.Color.White;
            this.btn_save_test.Location = new System.Drawing.Point(105, 447);
            this.btn_save_test.Name = "btn_save_test";
            this.btn_save_test.Size = new System.Drawing.Size(200, 32);
            this.btn_save_test.TabIndex = 4;
            this.btn_save_test.Text = "Lưu lại";
            this.btn_save_test.UseVisualStyleBackColor = false;
            this.btn_save_test.Click += new System.EventHandler(this.btn_save_test_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.data_students_tests);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1077, 526);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Thí sinh đã làm bài";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // data_students_tests
            // 
            this.data_students_tests.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_students_tests.BackgroundColor = System.Drawing.Color.White;
            this.data_students_tests.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_students_tests.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data_students_tests.Location = new System.Drawing.Point(65, 85);
            this.data_students_tests.Name = "data_students_tests";
            this.data_students_tests.Size = new System.Drawing.Size(937, 363);
            this.data_students_tests.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(-2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(1079, 46);
            this.label10.TabIndex = 2;
            this.label10.Text = "Các thí sinh đã làm bài thi";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1085, 552);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1101, 591);
            this.MinimumSize = new System.Drawing.Size(1101, 591);
            this.Name = "TestDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết bài thi";
            this.Load += new System.EventHandler(this.TestDetailsForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_exams_list)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.data_students_tests)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_examid;
        private System.Windows.Forms.TextBox txt_questionscount;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_subjectname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_exam_details;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_search;
        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_clearsearh;
        private System.Windows.Forms.DataGridView data_exams_list;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_openstate;
        private System.Windows.Forms.DateTimePicker time_datestart;
        private System.Windows.Forms.Button btn_clear_test;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_save_test;
        private System.Windows.Forms.CheckBox checkbox_tested;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_testid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_delete_test;
        private System.Windows.Forms.DataGridView data_students_tests;
    }
}