using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.TemplateMethod;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.MyForms
{
    public partial class HomeForm : Form
    {
        private Accounts account;
        AccountsBLL accountsBLL;
        public HomeForm()
        {
            InitializeComponent();
            accountsBLL = new AccountsBLL();
            //lấy thông tin tài khoản đang đăng nhập hiện tại
            account = User.getInstance().getAccount();
            //hiển thị nội dung của các thành phần giao diện
            ShowHomeForm showHomeForm;
            //lấy ra quyền tài khoản
            if (account == null) { return; }
            string rolename = account.Rolename;
            if (rolename == "AM")
            {
                showHomeForm = new ShowAdminHomeForm();
            }
            else if(rolename == "GV")
            {
                showHomeForm = new ShowTeacherHomeForm();
            }
            else if(rolename == "HV")
            {
                showHomeForm = new ShowOfficerHomeForm();
            }
            else
            {
                showHomeForm = new ShowStudentHomeForm();
            }
            
            showHomeForm.show(this, account);
            
        }
        
        
       
        public Control[] getHomeControls()
        {
            Control[] controls = { lb_hello_title, img_hello_icon, lb_home_title ,panel_menu_top , panel_menu_bottom};
            return controls;
        }
        public void HomeItem_panel_Click(object sender, EventArgs e)
        {
            PictureBox homeItem = (PictureBox)sender;
            //lấy ra tên form từ tag của HomeItem click được và gọi hàm showForm để hiển thị form tương ứng
            string formName = homeItem.Tag.ToString();
            showForm(formName);
            
        }
        private void showForm(string formName)
        {
            Form form;
            //một số form yêu cầu thêm dữ liệu vào
            if (formName == "AccountDetails")
            {
                 Accounts currentAccount = User.getInstance().getAccount();
                //lấy thông tin account mới nhất từ csdl dựa vào account hiện tại (dựa vào username)
                Accounts newAccount = accountsBLL.getAccount(currentAccount.Username);
                 form = FormFactory.getInstance().getForm(formName, newAccount);
            }
            else
            {
                 form = FormFactory.getInstance().getForm(formName);
            }
            if (form == null)
            {
                return;
            }
            this.Hide();
            form.ShowDialog();
            this.Close();

        }

        private void img_logout_Click(object sender, EventArgs e)
        {
            Form form = FormFactory.getInstance().getForm("Login");
            User.getInstance().setAccount(null);
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
    }
}
