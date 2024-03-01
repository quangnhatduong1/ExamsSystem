namespace ExamsSystem.MyForms
{
    partial class HomeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            this.panel_menu_bottom = new System.Windows.Forms.Panel();
            this.panel_menu_top = new System.Windows.Forms.Panel();
            this.lb_hello_title = new System.Windows.Forms.Label();
            this.img_hello_icon = new System.Windows.Forms.PictureBox();
            this.img_logout = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_home_title = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.img_hello_icon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logout)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_menu_bottom
            // 
            this.panel_menu_bottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_menu_bottom.Location = new System.Drawing.Point(0, 340);
            this.panel_menu_bottom.Name = "panel_menu_bottom";
            this.panel_menu_bottom.Size = new System.Drawing.Size(1251, 207);
            this.panel_menu_bottom.TabIndex = 5;
            // 
            // panel_menu_top
            // 
            this.panel_menu_top.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_menu_top.Location = new System.Drawing.Point(0, 112);
            this.panel_menu_top.Name = "panel_menu_top";
            this.panel_menu_top.Size = new System.Drawing.Size(1251, 200);
            this.panel_menu_top.TabIndex = 4;
            // 
            // lb_hello_title
            // 
            this.lb_hello_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_hello_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(66)))), ((int)(((byte)(50)))));
            this.lb_hello_title.Location = new System.Drawing.Point(50, 0);
            this.lb_hello_title.Name = "lb_hello_title";
            this.lb_hello_title.Size = new System.Drawing.Size(710, 44);
            this.lb_hello_title.TabIndex = 3;
            this.lb_hello_title.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // img_hello_icon
            // 
            this.img_hello_icon.Dock = System.Windows.Forms.DockStyle.Left;
            this.img_hello_icon.Image = ((System.Drawing.Image)(resources.GetObject("img_hello_icon.Image")));
            this.img_hello_icon.Location = new System.Drawing.Point(0, 0);
            this.img_hello_icon.Name = "img_hello_icon";
            this.img_hello_icon.Size = new System.Drawing.Size(44, 44);
            this.img_hello_icon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_hello_icon.TabIndex = 2;
            this.img_hello_icon.TabStop = false;
            // 
            // img_logout
            // 
            this.img_logout.Dock = System.Windows.Forms.DockStyle.Right;
            this.img_logout.Image = ((System.Drawing.Image)(resources.GetObject("img_logout.Image")));
            this.img_logout.Location = new System.Drawing.Point(1217, 0);
            this.img_logout.Name = "img_logout";
            this.img_logout.Size = new System.Drawing.Size(34, 44);
            this.img_logout.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.img_logout.TabIndex = 0;
            this.img_logout.TabStop = false;
            this.img_logout.Click += new System.EventHandler(this.img_logout_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lb_hello_title);
            this.panel2.Controls.Add(this.img_hello_icon);
            this.panel2.Controls.Add(this.img_logout);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1251, 44);
            this.panel2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lb_home_title);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1251, 112);
            this.panel1.TabIndex = 3;
            // 
            // lb_home_title
            // 
            this.lb_home_title.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lb_home_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_home_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(86)))), ((int)(((byte)(210)))));
            this.lb_home_title.Location = new System.Drawing.Point(0, 44);
            this.lb_home_title.Name = "lb_home_title";
            this.lb_home_title.Size = new System.Drawing.Size(1251, 68);
            this.lb_home_title.TabIndex = 1;
            this.lb_home_title.Text = "Trang quản lý hệ thống ";
            this.lb_home_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Lavender;
            this.ClientSize = new System.Drawing.Size(1251, 547);
            this.ControlBox = false;
            this.Controls.Add(this.panel_menu_bottom);
            this.Controls.Add(this.panel_menu_top);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1267, 586);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1267, 586);
            this.Name = "HomeForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Trang chủ";
            ((System.ComponentModel.ISupportInitialize)(this.img_hello_icon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.img_logout)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel_menu_bottom;
        private System.Windows.Forms.Panel panel_menu_top;
        private System.Windows.Forms.Label lb_hello_title;
        private System.Windows.Forms.PictureBox img_hello_icon;
        private System.Windows.Forms.PictureBox img_logout;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_home_title;
    }
}