namespace ExamsSystem.MyForms
{
    partial class CreateExamForm
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
            this.label8 = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_dotime = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_questions_count = new System.Windows.Forms.TextBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_paste = new System.Windows.Forms.Button();
            this.group_subjects = new System.Windows.Forms.GroupBox();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(3, 36);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(599, 29);
            this.label8.TabIndex = 1;
            this.label8.Text = "Tạo đề thi";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_register.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.ForeColor = System.Drawing.Color.White;
            this.btn_register.Location = new System.Drawing.Point(177, 351);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(253, 32);
            this.btn_register.TabIndex = 4;
            this.btn_register.Text = "Xác nhận";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(179, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(251, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thời gian làm bài (tính theo phút)";
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
            this.cb_dotime.Location = new System.Drawing.Point(182, 125);
            this.cb_dotime.Name = "cb_dotime";
            this.cb_dotime.Size = new System.Drawing.Size(253, 21);
            this.cb_dotime.TabIndex = 18;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txt_questions_count);
            this.panel2.Controls.Add(this.btn_clear);
            this.panel2.Controls.Add(this.btn_paste);
            this.panel2.Controls.Add(this.cb_dotime);
            this.panel2.Controls.Add(this.group_subjects);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btn_register);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(602, 503);
            this.panel2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(179, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "Số lượng câu hỏi";
            // 
            // txt_questions_count
            // 
            this.txt_questions_count.Enabled = false;
            this.txt_questions_count.Location = new System.Drawing.Point(182, 183);
            this.txt_questions_count.Name = "txt_questions_count";
            this.txt_questions_count.Size = new System.Drawing.Size(253, 20);
            this.txt_questions_count.TabIndex = 21;
            this.txt_questions_count.Text = "0";
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.ForeColor = System.Drawing.Color.White;
            this.btn_clear.Location = new System.Drawing.Point(177, 427);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(253, 32);
            this.btn_clear.TabIndex = 20;
            this.btn_clear.Text = "Làm mới";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_paste
            // 
            this.btn_paste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_paste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_paste.ForeColor = System.Drawing.Color.White;
            this.btn_paste.Location = new System.Drawing.Point(177, 389);
            this.btn_paste.Name = "btn_paste";
            this.btn_paste.Size = new System.Drawing.Size(253, 32);
            this.btn_paste.TabIndex = 19;
            this.btn_paste.Text = "Dán từ một đề thi";
            this.btn_paste.UseVisualStyleBackColor = false;
            this.btn_paste.Click += new System.EventHandler(this.btn_paste_Click);
            // 
            // group_subjects
            // 
            this.group_subjects.Location = new System.Drawing.Point(182, 227);
            this.group_subjects.Name = "group_subjects";
            this.group_subjects.Size = new System.Drawing.Size(253, 93);
            this.group_subjects.TabIndex = 14;
            this.group_subjects.TabStop = false;
            this.group_subjects.Text = "Môn học";
            // 
            // CreateExamForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 503);
            this.Controls.Add(this.panel2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(618, 542);
            this.MinimumSize = new System.Drawing.Size(618, 542);
            this.Name = "CreateExamForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tạo đề thi";
            this.Load += new System.EventHandler(this.CreateExamForm_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_dotime;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox group_subjects;
        private System.Windows.Forms.Button btn_paste;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_questions_count;
    }
}