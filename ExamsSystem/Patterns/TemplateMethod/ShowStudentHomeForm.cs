using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.TemplateMethod
{
    //Hiển thị form home cho học sinh
    class ShowStudentHomeForm : ShowHomeForm
    {
        

        public override void showTop(PictureBox icon, Control mainTitle, Accounts account)
        {
            icon.Image = Properties.Resources.student_icon;
            mainTitle.Text = "Học sinh";
        }
        public HomeItem[] createStudentHomeItems()
        {

            HomeItem item1 = new HomeItem("Làm bài thi", "TestDo", Properties.Resources.exam_do, 225, 6);
            HomeItem item2 = new HomeItem("Kết quả thi", "TestsResult", Properties.Resources.exam_result, 492, 6);
            HomeItem item3 = new HomeItem("Thông tin học sinh", "AccountDetails", Properties.Resources.account_manager, 759, 6);
            HomeItem item4 = new HomeItem("Đổi mật khẩu", "PasswordChange", Properties.Resources.password_change, 225, 6);
            HomeItem[] listItems = { item1, item2, item3, item4 };
            return listItems;
            
        }

        public override HomeItem[] getHomeItem()
        {
            return createStudentHomeItems();
        }
    }
}
