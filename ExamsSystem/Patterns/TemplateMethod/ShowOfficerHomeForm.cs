using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.TemplateMethod
{
    //Hiển thị Home form cho phòng học vụ
    class ShowOfficerHomeForm : ShowHomeForm
    {
        
        
        public override void showTop(PictureBox icon, Control mainTitle, Accounts account)
        {
            icon.Image = Properties.Resources.admin_icon;
            mainTitle.Text = "Phòng học vụ";
        }
        public HomeItem[] createOfficerHomeItems()
        {

            HomeItem item1 = new HomeItem("Quản lý đề thi", "ExamManager", Properties.Resources.exam_manager, 225, 6);
            HomeItem item2 = new HomeItem("Quản lý thi", "TestManager", Properties.Resources.exam_do, 492, 6);
            HomeItem item3 = new HomeItem("Quản lý báo cáo", "ReportManager", Properties.Resources.report_manager, 759, 6);
            HomeItem item4 = new HomeItem("Đổi mật khẩu", "PasswordChange", Properties.Resources.password_change, 225, 6);
            HomeItem[] listItems = { item1, item2, item3, item4};
            return listItems;
        }

        public override HomeItem[] getHomeItem()
        {
            return createOfficerHomeItems();
        }
    }
}
