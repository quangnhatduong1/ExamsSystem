namespace ExamsSystem.MyForms
{
    partial class QuestionDetailsForm
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
            this.btn_question_clear = new System.Windows.Forms.Button();
            this.rd_answer_D = new System.Windows.Forms.RadioButton();
            this.rtxt_answerD = new System.Windows.Forms.RichTextBox();
            this.menu_interact_richtext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.item_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.item_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.rd_answer_multiple = new System.Windows.Forms.RadioButton();
            this.group_type = new System.Windows.Forms.GroupBox();
            this.rd_answer_single = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rd_answer_C = new System.Windows.Forms.RadioButton();
            this.rtxt_answerC = new System.Windows.Forms.RichTextBox();
            this.rd_answer_B = new System.Windows.Forms.RadioButton();
            this.rtxt_answerB = new System.Windows.Forms.RichTextBox();
            this.rd_answer_A = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.group_subjects = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_copy_question = new System.Windows.Forms.Button();
            this.rtxt_answerA = new System.Windows.Forms.RichTextBox();
            this.lb_question = new System.Windows.Forms.Label();
            this.rtxt_question_title = new System.Windows.Forms.RichTextBox();
            this.btn_save_question = new System.Windows.Forms.Button();
            this.group_answers = new System.Windows.Forms.GroupBox();
            this.cb_used = new System.Windows.Forms.CheckBox();
            this.btn_delete_question = new System.Windows.Forms.Button();
            this.menu_interact_richtext.SuspendLayout();
            this.group_type.SuspendLayout();
            this.group_subjects.SuspendLayout();
            this.group_answers.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_question_clear
            // 
            this.btn_question_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_question_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_question_clear.ForeColor = System.Drawing.Color.White;
            this.btn_question_clear.Location = new System.Drawing.Point(615, 497);
            this.btn_question_clear.Name = "btn_question_clear";
            this.btn_question_clear.Size = new System.Drawing.Size(146, 32);
            this.btn_question_clear.TabIndex = 42;
            this.btn_question_clear.Tag = "3";
            this.btn_question_clear.Text = "Làm mới";
            this.btn_question_clear.UseVisualStyleBackColor = false;
            this.btn_question_clear.Click += new System.EventHandler(this.btn_question_clear_Click);
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
            this.rtxt_answerD.ContextMenuStrip = this.menu_interact_richtext;
            this.rtxt_answerD.Location = new System.Drawing.Point(67, 241);
            this.rtxt_answerD.Name = "rtxt_answerD";
            this.rtxt_answerD.Size = new System.Drawing.Size(978, 68);
            this.rtxt_answerD.TabIndex = 12;
            this.rtxt_answerD.Tag = "4";
            this.rtxt_answerD.Text = "";
            // 
            // menu_interact_richtext
            // 
            this.menu_interact_richtext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.item_copy,
            this.item_paste,
            this.item_clear});
            this.menu_interact_richtext.Name = "menu_interact_richtext";
            this.menu_interact_richtext.Size = new System.Drawing.Size(123, 70);
            // 
            // item_copy
            // 
            this.item_copy.Name = "item_copy";
            this.item_copy.Size = new System.Drawing.Size(122, 22);
            this.item_copy.Tag = "copy_text";
            this.item_copy.Text = "Sao chép";
            // 
            // item_paste
            // 
            this.item_paste.Name = "item_paste";
            this.item_paste.Size = new System.Drawing.Size(122, 22);
            this.item_paste.Tag = "paste_text";
            this.item_paste.Text = "Dán";
            // 
            // item_clear
            // 
            this.item_clear.Name = "item_clear";
            this.item_clear.Size = new System.Drawing.Size(122, 22);
            this.item_clear.Tag = "clear_text";
            this.item_clear.Text = "Làm mới";
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
            this.rd_answer_multiple.Click += new System.EventHandler(this.rd_answer_single_Click);
            // 
            // group_type
            // 
            this.group_type.Controls.Add(this.rd_answer_multiple);
            this.group_type.Controls.Add(this.rd_answer_single);
            this.group_type.Location = new System.Drawing.Point(1080, 49);
            this.group_type.Name = "group_type";
            this.group_type.Size = new System.Drawing.Size(128, 96);
            this.group_type.TabIndex = 41;
            this.group_type.TabStop = false;
            this.group_type.Text = "Dạng câu hỏi";
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
            this.rd_answer_single.Click += new System.EventHandler(this.rd_answer_single_Click);
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
            this.rtxt_answerC.ContextMenuStrip = this.menu_interact_richtext;
            this.rtxt_answerC.Location = new System.Drawing.Point(67, 167);
            this.rtxt_answerC.Name = "rtxt_answerC";
            this.rtxt_answerC.Size = new System.Drawing.Size(978, 68);
            this.rtxt_answerC.TabIndex = 10;
            this.rtxt_answerC.Tag = "3";
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
            this.rtxt_answerB.ContextMenuStrip = this.menu_interact_richtext;
            this.rtxt_answerB.Location = new System.Drawing.Point(67, 93);
            this.rtxt_answerB.Name = "rtxt_answerB";
            this.rtxt_answerB.Size = new System.Drawing.Size(978, 68);
            this.rtxt_answerB.TabIndex = 8;
            this.rtxt_answerB.Tag = "2";
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
            // group_subjects
            // 
            this.group_subjects.Controls.Add(this.radioButton3);
            this.group_subjects.Controls.Add(this.radioButton2);
            this.group_subjects.Controls.Add(this.radioButton1);
            this.group_subjects.Location = new System.Drawing.Point(1080, 151);
            this.group_subjects.Name = "group_subjects";
            this.group_subjects.Size = new System.Drawing.Size(128, 93);
            this.group_subjects.TabIndex = 34;
            this.group_subjects.TabStop = false;
            this.group_subjects.Text = "Môn học";
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1250, 33);
            this.label5.TabIndex = 40;
            this.label5.Text = "Chi tiết câu hỏi";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_copy_question
            // 
            this.btn_copy_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_copy_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_copy_question.ForeColor = System.Drawing.Color.White;
            this.btn_copy_question.Location = new System.Drawing.Point(767, 497);
            this.btn_copy_question.Name = "btn_copy_question";
            this.btn_copy_question.Size = new System.Drawing.Size(146, 32);
            this.btn_copy_question.TabIndex = 39;
            this.btn_copy_question.Tag = "4";
            this.btn_copy_question.Text = "Sao chép câu hỏi";
            this.btn_copy_question.UseVisualStyleBackColor = false;
            this.btn_copy_question.Click += new System.EventHandler(this.btn_copy_question_Click);
            // 
            // rtxt_answerA
            // 
            this.rtxt_answerA.ContextMenuStrip = this.menu_interact_richtext;
            this.rtxt_answerA.Location = new System.Drawing.Point(67, 19);
            this.rtxt_answerA.Name = "rtxt_answerA";
            this.rtxt_answerA.Size = new System.Drawing.Size(978, 68);
            this.rtxt_answerA.TabIndex = 6;
            this.rtxt_answerA.Tag = "1";
            this.rtxt_answerA.Text = "";
            // 
            // lb_question
            // 
            this.lb_question.AutoSize = true;
            this.lb_question.Location = new System.Drawing.Point(12, 33);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(43, 13);
            this.lb_question.TabIndex = 37;
            this.lb_question.Text = "Câu hỏi";
            // 
            // rtxt_question_title
            // 
            this.rtxt_question_title.ContextMenuStrip = this.menu_interact_richtext;
            this.rtxt_question_title.Location = new System.Drawing.Point(12, 49);
            this.rtxt_question_title.Name = "rtxt_question_title";
            this.rtxt_question_title.Size = new System.Drawing.Size(1053, 96);
            this.rtxt_question_title.TabIndex = 36;
            this.rtxt_question_title.Tag = "0";
            this.rtxt_question_title.Text = "";
            // 
            // btn_save_question
            // 
            this.btn_save_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_save_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save_question.ForeColor = System.Drawing.Color.White;
            this.btn_save_question.Location = new System.Drawing.Point(919, 497);
            this.btn_save_question.Name = "btn_save_question";
            this.btn_save_question.Size = new System.Drawing.Size(146, 32);
            this.btn_save_question.TabIndex = 38;
            this.btn_save_question.Tag = "5";
            this.btn_save_question.Text = "Lưu";
            this.btn_save_question.UseVisualStyleBackColor = false;
            this.btn_save_question.Click += new System.EventHandler(this.btn_save_question_Click);
            // 
            // group_answers
            // 
            this.group_answers.Controls.Add(this.rtxt_answerC);
            this.group_answers.Controls.Add(this.rd_answer_D);
            this.group_answers.Controls.Add(this.rtxt_answerD);
            this.group_answers.Controls.Add(this.rd_answer_C);
            this.group_answers.Controls.Add(this.rd_answer_B);
            this.group_answers.Controls.Add(this.rtxt_answerB);
            this.group_answers.Controls.Add(this.rd_answer_A);
            this.group_answers.Controls.Add(this.rtxt_answerA);
            this.group_answers.Location = new System.Drawing.Point(12, 151);
            this.group_answers.Name = "group_answers";
            this.group_answers.Size = new System.Drawing.Size(1051, 335);
            this.group_answers.TabIndex = 35;
            this.group_answers.TabStop = false;
            this.group_answers.Text = "Câu trả lời";
            // 
            // cb_used
            // 
            this.cb_used.AutoSize = true;
            this.cb_used.Enabled = false;
            this.cb_used.Location = new System.Drawing.Point(1083, 250);
            this.cb_used.Name = "cb_used";
            this.cb_used.Size = new System.Drawing.Size(95, 17);
            this.cb_used.TabIndex = 43;
            this.cb_used.Text = "Đã được dùng";
            this.cb_used.UseVisualStyleBackColor = true;
            // 
            // btn_delete_question
            // 
            this.btn_delete_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_delete_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete_question.ForeColor = System.Drawing.Color.White;
            this.btn_delete_question.Location = new System.Drawing.Point(463, 497);
            this.btn_delete_question.Name = "btn_delete_question";
            this.btn_delete_question.Size = new System.Drawing.Size(146, 32);
            this.btn_delete_question.TabIndex = 44;
            this.btn_delete_question.Tag = "3";
            this.btn_delete_question.Text = "Xóa";
            this.btn_delete_question.UseVisualStyleBackColor = false;
            this.btn_delete_question.Click += new System.EventHandler(this.btn_delete_question_Click);
            // 
            // QuestionDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1250, 535);
            this.Controls.Add(this.btn_delete_question);
            this.Controls.Add(this.cb_used);
            this.Controls.Add(this.btn_question_clear);
            this.Controls.Add(this.group_type);
            this.Controls.Add(this.group_subjects);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_copy_question);
            this.Controls.Add(this.lb_question);
            this.Controls.Add(this.rtxt_question_title);
            this.Controls.Add(this.btn_save_question);
            this.Controls.Add(this.group_answers);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1266, 574);
            this.MinimumSize = new System.Drawing.Size(1266, 574);
            this.Name = "QuestionDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết câu hỏi";
            this.Load += new System.EventHandler(this.QuestionDetailsForm_Load);
            this.menu_interact_richtext.ResumeLayout(false);
            this.group_type.ResumeLayout(false);
            this.group_type.PerformLayout();
            this.group_subjects.ResumeLayout(false);
            this.group_subjects.PerformLayout();
            this.group_answers.ResumeLayout(false);
            this.group_answers.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_question_clear;
        private System.Windows.Forms.RadioButton rd_answer_D;
        private System.Windows.Forms.RichTextBox rtxt_answerD;
        private System.Windows.Forms.ContextMenuStrip menu_interact_richtext;
        private System.Windows.Forms.ToolStripMenuItem item_copy;
        private System.Windows.Forms.ToolStripMenuItem item_paste;
        private System.Windows.Forms.ToolStripMenuItem item_clear;
        private System.Windows.Forms.RadioButton rd_answer_multiple;
        private System.Windows.Forms.GroupBox group_type;
        private System.Windows.Forms.RadioButton rd_answer_single;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rd_answer_C;
        private System.Windows.Forms.RichTextBox rtxt_answerC;
        private System.Windows.Forms.RadioButton rd_answer_B;
        private System.Windows.Forms.RichTextBox rtxt_answerB;
        private System.Windows.Forms.RadioButton rd_answer_A;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox group_subjects;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_copy_question;
        private System.Windows.Forms.RichTextBox rtxt_answerA;
        private System.Windows.Forms.Label lb_question;
        private System.Windows.Forms.RichTextBox rtxt_question_title;
        private System.Windows.Forms.Button btn_save_question;
        private System.Windows.Forms.GroupBox group_answers;
        private System.Windows.Forms.CheckBox cb_used;
        private System.Windows.Forms.Button btn_delete_question;
    }
}