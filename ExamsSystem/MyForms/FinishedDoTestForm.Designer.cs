namespace ExamsSystem.MyForms
{
    partial class FinishedDoTestForm
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
            this.lb_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_testid = new System.Windows.Forms.TextBox();
            this.txt_dotime = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_create_test = new System.Windows.Forms.Button();
            this.lb_message = new System.Windows.Forms.Label();
            this.txt_startdotime = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_submittime = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.lb_title.Location = new System.Drawing.Point(-1, 2);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(800, 53);
            this.lb_title.TabIndex = 2;
            this.lb_title.Text = "Bạn đã hoàn thành bài thi";
            this.lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(143, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Mã bài thi";
            // 
            // txt_testid
            // 
            this.txt_testid.Enabled = false;
            this.txt_testid.Location = new System.Drawing.Point(361, 93);
            this.txt_testid.Name = "txt_testid";
            this.txt_testid.Size = new System.Drawing.Size(242, 20);
            this.txt_testid.TabIndex = 57;
            // 
            // txt_dotime
            // 
            this.txt_dotime.Enabled = false;
            this.txt_dotime.Location = new System.Drawing.Point(361, 135);
            this.txt_dotime.Name = "txt_dotime";
            this.txt_dotime.Size = new System.Drawing.Size(242, 20);
            this.txt_dotime.TabIndex = 61;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label3.Location = new System.Drawing.Point(143, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 17);
            this.label3.TabIndex = 60;
            this.label3.Text = "Thời gian làm bài";
            // 
            // btn_create_test
            // 
            this.btn_create_test.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_create_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_test.ForeColor = System.Drawing.Color.White;
            this.btn_create_test.Location = new System.Drawing.Point(146, 325);
            this.btn_create_test.Name = "btn_create_test";
            this.btn_create_test.Size = new System.Drawing.Size(457, 32);
            this.btn_create_test.TabIndex = 64;
            this.btn_create_test.Text = "Xác nhận";
            this.btn_create_test.UseVisualStyleBackColor = false;
            this.btn_create_test.Click += new System.EventHandler(this.btn_create_test_Click);
            // 
            // lb_message
            // 
            this.lb_message.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_message.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(66)))), ((int)(((byte)(50)))));
            this.lb_message.Location = new System.Drawing.Point(146, 264);
            this.lb_message.Name = "lb_message";
            this.lb_message.Size = new System.Drawing.Size(457, 40);
            this.lb_message.TabIndex = 65;
            this.lb_message.Text = "Vui lòng chọn chức năng xem kêt quả thi để xem rõ kết quả bài thi";
            this.lb_message.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txt_startdotime
            // 
            this.txt_startdotime.Enabled = false;
            this.txt_startdotime.Location = new System.Drawing.Point(361, 179);
            this.txt_startdotime.Name = "txt_startdotime";
            this.txt_startdotime.Size = new System.Drawing.Size(242, 20);
            this.txt_startdotime.TabIndex = 67;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label4.Location = new System.Drawing.Point(143, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 17);
            this.label4.TabIndex = 66;
            this.label4.Text = "Thời gian bắt đầu làm bài";
            // 
            // txt_submittime
            // 
            this.txt_submittime.Enabled = false;
            this.txt_submittime.Location = new System.Drawing.Point(361, 224);
            this.txt_submittime.Name = "txt_submittime";
            this.txt_submittime.Size = new System.Drawing.Size(242, 20);
            this.txt_submittime.TabIndex = 69;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label5.Location = new System.Drawing.Point(143, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(135, 17);
            this.label5.TabIndex = 68;
            this.label5.Text = "Thời gian nộp bài";
            // 
            // FinishedDoTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.txt_submittime);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_startdotime);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lb_message);
            this.Controls.Add(this.btn_create_test);
            this.Controls.Add(this.txt_dotime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_testid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_title);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 489);
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "FinishedDoTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hoàn thành bài thi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FinishedDoTestForm_FormClosed);
            this.Load += new System.EventHandler(this.FinishedDoTestForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_testid;
        private System.Windows.Forms.TextBox txt_dotime;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_create_test;
        private System.Windows.Forms.Label lb_message;
        private System.Windows.Forms.TextBox txt_startdotime;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_submittime;
        private System.Windows.Forms.Label label5;
    }
}