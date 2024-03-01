
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamsSystem.BLL;
using ExamsSystem.Patterns.StrategyPattern.ValidForm;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.FactoryMethod;

namespace ExamsSystem.MyForms
{
    public partial class LoginForm : Form
    {
        private AccountsBLL accountsBLL;
        private MyValid myValid;
        public LoginForm()
        {
            InitializeComponent();
            this.accountsBLL = new AccountsBLL();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = txt_username.Text.ToString();
            string password = txt_password.Text.ToString();
            //thực hiện kiểm tra các dữ liệu của form đăng nhập
            try
            {
                myValid = new UsernameValidator();
                myValid.valid(username);
                myValid = new PasswordValidator();
                myValid.valid(password);
                Accounts account = accountsBLL.checkLogin(username, password);
                //lưu thông tin tài khoản vào lớp User (singleton)
                User.getInstance().setAccount(account);
                //sau đó đi đến trang đăng nhập
                goToHomeForm();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void goToHomeForm()
        {
            // tạo một HomeForm
            Form homeForm = FormFactory.getInstance().getForm("Home");
            this.Hide();
            homeForm.ShowDialog();
            this.Close();
        }


    }
}
