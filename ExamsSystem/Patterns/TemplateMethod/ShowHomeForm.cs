using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamsSystem.MyForms;
using ExamsSystem.MyObjects;

namespace ExamsSystem.Patterns.TemplateMethod
{
    abstract class ShowHomeForm
    {
        //hiển thị câu chào dựa vào tên tài khoản
        public void showHelloTitle(Control label, Accounts account)
        {

            //lấy ra tên tài khoản của người dùng
            string username = account.Username;
            label = (Label)label;
            label.Text = $"Xin chào {username}";
        }
        //Hiển thị phần đầu (icon người dùng và title)
        public abstract void showTop(PictureBox icon, Control mainTitle, Accounts account);
        //Hiển thị phần menu chức năng
        public abstract HomeItem[] getHomeItem();
        public void show(HomeForm homeForm, Accounts account)
        {
            Control[] controls = homeForm.getHomeControls();        
            Label lb_hello_title = (Label) controls[0];       
            PictureBox img_hello_icon = (PictureBox)controls[1];          
            Label lb_home_title = (Label)controls[2];        
            Panel panel_menu_top = (Panel)controls[3];
            Panel panel_menu_bottom = (Panel)controls[4];
            //show câu chào
            showHelloTitle(lb_hello_title, account) ;
            //show phần top (bao gồm icon và tiêu đề trang chủ)
            showTop(img_hello_icon,lb_home_title, account);
            //show item chức năng
            HomeItem[] listItems = getHomeItem();
            for (int i = 0; i < listItems.Length; i++)
            {
                //lấy ra đối tượng item
                HomeItem homeItem = listItems[i];
                //gọi hàm tạo ra panel item
                Panel panel = (Panel)createHomeMenuItem(homeItem);
                if (i < 3)
                {

                    panel_menu_top.Controls.Add(panel);
                }
                else
                {
                    panel_menu_bottom.Controls.Add(panel);
                }
            }
            //Thiết lập sự kiện cho các Home Menu item
            setEventForHomeItem(panel_menu_top, panel_menu_bottom, homeForm);

        }
        //thiết lập sự kiện cho các Home Menu item
        public void setEventForHomeItem(Control panel_menu_top, Control panel_menu_bottom, HomeForm homeForm)
        {
            panel_menu_top = (Panel)panel_menu_top;
            panel_menu_bottom = (Panel)panel_menu_bottom;
            foreach (Control control in panel_menu_top.Controls){
                Panel panel = (Panel)control;
                //thiết lập sự kiện click cho các home Item Panel
                //lấy hình của panel ra
                PictureBox pictureBox = (PictureBox)panel.Controls[1]; // vị trí 1 là hình ảnh
                pictureBox.Click += new EventHandler(homeForm.HomeItem_panel_Click);
            }
            foreach (Control control in panel_menu_bottom.Controls)
            {
                Panel panel = (Panel)control;
                //thiết lập sự kiện click cho các home Item Panel
                //lấy hình của panel ra
                PictureBox pictureBox = (PictureBox)panel.Controls[1]; // vị trí 1 là hình ảnh
                pictureBox.Click += new EventHandler(homeForm.HomeItem_panel_Click);
            }
        }
        //tạo ra các item cho phần menu
        public Control createHomeMenuItem( HomeItem homeItem)
        {
            //lấy các giá trị ra
            string title = homeItem.Title;
            string tag = homeItem.Tag;
            Image img = homeItem.Img;
            int pointX = homeItem.PointX;
            int pointY = homeItem.PointY;
            //tạo phần tiêu đề (một label)
            Label lb_title = new Label();
            lb_title.Dock = System.Windows.Forms.DockStyle.Top;
            lb_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            lb_title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(237)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            lb_title.Location = new System.Drawing.Point(0, 0);
            lb_title.Name = "lb_"+tag;
            lb_title.Size = new System.Drawing.Size(188, 46);
            lb_title.TabIndex = 4;
            lb_title.Text = title;
            lb_title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            //tạo ra một image
            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = img;
            pictureBox.Location = new System.Drawing.Point(3, 49);
            pictureBox.Name = "img_"+tag;
            pictureBox.Tag = tag; //thông qua tag để xử lý sự kiện
            pictureBox.Size = new System.Drawing.Size(182, 139);
            pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            pictureBox.TabIndex = 0;
            pictureBox.TabStop = false;
            //tạo ra một panel
            Panel panel = new Panel();
            panel.BackColor = System.Drawing.Color.White;
            panel.Controls.Add(lb_title);
            panel.Controls.Add(pictureBox);
            panel.Location = new System.Drawing.Point(pointX,pointY);
            panel.Name = "panel_"+tag;
            panel.Size = new System.Drawing.Size(188, 191);
            panel.TabIndex = 0;
            panel.Tag = tag;
            
            return panel;
        }
        
    }
}
