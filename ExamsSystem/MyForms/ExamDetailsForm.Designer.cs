namespace ExamsSystem.MyForms
{
    partial class ExamDetailsForm
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.group_type = new System.Windows.Forms.GroupBox();
            this.rd_answer_multiple = new System.Windows.Forms.RadioButton();
            this.rd_answer_single = new System.Windows.Forms.RadioButton();
            this.btn_paste_question = new System.Windows.Forms.Button();
            this.group_answers = new System.Windows.Forms.GroupBox();
            this.rd_answer_D = new System.Windows.Forms.RadioButton();
            this.rtxt_answerD = new System.Windows.Forms.RichTextBox();
            this.rd_answer_C = new System.Windows.Forms.RadioButton();
            this.rtxt_answerC = new System.Windows.Forms.RichTextBox();
            this.rd_answer_B = new System.Windows.Forms.RadioButton();
            this.rtxt_answerB = new System.Windows.Forms.RichTextBox();
            this.rd_answer_A = new System.Windows.Forms.RadioButton();
            this.rtxt_answerA = new System.Windows.Forms.RichTextBox();
            this.btn_add_question = new System.Windows.Forms.Button();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_update_question = new System.Windows.Forms.Button();
            this.btn_copy_question = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.rtxt_question_title = new System.Windows.Forms.RichTextBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lb_question = new System.Windows.Forms.Label();
            this.group_questions_list = new System.Windows.Forms.GroupBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_checkout = new System.Windows.Forms.Button();
            this.btn_delete_exam = new System.Windows.Forms.Button();
            this.btn_copy_exam = new System.Windows.Forms.Button();
            this.btn_save_exam = new System.Windows.Forms.Button();
            this.group_subjects = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.checkbox_used = new System.Windows.Forms.CheckBox();
            this.checkbox_checkout = new System.Windows.Forms.CheckBox();
            this.cb_dotime = new System.Windows.Forms.ComboBox();
            this.txt_questionscount = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_examid = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2.SuspendLayout();
            this.group_type.SuspendLayout();
            this.group_answers.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.group_subjects.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.group_type);
            this.tabPage2.Controls.Add(this.btn_paste_question);
            this.tabPage2.Controls.Add(this.group_answers);
            this.tabPage2.Controls.Add(this.btn_add_question);
            this.tabPage2.Controls.Add(this.btn_previous);
            this.tabPage2.Controls.Add(this.btn_update_question);
            this.tabPage2.Controls.Add(this.btn_copy_question);
            this.tabPage2.Controls.Add(this.btn_next);
            this.tabPage2.Controls.Add(this.rtxt_question_title);
            this.tabPage2.Controls.Add(this.btn_delete);
            this.tabPage2.Controls.Add(this.lb_question);
            this.tabPage2.Controls.Add(this.group_questions_list);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1272, 514);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Danh sách câu hỏi";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // group_type
            // 
            this.group_type.Controls.Add(this.rd_answer_multiple);
            this.group_type.Controls.Add(this.rd_answer_single);
            this.group_type.Location = new System.Drawing.Point(8, 31);
            this.group_type.Name = "group_type";
            this.group_type.Size = new System.Drawing.Size(198, 68);
            this.group_type.TabIndex = 33;
            this.group_type.TabStop = false;
            this.group_type.Text = "Dạng câu hỏi";
            // 
            // rd_answer_multiple
            // 
            this.rd_answer_multiple.AutoSize = true;
            this.rd_answer_multiple.Location = new System.Drawing.Point(7, 42);
            this.rd_answer_multiple.Name = "rd_answer_multiple";
            this.rd_answer_multiple.Size = new System.Drawing.Size(102, 17);
            this.rd_answer_multiple.TabIndex = 1;
            this.rd_answer_multiple.Tag = "1";
            this.rd_answer_multiple.Text = "Nhiều câu trả lời";
            this.rd_answer_multiple.UseVisualStyleBackColor = true;
            this.rd_answer_multiple.Click += new System.EventHandler(this.change_type_question_radio_click);
            // 
            // rd_answer_single
            // 
            this.rd_answer_single.AutoSize = true;
            this.rd_answer_single.Checked = true;
            this.rd_answer_single.Location = new System.Drawing.Point(6, 19);
            this.rd_answer_single.Name = "rd_answer_single";
            this.rd_answer_single.Size = new System.Drawing.Size(92, 17);
            this.rd_answer_single.TabIndex = 0;
            this.rd_answer_single.TabStop = true;
            this.rd_answer_single.Tag = "0";
            this.rd_answer_single.Text = "Một câu trả lời";
            this.rd_answer_single.UseVisualStyleBackColor = true;
            this.rd_answer_single.Click += new System.EventHandler(this.change_type_question_radio_click);
            // 
            // btn_paste_question
            // 
            this.btn_paste_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_paste_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paste_question.ForeColor = System.Drawing.Color.White;
            this.btn_paste_question.Location = new System.Drawing.Point(680, 474);
            this.btn_paste_question.Name = "btn_paste_question";
            this.btn_paste_question.Size = new System.Drawing.Size(149, 32);
            this.btn_paste_question.TabIndex = 26;
            this.btn_paste_question.Text = "Dán câu hỏi";
            this.btn_paste_question.UseVisualStyleBackColor = false;
            this.btn_paste_question.Click += new System.EventHandler(this.btn_paste_question_Click);
            // 
            // group_answers
            // 
            this.group_answers.Controls.Add(this.rd_answer_D);
            this.group_answers.Controls.Add(this.rtxt_answerD);
            this.group_answers.Controls.Add(this.rd_answer_C);
            this.group_answers.Controls.Add(this.rtxt_answerC);
            this.group_answers.Controls.Add(this.rd_answer_B);
            this.group_answers.Controls.Add(this.rtxt_answerB);
            this.group_answers.Controls.Add(this.rd_answer_A);
            this.group_answers.Controls.Add(this.rtxt_answerA);
            this.group_answers.Location = new System.Drawing.Point(215, 133);
            this.group_answers.Name = "group_answers";
            this.group_answers.Size = new System.Drawing.Size(1051, 335);
            this.group_answers.TabIndex = 25;
            this.group_answers.TabStop = false;
            this.group_answers.Text = "Câu trả lời";
            // 
            // rd_answer_D
            // 
            this.rd_answer_D.AutoSize = true;
            this.rd_answer_D.Location = new System.Drawing.Point(6, 242);
            this.rd_answer_D.Name = "rd_answer_D";
            this.rd_answer_D.Size = new System.Drawing.Size(36, 17);
            this.rd_answer_D.TabIndex = 13;
            this.rd_answer_D.TabStop = true;
            this.rd_answer_D.Tag = "D";
            this.rd_answer_D.Text = "D.";
            this.rd_answer_D.UseVisualStyleBackColor = true;
            // 
            // rtxt_answerD
            // 
            this.rtxt_answerD.Location = new System.Drawing.Point(67, 241);
            this.rtxt_answerD.Name = "rtxt_answerD";
            this.rtxt_answerD.Size = new System.Drawing.Size(978, 68);
            this.rtxt_answerD.TabIndex = 12;
            this.rtxt_answerD.Text = "";
            // 
            // rd_answer_C
            // 
            this.rd_answer_C.AutoSize = true;
            this.rd_answer_C.Location = new System.Drawing.Point(6, 168);
            this.rd_answer_C.Name = "rd_answer_C";
            this.rd_answer_C.Size = new System.Drawing.Size(35, 17);
            this.rd_answer_C.TabIndex = 11;
            this.rd_answer_C.TabStop = true;
            this.rd_answer_C.Tag = "C";
            this.rd_answer_C.Text = "C.";
            this.rd_answer_C.UseVisualStyleBackColor = true;
            // 
            // rtxt_answerC
            // 
            this.rtxt_answerC.Location = new System.Drawing.Point(67, 167);
            this.rtxt_answerC.Name = "rtxt_answerC";
            this.rtxt_answerC.Size = new System.Drawing.Size(978, 68);
            this.rtxt_answerC.TabIndex = 10;
            this.rtxt_answerC.Text = "";
            // 
            // rd_answer_B
            // 
            this.rd_answer_B.AutoSize = true;
            this.rd_answer_B.Location = new System.Drawing.Point(6, 94);
            this.rd_answer_B.Name = "rd_answer_B";
            this.rd_answer_B.Size = new System.Drawing.Size(35, 17);
            this.rd_answer_B.TabIndex = 9;
            this.rd_answer_B.TabStop = true;
            this.rd_answer_B.Tag = "B";
            this.rd_answer_B.Text = "B.";
            this.rd_answer_B.UseVisualStyleBackColor = true;
            // 
            // rtxt_answerB
            // 
            this.rtxt_answerB.Location = new System.Drawing.Point(67, 93);
            this.rtxt_answerB.Name = "rtxt_answerB";
            this.rtxt_answerB.Size = new System.Drawing.Size(978, 68);
            this.rtxt_answerB.TabIndex = 8;
            this.rtxt_answerB.Text = "";
            // 
            // rd_answer_A
            // 
            this.rd_answer_A.AutoSize = true;
            this.rd_answer_A.Location = new System.Drawing.Point(6, 20);
            this.rd_answer_A.Name = "rd_answer_A";
            this.rd_answer_A.Size = new System.Drawing.Size(35, 17);
            this.rd_answer_A.TabIndex = 7;
            this.rd_answer_A.TabStop = true;
            this.rd_answer_A.Tag = "A";
            this.rd_answer_A.Text = "A.";
            this.rd_answer_A.UseVisualStyleBackColor = true;
            // 
            // rtxt_answerA
            // 
            this.rtxt_answerA.Location = new System.Drawing.Point(67, 19);
            this.rtxt_answerA.Name = "rtxt_answerA";
            this.rtxt_answerA.Size = new System.Drawing.Size(978, 68);
            this.rtxt_answerA.TabIndex = 6;
            this.rtxt_answerA.Text = "";
            // 
            // btn_add_question
            // 
            this.btn_add_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_add_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_question.ForeColor = System.Drawing.Color.White;
            this.btn_add_question.Location = new System.Drawing.Point(835, 474);
            this.btn_add_question.Name = "btn_add_question";
            this.btn_add_question.Size = new System.Drawing.Size(149, 32);
            this.btn_add_question.TabIndex = 24;
            this.btn_add_question.Text = "Thêm câu hỏi";
            this.btn_add_question.UseVisualStyleBackColor = false;
            this.btn_add_question.Click += new System.EventHandler(this.btn_add_question_Click);
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_previous.Enabled = false;
            this.btn_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.Location = new System.Drawing.Point(1065, 474);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(99, 32);
            this.btn_previous.TabIndex = 23;
            this.btn_previous.Text = "Trước";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_update_question
            // 
            this.btn_update_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_update_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update_question.ForeColor = System.Drawing.Color.White;
            this.btn_update_question.Location = new System.Drawing.Point(215, 474);
            this.btn_update_question.Name = "btn_update_question";
            this.btn_update_question.Size = new System.Drawing.Size(149, 32);
            this.btn_update_question.TabIndex = 22;
            this.btn_update_question.Text = "Sửa câu hỏi";
            this.btn_update_question.UseVisualStyleBackColor = false;
            this.btn_update_question.Click += new System.EventHandler(this.btn_update_question_Click);
            // 
            // btn_copy_question
            // 
            this.btn_copy_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_copy_question.Enabled = false;
            this.btn_copy_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy_question.ForeColor = System.Drawing.Color.White;
            this.btn_copy_question.Location = new System.Drawing.Point(525, 474);
            this.btn_copy_question.Name = "btn_copy_question";
            this.btn_copy_question.Size = new System.Drawing.Size(149, 32);
            this.btn_copy_question.TabIndex = 21;
            this.btn_copy_question.Text = "Copy câu hỏi";
            this.btn_copy_question.UseVisualStyleBackColor = false;
            this.btn_copy_question.Click += new System.EventHandler(this.btn_copy_question_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_next.Enabled = false;
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(1170, 474);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(99, 32);
            this.btn_next.TabIndex = 19;
            this.btn_next.Text = "Tiếp";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // rtxt_question_title
            // 
            this.rtxt_question_title.Location = new System.Drawing.Point(213, 31);
            this.rtxt_question_title.Name = "rtxt_question_title";
            this.rtxt_question_title.Size = new System.Drawing.Size(1053, 96);
            this.rtxt_question_title.TabIndex = 2;
            this.rtxt_question_title.Text = "";
            // 
            // btn_delete
            // 
            this.btn_delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.ForeColor = System.Drawing.Color.White;
            this.btn_delete.Location = new System.Drawing.Point(370, 474);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(149, 32);
            this.btn_delete.TabIndex = 17;
            this.btn_delete.Text = "Xóa câu hỏi";
            this.btn_delete.UseVisualStyleBackColor = false;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lb_question
            // 
            this.lb_question.AutoSize = true;
            this.lb_question.Location = new System.Drawing.Point(212, 15);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(43, 13);
            this.lb_question.TabIndex = 14;
            this.lb_question.Text = "Câu hỏi";
            this.lb_question.Click += new System.EventHandler(this.label1_Click);
            // 
            // group_questions_list
            // 
            this.group_questions_list.Location = new System.Drawing.Point(6, 105);
            this.group_questions_list.Name = "group_questions_list";
            this.group_questions_list.Size = new System.Drawing.Size(200, 401);
            this.group_questions_list.TabIndex = 13;
            this.group_questions_list.TabStop = false;
            this.group_questions_list.Text = "Bảng câu hỏi";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btn_checkout);
            this.tabPage1.Controls.Add(this.btn_delete_exam);
            this.tabPage1.Controls.Add(this.btn_copy_exam);
            this.tabPage1.Controls.Add(this.btn_save_exam);
            this.tabPage1.Controls.Add(this.group_subjects);
            this.tabPage1.Controls.Add(this.checkbox_used);
            this.tabPage1.Controls.Add(this.checkbox_checkout);
            this.tabPage1.Controls.Add(this.cb_dotime);
            this.tabPage1.Controls.Add(this.txt_questionscount);
            this.tabPage1.Controls.Add(this.txt_username);
            this.tabPage1.Controls.Add(this.txt_examid);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1272, 514);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Chi tiết đề thi";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btn_checkout
            // 
            this.btn_checkout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_checkout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_checkout.ForeColor = System.Drawing.Color.White;
            this.btn_checkout.Location = new System.Drawing.Point(362, 344);
            this.btn_checkout.Name = "btn_checkout";
            this.btn_checkout.Size = new System.Drawing.Size(282, 32);
            this.btn_checkout.TabIndex = 44;
            this.btn_checkout.Text = "Duyệt đề thi";
            this.btn_checkout.UseVisualStyleBackColor = false;
            this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
            // 
            // btn_delete_exam
            // 
            this.btn_delete_exam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_delete_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_exam.ForeColor = System.Drawing.Color.White;
            this.btn_delete_exam.Location = new System.Drawing.Point(362, 400);
            this.btn_delete_exam.Name = "btn_delete_exam";
            this.btn_delete_exam.Size = new System.Drawing.Size(282, 32);
            this.btn_delete_exam.TabIndex = 43;
            this.btn_delete_exam.Text = "Xóa đề thi";
            this.btn_delete_exam.UseVisualStyleBackColor = false;
            this.btn_delete_exam.Click += new System.EventHandler(this.btn_delete_exam_Click);
            // 
            // btn_copy_exam
            // 
            this.btn_copy_exam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_copy_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy_exam.ForeColor = System.Drawing.Color.White;
            this.btn_copy_exam.Location = new System.Drawing.Point(676, 344);
            this.btn_copy_exam.Name = "btn_copy_exam";
            this.btn_copy_exam.Size = new System.Drawing.Size(282, 32);
            this.btn_copy_exam.TabIndex = 42;
            this.btn_copy_exam.Text = "Copy đề thi";
            this.btn_copy_exam.UseVisualStyleBackColor = false;
            this.btn_copy_exam.Click += new System.EventHandler(this.btn_copy_exam_Click);
            // 
            // btn_save_exam
            // 
            this.btn_save_exam.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_save_exam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_exam.ForeColor = System.Drawing.Color.White;
            this.btn_save_exam.Location = new System.Drawing.Point(676, 400);
            this.btn_save_exam.Name = "btn_save_exam";
            this.btn_save_exam.Size = new System.Drawing.Size(282, 32);
            this.btn_save_exam.TabIndex = 41;
            this.btn_save_exam.Text = "Lưu lại";
            this.btn_save_exam.UseVisualStyleBackColor = false;
            this.btn_save_exam.Click += new System.EventHandler(this.btn_save_exam_Click);
            // 
            // group_subjects
            // 
            this.group_subjects.Controls.Add(this.radioButton3);
            this.group_subjects.Controls.Add(this.radioButton2);
            this.group_subjects.Controls.Add(this.radioButton1);
            this.group_subjects.Enabled = false;
            this.group_subjects.Location = new System.Drawing.Point(362, 214);
            this.group_subjects.Name = "group_subjects";
            this.group_subjects.Size = new System.Drawing.Size(282, 93);
            this.group_subjects.TabIndex = 39;
            this.group_subjects.TabStop = false;
            this.group_subjects.Text = "Môn học";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(7, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(51, 17);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Tag = "3";
            this.radioButton3.Text = "Địa lý";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 42);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(59, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Tag = "2";
            this.radioButton2.Text = "Lịch sử";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(6, 19);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(116, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Tag = "1";
            this.radioButton1.Text = "Giáo dục công dân";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // checkbox_used
            // 
            this.checkbox_used.AutoSize = true;
            this.checkbox_used.Enabled = false;
            this.checkbox_used.Location = new System.Drawing.Point(763, 224);
            this.checkbox_used.Name = "checkbox_used";
            this.checkbox_used.Size = new System.Drawing.Size(82, 17);
            this.checkbox_used.TabIndex = 38;
            this.checkbox_used.Text = "Đã áp dụng";
            this.checkbox_used.UseVisualStyleBackColor = true;
            // 
            // checkbox_checkout
            // 
            this.checkbox_checkout.AutoSize = true;
            this.checkbox_checkout.Enabled = false;
            this.checkbox_checkout.Location = new System.Drawing.Point(676, 224);
            this.checkbox_checkout.Name = "checkbox_checkout";
            this.checkbox_checkout.Size = new System.Drawing.Size(69, 17);
            this.checkbox_checkout.TabIndex = 37;
            this.checkbox_checkout.Text = "Đã duyệt";
            this.checkbox_checkout.UseVisualStyleBackColor = true;
            // 
            // cb_dotime
            // 
            this.cb_dotime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_dotime.FormattingEnabled = true;
            this.cb_dotime.Items.AddRange(new object[] {
            "45",
            "60",
            "90",
            "120",
            "150",
            "180"});
            this.cb_dotime.Location = new System.Drawing.Point(362, 172);
            this.cb_dotime.Name = "cb_dotime";
            this.cb_dotime.Size = new System.Drawing.Size(282, 21);
            this.cb_dotime.TabIndex = 35;
            // 
            // txt_questionscount
            // 
            this.txt_questionscount.Enabled = false;
            this.txt_questionscount.Location = new System.Drawing.Point(676, 172);
            this.txt_questionscount.Name = "txt_questionscount";
            this.txt_questionscount.Size = new System.Drawing.Size(282, 20);
            this.txt_questionscount.TabIndex = 34;
            // 
            // txt_username
            // 
            this.txt_username.Enabled = false;
            this.txt_username.Location = new System.Drawing.Point(676, 104);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(282, 20);
            this.txt_username.TabIndex = 25;
            // 
            // txt_examid
            // 
            this.txt_examid.Enabled = false;
            this.txt_examid.Location = new System.Drawing.Point(362, 104);
            this.txt_examid.Name = "txt_examid";
            this.txt_examid.Size = new System.Drawing.Size(282, 20);
            this.txt_examid.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label11.Location = new System.Drawing.Point(673, 152);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(130, 17);
            this.label11.TabIndex = 33;
            this.label11.Text = "Số lượng câu hỏi";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label10.Location = new System.Drawing.Point(359, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 17);
            this.label10.TabIndex = 31;
            this.label10.Text = "Thời gian làm bài";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(673, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Người tạo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(359, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "Mã đề thi";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1266, 48);
            this.label5.TabIndex = 22;
            this.label5.Text = "Thông tin đề thi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1280, 540);
            this.tabControl1.TabIndex = 0;
            // 
            // ExamDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1280, 540);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1296, 579);
            this.MinimumSize = new System.Drawing.Size(1296, 579);
            this.Name = "ExamDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết đề thi";
            this.Load += new System.EventHandler(this.ExamDetailsForm_Load);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.group_type.ResumeLayout(false);
            this.group_type.PerformLayout();
            this.group_answers.ResumeLayout(false);
            this.group_answers.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.group_subjects.ResumeLayout(false);
            this.group_subjects.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox group_answers;
        private System.Windows.Forms.RadioButton rd_answer_D;
        private System.Windows.Forms.RichTextBox rtxt_answerD;
        private System.Windows.Forms.RadioButton rd_answer_C;
        private System.Windows.Forms.RichTextBox rtxt_answerC;
        private System.Windows.Forms.RadioButton rd_answer_B;
        private System.Windows.Forms.RichTextBox rtxt_answerB;
        private System.Windows.Forms.RadioButton rd_answer_A;
        private System.Windows.Forms.RichTextBox rtxt_answerA;
        private System.Windows.Forms.Button btn_add_question;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_update_question;
        private System.Windows.Forms.Button btn_copy_question;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.RichTextBox rtxt_question_title;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.Label lb_question;
        private System.Windows.Forms.GroupBox group_questions_list;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn_delete_exam;
        private System.Windows.Forms.Button btn_copy_exam;
        private System.Windows.Forms.Button btn_save_exam;
        private System.Windows.Forms.GroupBox group_subjects;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.CheckBox checkbox_used;
        private System.Windows.Forms.CheckBox checkbox_checkout;
        private System.Windows.Forms.ComboBox cb_dotime;
        private System.Windows.Forms.TextBox txt_questionscount;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_examid;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button btn_paste_question;
        private System.Windows.Forms.Button btn_checkout;
        private System.Windows.Forms.GroupBox group_type;
        private System.Windows.Forms.RadioButton rd_answer_multiple;
        private System.Windows.Forms.RadioButton rd_answer_single;
    }
}