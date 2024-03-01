namespace ExamsSystem.MyForms
{
    partial class ExamManagerForm
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
            this.btn_question_manager = new System.Windows.Forms.Button();
            this.txt_questionscount = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txt_dotime = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txt_checkout = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.btn_create_exam = new System.Windows.Forms.Button();
            this.btn_exam_detail = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_examid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_clearsearh = new System.Windows.Forms.Button();
            this.btn_search = new System.Windows.Forms.Button();
            this.data_exams_list = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_subjects = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_creator_search = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_exams_list)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_question_manager);
            this.panel1.Controls.Add(this.txt_questionscount);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txt_dotime);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txt_checkout);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_subject);
            this.panel1.Controls.Add(this.btn_create_exam);
            this.panel1.Controls.Add(this.btn_exam_detail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_examid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(779, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 432);
            this.panel1.TabIndex = 21;
            // 
            // btn_question_manager
            // 
            this.btn_question_manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_question_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_question_manager.ForeColor = System.Drawing.Color.White;
            this.btn_question_manager.Location = new System.Drawing.Point(26, 396);
            this.btn_question_manager.Name = "btn_question_manager";
            this.btn_question_manager.Size = new System.Drawing.Size(282, 32);
            this.btn_question_manager.TabIndex = 22;
            this.btn_question_manager.Text = "Quản lý câu hỏi";
            this.btn_question_manager.UseVisualStyleBackColor = false;
            this.btn_question_manager.Click += new System.EventHandler(this.btn_question_manager_Click);
            // 
            // txt_questionscount
            // 
            this.txt_questionscount.Enabled = false;
            this.txt_questionscount.Location = new System.Drawing.Point(26, 294);
            this.txt_questionscount.Name = "txt_questionscount";
            this.txt_questionscount.Size = new System.Drawing.Size(282, 20);
            this.txt_questionscount.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(23, 274);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 20;
            this.label11.Text = "Số lượng câu hỏi";
            // 
            // txt_dotime
            // 
            this.txt_dotime.Enabled = false;
            this.txt_dotime.Location = new System.Drawing.Point(26, 247);
            this.txt_dotime.Name = "txt_dotime";
            this.txt_dotime.Size = new System.Drawing.Size(282, 20);
            this.txt_dotime.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(23, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 18;
            this.label10.Text = "Thời gian làm bài";
            // 
            // txt_checkout
            // 
            this.txt_checkout.Enabled = false;
            this.txt_checkout.Location = new System.Drawing.Point(26, 200);
            this.txt_checkout.Name = "txt_checkout";
            this.txt_checkout.Size = new System.Drawing.Size(282, 20);
            this.txt_checkout.TabIndex = 17;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(23, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(166, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Trạng thái kiểm duyệt";
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
            // txt_subject
            // 
            this.txt_subject.Enabled = false;
            this.txt_subject.Location = new System.Drawing.Point(26, 153);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(282, 20);
            this.txt_subject.TabIndex = 14;
            // 
            // btn_create_exam
            // 
            this.btn_create_exam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_create_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_exam.ForeColor = System.Drawing.Color.White;
            this.btn_create_exam.Location = new System.Drawing.Point(26, 358);
            this.btn_create_exam.Name = "btn_create_exam";
            this.btn_create_exam.Size = new System.Drawing.Size(282, 32);
            this.btn_create_exam.TabIndex = 13;
            this.btn_create_exam.Tag = "TeacherRegister";
            this.btn_create_exam.Text = "Tạo đề thi";
            this.btn_create_exam.UseVisualStyleBackColor = false;
            this.btn_create_exam.Click += new System.EventHandler(this.btn_create_exam_Click);
            // 
            // btn_exam_detail
            // 
            this.btn_exam_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_exam_detail.Enabled = false;
            this.btn_exam_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exam_detail.ForeColor = System.Drawing.Color.White;
            this.btn_exam_detail.Location = new System.Drawing.Point(26, 320);
            this.btn_exam_detail.Name = "btn_exam_detail";
            this.btn_exam_detail.Size = new System.Drawing.Size(282, 32);
            this.btn_exam_detail.TabIndex = 11;
            this.btn_exam_detail.Text = "Chi tiết đề thi";
            this.btn_exam_detail.UseVisualStyleBackColor = false;
            this.btn_exam_detail.Click += new System.EventHandler(this.btn_exam_detail_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(23, 86);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Người tạo";
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Location = new System.Drawing.Point(26, 106);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(282, 20);
            this.txt_username.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(23, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã đề thi";
            // 
            // txt_examid
            // 
            this.txt_examid.Enabled = false;
            this.txt_examid.Location = new System.Drawing.Point(26, 59);
            this.txt_examid.Name = "txt_examid";
            this.txt_examid.Size = new System.Drawing.Size(282, 20);
            this.txt_examid.TabIndex = 6;
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
            this.label1.Text = "Thông tin đề thi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1112, 48);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quản lý đề thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_clearsearh
            // 
            this.btn_clearsearh.BackColor = System.Drawing.Color.Gray;
            this.btn_clearsearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearsearh.ForeColor = System.Drawing.Color.White;
            this.btn_clearsearh.Location = new System.Drawing.Point(690, 95);
            this.btn_clearsearh.Name = "btn_clearsearh";
            this.btn_clearsearh.Size = new System.Drawing.Size(83, 33);
            this.btn_clearsearh.TabIndex = 24;
            this.btn_clearsearh.Text = "Làm mới";
            this.btn_clearsearh.UseVisualStyleBackColor = false;
            this.btn_clearsearh.Click += new System.EventHandler(this.btn_clearsearh_Click);
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(601, 95);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 33);
            this.btn_search.TabIndex = 23;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // data_exams_list
            // 
            this.data_exams_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_exams_list.BackgroundColor = System.Drawing.Color.White;
            this.data_exams_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_exams_list.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data_exams_list.Location = new System.Drawing.Point(5, 137);
            this.data_exams_list.Name = "data_exams_list";
            this.data_exams_list.Size = new System.Drawing.Size(768, 390);
            this.data_exams_list.TabIndex = 22;
            this.data_exams_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_exams_list_CellClick);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 28;
            this.label5.Text = "Môn học:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.cb_subjects.Location = new System.Drawing.Point(76, 102);
            this.cb_subjects.Name = "cb_subjects";
            this.cb_subjects.Size = new System.Drawing.Size(129, 21);
            this.cb_subjects.TabIndex = 27;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(226, 98);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 27);
            this.label7.TabIndex = 29;
            this.label7.Text = "Tài khoản người tạo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txt_creator_search
            // 
            this.txt_creator_search.Location = new System.Drawing.Point(342, 102);
            this.txt_creator_search.Name = "txt_creator_search";
            this.txt_creator_search.Size = new System.Drawing.Size(141, 20);
            this.txt_creator_search.TabIndex = 30;
            // 
            // ExamManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 529);
            this.Controls.Add(this.txt_creator_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cb_subjects);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_clearsearh);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.data_exams_list);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1128, 568);
            this.MinimumSize = new System.Drawing.Size(1128, 568);
            this.Name = "ExamManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý đề thi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ExamManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.ExamManagerForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.data_exams_list)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_create_exam;
        private System.Windows.Forms.Button btn_exam_detail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_examid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_clearsearh;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DataGridView data_exams_list;
        private System.Windows.Forms.TextBox txt_questionscount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txt_dotime;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txt_checkout;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_subjects;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_creator_search;
        private System.Windows.Forms.Button btn_question_manager;
    }
}