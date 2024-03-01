namespace ExamsSystem.MyForms
{
    partial class CreateQuestionForm
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
            this.group_answers = new System.Windows.Forms.GroupBox();
            this.rd_answer_D = new System.Windows.Forms.RadioButton();
            this.rtxt_answerD = new System.Windows.Forms.RichTextBox();
            this.menu_interact_richtext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.item_copy = new System.Windows.Forms.ToolStripMenuItem();
            this.item_paste = new System.Windows.Forms.ToolStripMenuItem();
            this.item_clear = new System.Windows.Forms.ToolStripMenuItem();
            this.rd_answer_C = new System.Windows.Forms.RadioButton();
            this.rtxt_answerC = new System.Windows.Forms.RichTextBox();
            this.rd_answer_B = new System.Windows.Forms.RadioButton();
            this.rtxt_answerB = new System.Windows.Forms.RichTextBox();
            this.rd_answer_A = new System.Windows.Forms.RadioButton();
            this.rtxt_answerA = new System.Windows.Forms.RichTextBox();
            this.rtxt_question_title = new System.Windows.Forms.RichTextBox();
            this.lb_question = new System.Windows.Forms.Label();
            this.btn_create_question = new System.Windows.Forms.Button();
            this.btn_paste_question = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.group_subjects = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.group_type = new System.Windows.Forms.GroupBox();
            this.rd_answer_multiple = new System.Windows.Forms.RadioButton();
            this.rd_answer_single = new System.Windows.Forms.RadioButton();
            this.btn_question_clear = new System.Windows.Forms.Button();
            this.btn_question_manager = new System.Windows.Forms.Button();
            this.group_answers.SuspendLayout();
            this.menu_interact_richtext.SuspendLayout();
            this.group_subjects.SuspendLayout();
            this.group_type.SuspendLayout();
            this.SuspendLayout();
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
            this.group_answers.Location = new System.Drawing.Point(12, 158);
            this.group_answers.Name = "group_answers";
            this.group_answers.Size = new System.Drawing.Size(1051, 335);
            this.group_answers.TabIndex = 26;
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
            this.menu_interact_richtext.Opening += new System.ComponentModel.CancelEventHandler(this.menu_interact_richtext_Opening);
            // 
            // item_copy
            // 
            this.item_copy.Name = "item_copy";
            this.item_copy.Size = new System.Drawing.Size(122, 22);
            this.item_copy.Tag = "10";
            this.item_copy.Text = "Sao chép";
            this.item_copy.Click += new System.EventHandler(this.menu_item_click);
            // 
            // item_paste
            // 
            this.item_paste.Name = "item_paste";
            this.item_paste.Size = new System.Drawing.Size(122, 22);
            this.item_paste.Tag = "11";
            this.item_paste.Text = "Dán";
            this.item_paste.Click += new System.EventHandler(this.menu_item_click);
            // 
            // item_clear
            // 
            this.item_clear.Name = "item_clear";
            this.item_clear.Size = new System.Drawing.Size(122, 22);
            this.item_clear.Tag = "12";
            this.item_clear.Text = "Làm mới";
            this.item_clear.Click += new System.EventHandler(this.menu_item_click);
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
            // rtxt_question_title
            // 
            this.rtxt_question_title.ContextMenuStrip = this.menu_interact_richtext;
            this.rtxt_question_title.Location = new System.Drawing.Point(12, 56);
            this.rtxt_question_title.Name = "rtxt_question_title";
            this.rtxt_question_title.Size = new System.Drawing.Size(1053, 96);
            this.rtxt_question_title.TabIndex = 27;
            this.rtxt_question_title.Tag = "0";
            this.rtxt_question_title.Text = "";
            // 
            // lb_question
            // 
            this.lb_question.AutoSize = true;
            this.lb_question.Location = new System.Drawing.Point(12, 40);
            this.lb_question.Name = "lb_question";
            this.lb_question.Size = new System.Drawing.Size(43, 13);
            this.lb_question.TabIndex = 28;
            this.lb_question.Text = "Câu hỏi";
            // 
            // btn_create_question
            // 
            this.btn_create_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_create_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_question.ForeColor = System.Drawing.Color.White;
            this.btn_create_question.Location = new System.Drawing.Point(919, 504);
            this.btn_create_question.Name = "btn_create_question";
            this.btn_create_question.Size = new System.Drawing.Size(146, 32);
            this.btn_create_question.TabIndex = 29;
            this.btn_create_question.Tag = "5";
            this.btn_create_question.Text = "Tạo";
            this.btn_create_question.UseVisualStyleBackColor = false;
            this.btn_create_question.Click += new System.EventHandler(this.btn_question_click);
            // 
            // btn_paste_question
            // 
            this.btn_paste_question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_paste_question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paste_question.ForeColor = System.Drawing.Color.White;
            this.btn_paste_question.Location = new System.Drawing.Point(767, 504);
            this.btn_paste_question.Name = "btn_paste_question";
            this.btn_paste_question.Size = new System.Drawing.Size(146, 32);
            this.btn_paste_question.TabIndex = 30;
            this.btn_paste_question.Tag = "4";
            this.btn_paste_question.Text = "Dán câu hỏi";
            this.btn_paste_question.UseVisualStyleBackColor = false;
            this.btn_paste_question.Click += new System.EventHandler(this.btn_question_click);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(1234, 40);
            this.label5.TabIndex = 31;
            this.label5.Text = "Tạo câu hỏi mới";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_subjects
            // 
            this.group_subjects.Controls.Add(this.radioButton3);
            this.group_subjects.Controls.Add(this.radioButton2);
            this.group_subjects.Controls.Add(this.radioButton1);
            this.group_subjects.Location = new System.Drawing.Point(1080, 158);
            this.group_subjects.Name = "group_subjects";
            this.group_subjects.Size = new System.Drawing.Size(128, 93);
            this.group_subjects.TabIndex = 15;
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
            // group_type
            // 
            this.group_type.Controls.Add(this.rd_answer_multiple);
            this.group_type.Controls.Add(this.rd_answer_single);
            this.group_type.Location = new System.Drawing.Point(1080, 56);
            this.group_type.Name = "group_type";
            this.group_type.Size = new System.Drawing.Size(128, 96);
            this.group_type.TabIndex = 32;
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
            // btn_question_clear
            // 
            this.btn_question_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_question_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_question_clear.ForeColor = System.Drawing.Color.White;
            this.btn_question_clear.Location = new System.Drawing.Point(615, 504);
            this.btn_question_clear.Name = "btn_question_clear";
            this.btn_question_clear.Size = new System.Drawing.Size(146, 32);
            this.btn_question_clear.TabIndex = 33;
            this.btn_question_clear.Tag = "3";
            this.btn_question_clear.Text = "Làm mới";
            this.btn_question_clear.UseVisualStyleBackColor = false;
            this.btn_question_clear.Click += new System.EventHandler(this.btn_question_click);
            // 
            // btn_question_manager
            // 
            this.btn_question_manager.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_question_manager.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_question_manager.ForeColor = System.Drawing.Color.White;
            this.btn_question_manager.Location = new System.Drawing.Point(428, 504);
            this.btn_question_manager.Name = "btn_question_manager";
            this.btn_question_manager.Size = new System.Drawing.Size(181, 32);
            this.btn_question_manager.TabIndex = 34;
            this.btn_question_manager.Tag = "1";
            this.btn_question_manager.Text = "Chọn từ câu hỏi có sẵn";
            this.btn_question_manager.UseVisualStyleBackColor = false;
            this.btn_question_manager.Click += new System.EventHandler(this.btn_question_click);
            // 
            // CreateQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1234, 548);
            this.Controls.Add(this.btn_question_manager);
            this.Controls.Add(this.btn_question_clear);
            this.Controls.Add(this.group_type);
            this.Controls.Add(this.group_subjects);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btn_paste_question);
            this.Controls.Add(this.lb_question);
            this.Controls.Add(this.rtxt_question_title);
            this.Controls.Add(this.group_answers);
            this.Controls.Add(this.btn_create_question);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1250, 587);
            this.MinimumSize = new System.Drawing.Size(1250, 587);
            this.Name = "CreateQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo câu hỏi";
            this.Load += new System.EventHandler(this.CreateQuestionForm_Load);
            this.group_answers.ResumeLayout(false);
            this.group_answers.PerformLayout();
            this.menu_interact_richtext.ResumeLayout(false);
            this.group_subjects.ResumeLayout(false);
            this.group_subjects.PerformLayout();
            this.group_type.ResumeLayout(false);
            this.group_type.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox group_answers;
        private System.Windows.Forms.RadioButton rd_answer_D;
        private System.Windows.Forms.RichTextBox rtxt_answerD;
        private System.Windows.Forms.RadioButton rd_answer_C;
        private System.Windows.Forms.RichTextBox rtxt_answerC;
        private System.Windows.Forms.RadioButton rd_answer_B;
        private System.Windows.Forms.RichTextBox rtxt_answerB;
        private System.Windows.Forms.RadioButton rd_answer_A;
        private System.Windows.Forms.RichTextBox rtxt_answerA;
        private System.Windows.Forms.RichTextBox rtxt_question_title;
        private System.Windows.Forms.Label lb_question;
        private System.Windows.Forms.Button btn_create_question;
        private System.Windows.Forms.Button btn_paste_question;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox group_subjects;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ContextMenuStrip menu_interact_richtext;
        private System.Windows.Forms.ToolStripMenuItem item_copy;
        private System.Windows.Forms.ToolStripMenuItem item_paste;
        private System.Windows.Forms.ToolStripMenuItem item_clear;
        private System.Windows.Forms.GroupBox group_type;
        private System.Windows.Forms.RadioButton rd_answer_multiple;
        private System.Windows.Forms.RadioButton rd_answer_single;
        private System.Windows.Forms.Button btn_question_clear;
        private System.Windows.Forms.Button btn_question_manager;
    }
}