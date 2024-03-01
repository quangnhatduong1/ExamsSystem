using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.TemplateMethod
{
    //Hiển thị form home cho giáo viên
    class ShowTeacherHomeForm : ShowHomeForm
    {

        

        public override void showTop(PictureBox icon, Control mainTitle, Accounts account)
        {
            icon.Image = Properties.Resources.teacher_icon;
            mainTitle.Text = "Giáo viên";
        }
        public HomeItem[] createTeacherHomeItems()
        {

            HomeItem item1 = new HomeItem("Quản lý đề thi", "ExamManager", Properties.Resources.exam_manager, 225, 6);
            HomeItem item2 = new HomeItem("Quản lý báo cáo", "ReportManager", Properties.Resources.report_manager, 492, 6);
            HomeItem item3 = new HomeItem("Thông tin gv", "AccountDetails", Properties.Resources.account_manager, 759, 6);
            HomeItem item4 = new HomeItem("Đổi mật khẩu", "PasswordChange", Properties.Resources.password_change, 225, 6);
            HomeItem[] listItems = { item1, item2, item3, item4 };
            return listItems;
        }

        public override HomeItem[] getHomeItem()
        {
            return createTeacherHomeItems();
        }
    }
}
