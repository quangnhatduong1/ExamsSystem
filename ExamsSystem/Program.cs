
using ExamsSystem.MyForms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.BLL;
using ExamsSystem.MyObjects;

namespace ExamsSystem
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //tạo một tài khoản admin nếu chưa tồn tại
            try
            {
                AccountsBLL accountsBLL = new AccountsBLL();
                accountsBLL.Register("admin", "123456", "AM");
                accountsBLL.insertInformation("admin", "PhuPhan", "11/11/2004", "012456789", "PhuPhan12@gmail.com");
                accountsBLL.insertTeachers("admin");//thêm tài khoản admin vào bảng giáo viên để sử dụng quyền của gv
                accountsBLL.insertStudents("admin","LT-1");//thêm tài khoản admin vào bảng học sinh để sử dụng quyền của học sinh
                //thêm thông tin dạy học cho giáo viên
                List<Subjects> subjects = new List<Subjects>()
                {
                    new Subjects("1","Giáo dục công dân"),
                    new Subjects("2","Lịch sử"),
                    new Subjects("3","Địa lý")
                };
                accountsBLL.updateTeaching("admin", subjects);
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
            }
            Application.Run(FormFactory.getInstance().getForm("Login"));
      
        }
    }
}
