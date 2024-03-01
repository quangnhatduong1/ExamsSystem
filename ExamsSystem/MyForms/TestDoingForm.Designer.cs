namespace ExamsSystem.MyForms
{
    partial class TestDoingForm
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
            this.group_type = new System.Windows.Forms.GroupBox();
            this.rd_answer_multiple = new System.Windows.Forms.RadioButton();
            this.rd_answer_single = new System.Windows.Forms.RadioButton();
            this.group_answers = new System.Windows.Forms.GroupBox();
            this.rd_answer_D = new System.Windows.Forms.RadioButton();
            this.rtxt_answerD = new System.Windows.Forms.RichTextBox();
            this.rd_answer_C = new System.Windows.Forms.RadioButton();
            this.rtxt_answerC = new System.Windows.Forms.RichTextBox();
            this.rd_answer_B = new System.Windows.Forms.RadioButton();
            this.rtxt_answerB = new System.Windows.Forms.RichTextBox();
            this.rd_answer_A = new System.Windows.Forms.RadioButton();
            this.rtxt_answerA = new System.Windows.Forms.RichTextBox();
            this.btn_previous = new System.Windows.Forms.Button();
            this.btn_next = new System.Windows.Forms.Button();
            this.rtxt_question_title = new System.Windows.Forms.RichTextBox();
            this.group_questions_list = new System.Windows.Forms.GroupBox();
            this.lb_question = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_countdown = new System.Windows.Forms.Label();
            this.lb_test_title = new System.Windows.Forms.Label();
            this.group_type.SuspendLayout();
            this.group_answers.SuspendLayout();
            this.SuspendLayout();
            // 
            // group_type
            // 
            this.group_type.Controls.Add(this.rd_answer_multiple);
            this.group_type.Controls.Add(this.rd_answer_single);
            this.group_type.Enabled = false;
            this.group_type.Location = new System.Drawing.Point(15, 79);
            this.group_type.Name = "group_type";
            this.group_type.Size = new System.Drawing.Size(198, 77);
            this.group_type.TabIndex = 39;
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
            this.group_answers.Location = new System.Drawing.Point(222, 162);
            this.group_answers.Name = "group_answers";
            this.group_answers.Size = new System.Drawing.Size(1051, 335);
            this.group_answers.TabIndex = 38;
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
            this.rtxt_answerD.Enabled = false;
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
            this.rtxt_answerC.Enabled = false;
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
            this.rtxt_answerB.Enabled = false;
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
            this.rtxt_answerA.Enabled = false;
            this.rtxt_answerA.Location = new System.Drawing.Point(67, 19);
            this.rtxt_answerA.Name = "rtxt_answerA";
            this.rtxt_answerA.Size = new System.Drawing.Size(978, 68);
            this.rtxt_answerA.TabIndex = 6;
            this.rtxt_answerA.Text = "";
            // 
            // btn_previous
            // 
            this.btn_previous.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_previous.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_previous.ForeColor = System.Drawing.Color.White;
            this.btn_previous.Location = new System.Drawing.Point(1072, 503);
            this.btn_previous.Name = "btn_previous";
            this.btn_previous.Size = new System.Drawing.Size(99, 32);
            this.btn_previous.TabIndex = 37;
            this.btn_previous.Text = "Trước";
            this.btn_previous.UseVisualStyleBackColor = false;
            this.btn_previous.Click += new System.EventHandler(this.btn_previous_Click);
            // 
            // btn_next
            // 
            this.btn_next.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_next.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_next.ForeColor = System.Drawing.Color.White;
            this.btn_next.Location = new System.Drawing.Point(1177, 503);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(99, 32);
            this.btn_next.TabIndex = 36;
            this.btn_next.Text = "Tiếp";
            this.btn_next.UseVisualStyleBackColor = false;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // rtxt_question_title
            // 
            this.rtxt_question_title.Enabled = false;
            this.rtxt_question_title.Location = new System.Drawing.Point(220, 79);
            this.rtxt_question_title.Name = "rtxt_question_title";
            this.rtxt_question_title.Size = new System.Drawing.Size(1053, 77);
            this.rtxt_question_title.TabIndex = 34;
            this.rtxt_question_title.Text = "";
            // 
            // group_questions_list
            // 
            this.group_questions_list.Location = new System.Drawing.Point(13, 162);
            this.group_questions_list.Name = "group_questions_list";
            this.group_questions_list.Size = new System.Drawing.Size(200, 373);
            this.group_questions_list.TabIndex = 35;
            this.group_questions_list.TabStop = false;
            this.group_questions_list.Text = "Bảng câu hỏi";
            // 
            // lb_question
            // 
            this.lb_question.AutoSize = true;
            this.lb_question.Location = new System.Drawing.Point(221, 60);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(43, 13);
            this.lb_question.TabIndex = 40;
            this.lb_question.Text = "Câu hỏi";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(222, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 32);
            this.button1.TabIndex = 41;
            this.button1.Text = "Nộp bài";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_countdown
            // 
            this.lb_countdown.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_countdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(66)))), ((int)(((byte)(50)))));
            this.lb_countdown.Location = new System.Drawing.Point(12, 9);
            this.lb_countdown.Name = "lb_countdown";
            this.lb_countdown.Size = new System.Drawing.Size(201, 67);
            this.lb_countdown.TabIndex = 43;
            this.lb_countdown.Text = "Bạn còn 00::00:00 để làm bài";
            this.lb_countdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lb_test_title
            // 
            this.lb_test_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_test_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(66)))), ((int)(((byte)(50)))));
            this.lb_test_title.Location = new System.Drawing.Point(224, 9);
            this.lb_test_title.Name = "lb_test_title";
            this.lb_test_title.Size = new System.Drawing.Size(1049, 40);
            this.lb_test_title.TabIndex = 44;
            this.lb_test_title.Text = "Bài thi môn Giáo dục công dân";
            this.lb_test_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TestDoingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1288, 547);
            this.ControlBox = false;
            this.Controls.Add(this.lb_test_title);
            this.Controls.Add(this.lb_countdown);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_question);
            this.Controls.Add(this.group_type);
            this.Controls.Add(this.group_answers);
            this.Controls.Add(this.btn_previous);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.rtxt_question_title);
            this.Controls.Add(this.group_questions_list);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1304, 586);
            this.MinimumSize = new System.Drawing.Size(1304, 586);
            this.Name = "TestDoingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Làm bài thi";
            this.Load += new System.EventHandler(this.TestDoingForm_Load);
            this.group_type.ResumeLayout(false);
            this.group_type.PerformLayout();
            this.group_answers.ResumeLayout(false);
            this.group_answers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_type;
        private System.Windows.Forms.RadioButton rd_answer_multiple;
        private System.Windows.Forms.RadioButton rd_answer_single;
        private System.Windows.Forms.GroupBox group_answers;
        private System.Windows.Forms.RadioButton rd_answer_D;
        private System.Windows.Forms.RichTextBox rtxt_answerD;
        private System.Windows.Forms.RadioButton rd_answer_C;
        private System.Windows.Forms.RichTextBox rtxt_answerC;
        private System.Windows.Forms.RadioButton rd_answer_B;
        private System.Windows.Forms.RichTextBox rtxt_answerB;
        private System.Windows.Forms.RadioButton rd_answer_A;
        private System.Windows.Forms.RichTextBox rtxt_answerA;
        private System.Windows.Forms.Button btn_previous;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.RichTextBox rtxt_question_title;
        private System.Windows.Forms.GroupBox group_questions_list;
        private System.Windows.Forms.Label lb_question;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_countdown;
        private System.Windows.Forms.Label lb_test_title;
    }
}