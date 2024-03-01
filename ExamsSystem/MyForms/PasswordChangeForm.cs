using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.MyTools;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.StrategyPattern.ValidForm;
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
    public partial class PasswordChangeForm : Form
    {
        private MyValid myValid;
        private AccountsBLL accountsBLL;
        public PasswordChangeForm()
        {
            InitializeComponent();
            accountsBLL = new AccountsBLL();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                //lấy ra 3 giá trị mật khẩu
                string oldpass = txt_oldpassword.Text.ToString();
                string newpass = txt_newpassword.Text.ToString();
                string confirmpass = txt_confirmpassword.Text.ToString();
                validForm(newpass, confirmpass);
                //so sánh mật khẩu cũ với mật khẩu hiện tại
                string currentHashPass = User.getInstance().getAccount().Password; // password ở dạng mã hóa
                
                if (!MyHashPass.getInstance().verify(oldpass, currentHashPass))
                {
                    throw new Exception("Mật khẩu hiện tại không đúng");
                }
                //tiến hành mã hóa lại mật khẩu mới
                string newHashPass = MyHashPass.getInstance().Encrypt(newpass);
                //lưu vào csdl
                //lấy tên tài khoản người dùng hiện tại
                string username = User.getInstance().getAccount().Username;
                accountsBLL.updatePassword(username, newHashPass);
                DialogResult dialogResult = createMessageBox("Đổi mật khẩu thành công", "Thông báo");
                if (dialogResult == DialogResult.OK)
                {
                    //clearfrom
                    clearForm();
                    //cập nhật lại thông tin tài khoản mới nhất từ csdl
                    //gọi một tài khoản mới từ csdl
                    Accounts newAccount = accountsBLL.getAccount(username);
                    //thêm mới
                    User.getInstance().setAccount(newAccount);
                }
                
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }


        }
        private void clearForm()
        {
            txt_confirmpassword.Text = "";
            txt_newpassword.Text = "";
            txt_oldpassword.Text = "";
        }
        private void validForm(string newpass, string confirmpass)
        {
              myValid = new PasswordValidator();
                myValid.valid(newpass);
                if (!newpass.Equals(confirmpass))
                {
                    throw new Exception("Mật khẩu xác nhận không khớp");
                }
           
            
        }
        private DialogResult createMessageBox(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            return MessageBox.Show(message, title, button);
        }

        private void PasswordChangeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            goToHomeForm();
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
