namespace ExamsSystem.MyForms
{
    partial class TestResultReportForm
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
            this.label7 = new System.Windows.Forms.Label();
            this.cb_openstate = new System.Windows.Forms.ComboBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.data_tests_list = new System.Windows.Forms.DataGridView();
            this.cb_subjects = new System.Windows.Forms.ComboBox();
            this.btn_clearsearh = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.group_report_options = new System.Windows.Forms.GroupBox();
            this.checkbox_statictics = new System.Windows.Forms.CheckBox();
            this.checkbox_exam_details = new System.Windows.Forms.CheckBox();
            this.checkbox_creator = new System.Windows.Forms.CheckBox();
            this.btn_create_report = new System.Windows.Forms.Button();
            this.btn_review_data = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.data_tests_list)).BeginInit();
            this.group_report_options.SuspendLayout();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(277, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 21);
            this.label7.TabIndex = 50;
            this.label7.Text = "Trạng thái mở:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // cb_openstate
            // 
            this.cb_openstate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_openstate.FormattingEnabled = true;
            this.cb_openstate.Items.AddRange(new object[] {
            "Tất cả",
            "Chưa mở",
            "Mở"});
            this.cb_openstate.Location = new System.Drawing.Point(362, 117);
            this.cb_openstate.Name = "cb_openstate";
            this.cb_openstate.Size = new System.Drawing.Size(140, 21);
            this.cb_openstate.TabIndex = 49;
            // 
            // btn_search
            // 
            this.btn_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.ForeColor = System.Drawing.Color.White;
            this.btn_search.Location = new System.Drawing.Point(601, 110);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(83, 33);
            this.btn_search.TabIndex = 45;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 21);
            this.label5.TabIndex = 48;
            this.label5.Text = "Môn học:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // data_tests_list
            // 
            this.data_tests_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_tests_list.BackgroundColor = System.Drawing.Color.White;
            this.data_tests_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_tests_list.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data_tests_list.Location = new System.Drawing.Point(5, 152);
            this.data_tests_list.Name = "data_tests_list";
            this.data_tests_list.RowHeadersVisible = false;
            this.data_tests_list.Size = new System.Drawing.Size(768, 390);
            this.data_tests_list.TabIndex = 44;
            this.data_tests_list.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.data_tests_list_CellClick);
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
            this.cb_subjects.Location = new System.Drawing.Point(79, 117);
            this.cb_subjects.Name = "cb_subjects";
            this.cb_subjects.Size = new System.Drawing.Size(165, 21);
            this.cb_subjects.TabIndex = 47;
            // 
            // btn_clearsearh
            // 
            this.btn_clearsearh.BackColor = System.Drawing.Color.Gray;
            this.btn_clearsearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clearsearh.ForeColor = System.Drawing.Color.White;
            this.btn_clearsearh.Location = new System.Drawing.Point(690, 110);
            this.btn_clearsearh.Name = "btn_clearsearh";
            this.btn_clearsearh.Size = new System.Drawing.Size(83, 33);
            this.btn_clearsearh.TabIndex = 46;
            this.btn_clearsearh.Text = "Làm mới";
            this.btn_clearsearh.UseVisualStyleBackColor = false;
            this.btn_clearsearh.Click += new System.EventHandler(this.btn_clearsearh_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(1181, 48);
            this.label2.TabIndex = 43;
            this.label2.Text = "Báo cáo kết quả của bài thi";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // group_report_options
            // 
            this.group_report_options.Controls.Add(this.checkbox_statictics);
            this.group_report_options.Controls.Add(this.checkbox_exam_details);
            this.group_report_options.Controls.Add(this.checkbox_creator);
            this.group_report_options.Location = new System.Drawing.Point(819, 152);
            this.group_report_options.Name = "group_report_options";
            this.group_report_options.Size = new System.Drawing.Size(330, 98);
            this.group_report_options.TabIndex = 51;
            this.group_report_options.TabStop = false;
            this.group_report_options.Text = "Tùy chọn cho việc lập báo cáo kết quả bài thi";
            // 
            // checkbox_statictics
            // 
            this.checkbox_statictics.AutoSize = true;
            this.checkbox_statictics.Location = new System.Drawing.Point(6, 19);
            this.checkbox_statictics.Name = "checkbox_statictics";
            this.checkbox_statictics.Size = new System.Drawing.Size(142, 17);
            this.checkbox_statictics.TabIndex = 54;
            this.checkbox_statictics.Text = "Thống kê kết quả bài thi";
            this.checkbox_statictics.UseVisualStyleBackColor = true;
            // 
            // checkbox_exam_details
            // 
            this.checkbox_exam_details.AutoSize = true;
            this.checkbox_exam_details.Location = new System.Drawing.Point(6, 65);
            this.checkbox_exam_details.Name = "checkbox_exam_details";
            this.checkbox_exam_details.Size = new System.Drawing.Size(170, 17);
            this.checkbox_exam_details.TabIndex = 53;
            this.checkbox_exam_details.Text = "Hiển thị chi tiết thông tin đề thi";
            this.checkbox_exam_details.UseVisualStyleBackColor = true;
            // 
            // checkbox_creator
            // 
            this.checkbox_creator.AutoSize = true;
            this.checkbox_creator.Location = new System.Drawing.Point(6, 42);
            this.checkbox_creator.Name = "checkbox_creator";
            this.checkbox_creator.Size = new System.Drawing.Size(194, 17);
            this.checkbox_creator.TabIndex = 51;
            this.checkbox_creator.Text = "Hiển thị thông tin người lập báo cáo";
            this.checkbox_creator.UseVisualStyleBackColor = true;
            // 
            // btn_create_report
            // 
            this.btn_create_report.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_create_report.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_create_report.ForeColor = System.Drawing.Color.White;
            this.btn_create_report.Location = new System.Drawing.Point(819, 327);
            this.btn_create_report.Name = "btn_create_report";
            this.btn_create_report.Size = new System.Drawing.Size(330, 32);
            this.btn_create_report.TabIndex = 53;
            this.btn_create_report.Tag = "TestResultReport";
            this.btn_create_report.Text = "Lập báo cáo";
            this.btn_create_report.UseVisualStyleBackColor = false;
            this.btn_create_report.Click += new System.EventHandler(this.btn_create_report_Click);
            // 
            // btn_review_data
            // 
            this.btn_review_data.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.btn_review_data.Enabled = false;
            this.btn_review_data.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_review_data.ForeColor = System.Drawing.Color.White;
            this.btn_review_data.Location = new System.Drawing.Point(819, 289);
            this.btn_review_data.Name = "btn_review_data";
            this.btn_review_data.Size = new System.Drawing.Size(330, 32);
            this.btn_review_data.TabIndex = 54;
            this.btn_review_data.Tag = "TestResultReport";
            this.btn_review_data.Text = "Xem trước bảng dữ liệu được in";
            this.btn_review_data.UseVisualStyleBackColor = false;
            this.btn_review_data.Click += new System.EventHandler(this.btn_review_data_Click);
            // 
            // TestResultReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1181, 552);
            this.Controls.Add(this.btn_review_data);
            this.Controls.Add(this.btn_create_report);
            this.Controls.Add(this.group_report_options);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cb_openstate);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.data_tests_list);
            this.Controls.Add(this.cb_subjects);
            this.Controls.Add(this.btn_clearsearh);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1197, 591);
            this.MinimumSize = new System.Drawing.Size(1197, 591);
            this.Name = "TestResultReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Báo cáo kết quả của bài thi";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TestResultReportForm_FormClosed);
            this.Load += new System.EventHandler(this.TestResultReportForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_tests_list)).EndInit();
            this.group_report_options.ResumeLayout(false);
            this.group_report_options.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cb_openstate;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView data_tests_list;
        private System.Windows.Forms.ComboBox cb_subjects;
        private System.Windows.Forms.Button btn_clearsearh;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox group_report_options;
        private System.Windows.Forms.CheckBox checkbox_creator;
        private System.Windows.Forms.Button btn_create_report;
        private System.Windows.Forms.CheckBox checkbox_exam_details;
        private System.Windows.Forms.Button btn_review_data;
        private System.Windows.Forms.CheckBox checkbox_statictics;
    }
}