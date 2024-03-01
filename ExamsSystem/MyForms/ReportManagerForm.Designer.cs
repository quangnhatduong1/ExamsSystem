namespace ExamsSystem.MyForms
{
    partial class ReportManagerForm
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
            this.btn_test_result_report = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(776, 29);
            this.label8.TabIndex = 2;
            this.label8.Text = "Hãy chọn loại báo cáo muốn in";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_test_result_report
            // 
            this.btn_test_result_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_test_result_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_test_result_report.ForeColor = System.Drawing.Color.White;
            this.btn_test_result_report.Location = new System.Drawing.Point(220, 151);
            this.btn_test_result_report.Name = "btn_test_result_report";
            this.btn_test_result_report.Size = new System.Drawing.Size(363, 32);
            this.btn_test_result_report.TabIndex = 20;
            this.btn_test_result_report.Tag = "TestResultReport";
            this.btn_test_result_report.Text = "Báo kết quả bài thi";
            this.btn_test_result_report.UseVisualStyleBackColor = false;
            this.btn_test_result_report.Click += new System.EventHandler(this.btn_test_result_report_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(220, 189);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(363, 32);
            this.button1.TabIndex = 21;
            this.button1.Tag = "TestResultReport";
            this.button1.Text = "Hủy";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ReportManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 370);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_test_result_report);
            this.Controls.Add(this.label8);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 409);
            this.MinimumSize = new System.Drawing.Size(816, 409);
            this.Name = "ReportManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý báo cáo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ReportManagerForm_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btn_test_result_report;
        private System.Windows.Forms.Button button1;
    }
}