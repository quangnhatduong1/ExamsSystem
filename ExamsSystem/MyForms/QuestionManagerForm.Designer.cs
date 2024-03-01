namespace ExamsSystem.MyForms
{
    partial class QuestionManagerForm
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
            this.label5 = new System.Windows.Forms.Label();
            this.data_questions_list = new System.Windows.Forms.DataGridView();
            this.cb_subjects = new System.Windows.Forms.ComboBox();
            this.btn_clearsearh = new System.Windows.Forms.Button();
            this.txt_creator_search = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_questionid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_question_detail = new System.Windows.Forms.Button();
            this.btn_create_exam = new System.Windows.Forms.Button();
            this.txt_subject = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_typequestion = new System.Windows.Forms.TextBox();
            this.btn_exam_manager = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_choose_question = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_questions_list)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(601, 95);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 33);
            this.btn_search.TabIndex = 34;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 21);
            this.label5.TabIndex = 39;
            this.label5.Text = "Môn học:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // data_questions_list
            // 
            this.data_questions_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_questions_list.BackgroundColor = System.Drawing.Color.White;
            this.data_questions_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_questions_list.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data_questions_list.Location = new System.Drawing.Point(12, 137);
            this.data_questions_list.MultiSelect = false;
            this.data_questions_list.Name = "data_questions_list";
            this.data_questions_list.RowHeadersVisible = false;
            this.data_questions_list.Size = new System.Drawing.Size(761, 390);
            this.data_questions_list.TabIndex = 33;
            this.data_questions_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_questions_list_CellClick);
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
            this.cb_subjects.Location = new System.Drawing.Point(70, 102);
            this.cb_subjects.Name = "cb_subjects";
            this.cb_subjects.Size = new System.Drawing.Size(154, 21);
            this.cb_subjects.TabIndex = 38;
            // 
            // btn_clearsearh
            // 
            this.btn_clearsearh.BackColor = System.Drawing.Color.Gray;
            this.btn_clearsearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearsearh.ForeColor = System.Drawing.Color.White;
            this.btn_clearsearh.Location = new System.Drawing.Point(690, 95);
            this.btn_clearsearh.Name = "btn_clearsearh";
            this.btn_clearsearh.Size = new System.Drawing.Size(83, 33);
            this.btn_clearsearh.TabIndex = 35;
            this.btn_clearsearh.Text = "Làm mới";
            this.btn_clearsearh.UseVisualStyleBackColor = false;
            this.btn_clearsearh.Click += new System.EventHandler(this.btn_clearsearh_Click);
            // 
            // txt_creator_search
            // 
            this.txt_creator_search.Location = new System.Drawing.Point(312, 102);
            this.txt_creator_search.Name = "txt_creator_search";
            this.txt_creator_search.Size = new System.Drawing.Size(141, 20);
            this.txt_creator_search.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(245, 99);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 27);
            this.label7.TabIndex = 40;
            this.label7.Text = "Tài khoản người tạo:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1109, 48);
            this.label2.TabIndex = 31;
            this.label2.Text = "Quản lý câu hỏi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.label1.Text = "Thông tin câu hỏi";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_questionid
            // 
            this.txt_questionid.Enabled = false;
            this.txt_questionid.Location = new System.Drawing.Point(26, 59);
            this.txt_questionid.Name = "txt_questionid";
            this.txt_questionid.Size = new System.Drawing.Size(282, 20);
            this.txt_questionid.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(23, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Mã câu hỏi";
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Location = new System.Drawing.Point(26, 106);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(282, 20);
            this.txt_username.TabIndex = 8;
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
            // btn_question_detail
            // 
            this.btn_question_detail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_question_detail.Enabled = false;
            this.btn_question_detail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_question_detail.ForeColor = System.Drawing.Color.White;
            this.btn_question_detail.Location = new System.Drawing.Point(26, 320);
            this.btn_question_detail.Name = "btn_question_detail";
            this.btn_question_detail.Size = new System.Drawing.Size(282, 32);
            this.btn_question_detail.TabIndex = 11;
            this.btn_question_detail.Text = "Chi tiết câu hỏi";
            this.btn_question_detail.UseVisualStyleBackColor = false;
            this.btn_question_detail.Click += new System.EventHandler(this.btn_question_detail_Click);
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
            this.btn_create_exam.Text = "Tạo câu hỏi";
            this.btn_create_exam.UseVisualStyleBackColor = false;
            this.btn_create_exam.Click += new System.EventHandler(this.btn_create_exam_Click);
            // 
            // txt_subject
            // 
            this.txt_subject.Enabled = false;
            this.txt_subject.Location = new System.Drawing.Point(26, 153);
            this.txt_subject.Name = "txt_subject";
            this.txt_subject.Size = new System.Drawing.Size(282, 20);
            this.txt_subject.TabIndex = 14;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label9.Location = new System.Drawing.Point(23, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(104, 17);
            this.label9.TabIndex = 16;
            this.label9.Text = "Dạng câu hỏi";
            // 
            // txt_typequestion
            // 
            this.txt_typequestion.Enabled = false;
            this.txt_typequestion.Location = new System.Drawing.Point(26, 200);
            this.txt_typequestion.Name = "txt_typequestion";
            this.txt_typequestion.Size = new System.Drawing.Size(282, 20);
            this.txt_typequestion.TabIndex = 17;
            // 
            // btn_exam_manager
            // 
            this.btn_exam_manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_exam_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exam_manager.ForeColor = System.Drawing.Color.White;
            this.btn_exam_manager.Location = new System.Drawing.Point(26, 396);
            this.btn_exam_manager.Name = "btn_exam_manager";
            this.btn_exam_manager.Size = new System.Drawing.Size(282, 32);
            this.btn_exam_manager.TabIndex = 22;
            this.btn_exam_manager.Text = "Quản lý đề thi";
            this.btn_exam_manager.UseVisualStyleBackColor = false;
            this.btn_exam_manager.Click += new System.EventHandler(this.btn_question_manager_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_choose_question);
            this.panel1.Controls.Add(this.btn_exam_manager);
            this.panel1.Controls.Add(this.txt_typequestion);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txt_subject);
            this.panel1.Controls.Add(this.btn_create_exam);
            this.panel1.Controls.Add(this.btn_question_detail);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txt_username);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txt_questionid);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(779, 95);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(328, 432);
            this.panel1.TabIndex = 32;
            // 
            // btn_choose_question
            // 
            this.btn_choose_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.btn_choose_question.Enabled = false;
            this.btn_choose_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_choose_question.ForeColor = System.Drawing.Color.White;
            this.btn_choose_question.Location = new System.Drawing.Point(26, 282);
            this.btn_choose_question.Name = "btn_choose_question";
            this.btn_choose_question.Size = new System.Drawing.Size(282, 32);
            this.btn_choose_question.TabIndex = 23;
            this.btn_choose_question.Tag = "TeacherRegister";
            this.btn_choose_question.Text = "Chọn câu hỏi";
            this.btn_choose_question.UseVisualStyleBackColor = false;
            this.btn_choose_question.Click += new System.EventHandler(this.btn_choose_question_Click);
            // 
            // QuestionManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 534);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data_questions_list);
            this.Controls.Add(this.cb_subjects);
            this.Controls.Add(this.btn_clearsearh);
            this.Controls.Add(this.txt_creator_search);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1125, 573);
            this.MinimumSize = new System.Drawing.Size(1125, 573);
            this.Name = "QuestionManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý câu hỏi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.QuestionManagerForm_FormClosed);
            this.Load += new System.EventHandler(this.QuestionManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_questions_list)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView data_questions_list;
        private System.Windows.Forms.ComboBox cb_subjects;
        private System.Windows.Forms.Button btn_clearsearh;
        private System.Windows.Forms.TextBox txt_creator_search;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_questionid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_question_detail;
        private System.Windows.Forms.Button btn_create_exam;
        private System.Windows.Forms.TextBox txt_subject;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_typequestion;
        private System.Windows.Forms.Button btn_exam_manager;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_choose_question;
    }
}