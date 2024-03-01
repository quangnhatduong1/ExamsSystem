using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
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

namespace ExamsSystem.MyForms.Admin
{
    public partial class RegisterForm : Form
    {
        private MyValid myValid;
        private AccountsBLL accountsBLL;
        public RegisterForm()
        {
            InitializeComponent();
            accountsBLL = new AccountsBLL();
            lb_classname.Hide();
            cb_classname.Hide();
            group_subjects.Hide();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                ToRegister();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
        private void ToRegister()
        {
            //lấy ra thông tin username (trường dữ liệu bắt buộc)
            string username = txt_username.Text.ToString();

            //lấy ra thông tin họ và tên
            string fullname = txt_fullname.Text.ToString();
            //lấy ra thông tin ngày sinh
            string birthday = datetime_birthday.Value.ToString("dd/MM/yyyy");
            //lấy ra thông tin email
            string email = txt_email.Text.ToString();
            //lấy ra thông tin sdt
            string phonenumber = txt_phonenumber.Text.ToString();
            //lấy ra group quyền và lấy tên quyền (dạng viết tắt) thông qua Tag
            GroupBox gr = groupbox_rolename;
            string rolename = null;
            foreach (Control control in gr.Controls)
            {
                RadioButton rd = (RadioButton)control;
                if (rd.Checked)
                {
                    rolename = rd.Tag.ToString();
                }
            }
            ValidRegisterForm(username, email, rolename);
            string password = null;
            if (rolename == "HS")
            {
                password = "HS123456";
            }
            else if(rolename == "GV")
            {
                password = "GV123456";
            }
            else
            {
                password = "HV123456";
            }
            List<Subjects> teachingList = getValueFromGroupSubjects(); //lấy ra mảng id môn học mà người dùng chọn
            if (rolename == "GV")
            {
                if (teachingList == null) //nếu = null thì nghĩa là chưa chọn môn học nào
                {
                    throw new Exception("Vui lòng chọn ít nhất một môn học cho giáo viên");
                }
            }
            accountsBLL.Register(username, password, rolename);
            accountsBLL.insertInformation(username, fullname, birthday, email, phonenumber);
            if (rolename == "HS")
            {
                string classname = cb_classname.SelectedItem.ToString();
                accountsBLL.insertStudents(username,classname);
            }
            else if (rolename == "GV")
            {
               
               
              
                //thêm tài khoản vào bảng teachers
                accountsBLL.insertTeachers(username);
                //update các id môn học vào bảng giảng dạy (teaching)
                accountsBLL.updateTeaching(username, teachingList);
                
                
                
            }
            //đến được đây là không có lỗi gì
            MessageBox.Show("Đăng ký tài khoản thành công");
            //clearForm
            ClearForm();

        }
        //lấy ra giá trị môn học mà người dùng đã chọn
        private List<Subjects> getValueFromGroupSubjects()
        {
            List<Subjects> teachingList = new List<Subjects>();
           
            int i = 0;
            foreach(Control control in group_subjects.Controls)
            {
                CheckBox cb = (CheckBox)control;
                if (cb.Checked)
                {
                    teachingList.Add(new Subjects(cb.Tag.ToString(), ""));
                    i += 1;
                }
            }
            if (i == 0)
            {
                return null;
            }
            else
            {
                return teachingList;
            }
        }
        private void ValidRegisterForm(string username, string email, string rolename)
        {
            
            myValid = new UsernameValidator();
            myValid.valid(username);
            myValid = new EmailValidator();
            myValid.valid(email);
            myValid = new RolenameValidator();
            myValid.valid(rolename);
                
            
            
        }
        private void ClearForm()
        {

            txt_username.Text = "";


            txt_fullname.Text = "";

            datetime_birthday.Value = DateTime.Parse("01/01/2000");
            
            txt_email.Text = "";

            txt_phonenumber.Text = "";
            //lấy ra group quyền và lấy tên quyền (dạng viết tắt) thông qua Tag
            GroupBox gr = groupbox_rolename;
          
            foreach (Control control in gr.Controls)
            {
                RadioButton rd = (RadioButton)control;
                rd.Checked = false;
            }
            offOtionsCreateAccount();
        }
        private void checkFloatInputTextBox(object sender, KeyPressEventArgs e)//kiểm tra để chỉ cho phép textbox nhập số float
        {
            if (((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8 && e.KeyChar != 46))
            {
                e.Handled = true;
                return;
            }

            // checks to make sure only 1 decimal is allowed
            if (e.KeyChar == 46)
            {
                if ((sender as TextBox).Text.IndexOf(e.KeyChar) != -1)
                    e.Handled = true;
            }
        }

        private void txt_phonenumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            checkFloatInputTextBox(sender, e);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        // nhấn 1 trong 3 button quyền tài khoản
        private void group_rolename_click(object sender, EventArgs e)
        {
            RadioButton rd = (RadioButton)sender;
            string rolename = rd.Tag.ToString();
            //kiểm tra xem người dùng nhấn vào quyền nào thì hiện các option tạo tài khoản tươngungws
            if (rolename.Equals("HS")) // nếu là học sinh thì hiện combobox chọn lớp
            {
                offOtionsCreateAccount(); //tạm thời ẩn đi các tùy chọn
                //hiển thị tùy chọn cho học sinh
                lb_classname.Show();
                cb_classname.Show();
                cb_classname.SelectedIndex = 0;
            }
            else if (rolename.Equals("GV"))
            {
                offOtionsCreateAccount();
                //hiển thị tùy chọn cho giáo viên
                group_subjects.Show();
            }
            else
            {
                offOtionsCreateAccount();
            }
        }
        //hàm ẩn các options tùy chọn khi tạo tài khoản dựa theo quyền
        private void offOtionsCreateAccount()
        {
            lb_classname.Hide();
            cb_classname.Hide();
            group_subjects.Hide();
        }

        private void RegisterForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        
    }
}
