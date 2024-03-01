namespace ExamsSystem.MyForms
{
    partial class ReviewDataTabeForm
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
            this.data_list = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.data_list)).BeginInit();
            this.SuspendLayout();
            // 
            // data_list
            // 
            this.data_list.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.data_list.BackgroundColor = System.Drawing.Color.White;
            this.data_list.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_list.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.data_list.Location = new System.Drawing.Point(89, 93);
            this.data_list.Name = "data_list";
            this.data_list.RowHeadersVisible = false;
            this.data_list.Size = new System.Drawing.Size(908, 390);
            this.data_list.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1112, 48);
            this.label1.TabIndex = 46;
            this.label1.Text = "Kết quả bảng dữ liệu trước khi in";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ReviewDataTabeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 495);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.data_list);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1128, 534);
            this.MinimumSize = new System.Drawing.Size(1128, 534);
            this.Name = "ReviewDataTabeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xem trước dữ liệu khi in";
            this.Load += new System.EventHandler(this.ReviewDataTabeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.data_list)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView data_list;
        private System.Windows.Forms.Label label1;
    }
}