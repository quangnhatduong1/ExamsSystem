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

namespace ExamsSystem.MyForms
{
    public partial class AccountDetailsForm : Form
    {
        private Accounts account;
        private AccountsBLL accountsBLL;
        public AccountDetailsForm()
        {
            InitializeComponent();
        }
        public AccountDetailsForm(Object data)
        {
            InitializeComponent();
            
            accountsBLL = new AccountsBLL();
            
            this.account = (Accounts)data;
            setAccountToView();
        }
        //hiển thị thông tin tài khoản lên view
        private void setAccountToView()
        {
            txt_username.Text = account.Username;
            txt_fullname.Text = account.Fullname;
            
            datetime_birthday.Value = DateTime.ParseExact(account.Birthday,"dd/MM/yyyy",null);
            txt_email.Text = account.Email;
            Console.WriteLine(account.Email);
            txt_phonenumber.Text = account.Phonenumber;
            //nếu thông tin tài khoản là của học sinh thì
            if (account.Rolename == "HS")
            {
                //ẩn đi khung môn học giảng dạy
                HideGroupSubject();
               
                //thêm giá trị classname của tài khoản lên view
                ShowClassName();
            }
            else if (account.Rolename == "GV")
            {
                //ẩn đi ô combobox class name
                HideClassName();
                
                //show teaching (show lên những môn học đang giảng dạy)
                ShowTeaching();
            }
            else if (account.Rolename == "HV")
            {
                //phòng học vụ thì ẩn luôn cả 2 phần này
                HideClassName();
                HideGroupSubject();
            }
            else if (account.Rolename == "AM")
            {
                HideClassName();
                ShowTeaching();
                
            }
            //nếu người dùng hiện tại đang sử dụng chức năng này không phải là AM thì ẩn đi khung quyền
            if (User.getInstance().getAccount().Rolename != "AM")
            {
                HideGroupRoleName();
            }
            //ngược lại thì hiện
            else
            {
                ShowRoleName();
            }
        }
        //hàm ẩn đi khung môn học giảng dạy
        private void HideGroupSubject()
        {
            group_subjects.Hide();
        }
        //hàm khóa các control trong môn học giảng dạy
        private void LockGroupSubject()
        {
            group_subjects.Enabled = false;
        }
        //hàm mở khóa các control trong môn học giảng dạy
        private void UnLockGroupSubject()
        {
            group_subjects.Enabled = true;
        }
        //hàm hiển thị giá trị teaching (những môn học giảng dạy) lên view
        private void ShowTeaching()
        {
            //lấy ra danh môn học mà tài khoản đang dạy
            List<Subjects> teachingList = account.SubjectStudy;
            if (teachingList == null) { return; }
            foreach (Subjects tc in teachingList)
            {
               
                foreach (Control control in group_subjects.Controls)
                {
                    CheckBox cb = (CheckBox)control;
                    //kiểm tra tên môn học để stick vào ô checkbox
                    if (cb.Tag.ToString().Equals(tc.SubjectID))
                    {
                        cb.Checked = true;
                        //chỉ cần có một môn học giảng dạy có tồn tại thì khóa group subject lại
                        // để người dùng không sửa được
                        LockGroupSubject();
                    }
                }
            }
        }
        //hàm ẩn đi khung quyền tài khoản
        private void HideGroupRoleName()
        {
            group_rolename.Hide();
        }
        //hàm khóa khung quyền tài khoản
        private void LockGroupRoleName()
        {
            group_rolename.Enabled = false;
        }
        //hàm mở khóa khung quyền tài khoản
        private void UnLockGroupRoleName()
        {
            group_rolename.Enabled = true;
        }
        //hàm hiển thị giá trị rolename của tài khoản lên view
        private void ShowRoleName()
        {
            string rolename = account.Rolename;
            foreach(Control control in group_rolename.Controls)
            {
                RadioButton rd = (RadioButton)control;
                
                if (rd.Tag.ToString().Equals(rolename))
                {
                    rd.Checked = true;
                    //khóa form quyền để người dùng sửa được
                    LockGroupRoleName();
                }
            }
        }
        //hàm ẩn ô input Lớp học
        private void HideClassName()
        {
            cb_classname.Hide();
            lb_classname.Hide();
        }
        //hàm khóa ô input Lớp học
        private void LockClassName()
        {
            cb_classname.Enabled = false;
        }
        //hàm mở khóa ô input
        private void UnClockClassName()
        {
            cb_classname.Enabled = true;
        }
        //hàm hiển thị giá trị classname lên view
        private void ShowClassName()
        {
            string classname = account.Classname;
            //lấy ra danh sách item của ô combobox classname
            int index = 0;
            
            foreach(object item in cb_classname.Items)
            {
                string itemSelected = item.ToString();
                Console.WriteLine(classname);
                if (itemSelected.Equals(classname))
                {
                    //gán cho combobox chọn ngay vị trí có giá trị classname tương ứng
                    cb_classname.SelectedIndex = index;
                    //đóng ô combobox classname để người dùng không thể thay đổi giá trị
                    LockClassName();
                    break;
                }
                index += 1;
                
            }
        }
        // khi người dùng bấm nút cập nhật thông tin tài khoản
        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {
                string username = txt_username.Text.ToString();
                //cập nhật một số thông tin cá nhân trước
                updateInformation(username);

                //cập nhật lớp học (nếu có) -- dành cho học sinh
                int studentUpdate = 0;
                if (account.Rolename == "HS")
                {
                    studentUpdate=updateStudents(username);
                }
                //cập nhật môn dạy học (nếu có) -- dành cho Giáo viên (và admin)
                int teacherUpdate = 0;
                if (account.Rolename == "AM" || account.Rolename == "GV")
                {
                    teacherUpdate=updateTeaching(username);
                }
                DialogResult dialogResult = createMessageBox("Cập nhật thông tin thành công", "Thông báo");
                if (dialogResult == DialogResult.OK)
                {
                    //khóa một số ô thông tin lại nếu nó đang được mở khóa và đã được cập nhật
                    if(teacherUpdate == 1) //nếu thông tin dạy học được cập nhật
                    {
                        LockGroupSubject();
                    }
                    if(studentUpdate == 1)//nếu thông tin học sinh được cập nhật
                    {
                        LockClassName();
                    }
                    //nếu thông tin mà người dùng vừa cập nhật chính là của mình thì cập nhật trong class User
                    if (User.getInstance().getAccount().Username.Equals(username))
                    {
                        //gọi một tài khoản mới từ csdl
                        Accounts newAccount = accountsBLL.getAccount(username);
                        //thêm mới
                        User.getInstance().setAccount(newAccount);
                        
                    }

                } 
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }

        private void txt_phonenumber_TextChanged(object sender, EventArgs e)
        {

        }
        private void updateInformation(string username)
        {
            //cập nhật một số thông tin cá nhân trước
            string email = txt_email.Text.ToString();
            string fullname = txt_fullname.Text.ToString();
            string phonenumber = txt_phonenumber.Text.ToString();
            string birthday = datetime_birthday.Value.ToString("dd/MM/yyyy");
            validForm(email);
            accountsBLL.updateInformation(username, fullname, birthday, email, phonenumber);
            
        }
        //hàm này thực hiện update thông tin classname là chính (dành cho HS)
        private int updateStudents(string username)
        {
            //nếu bị khóa nghĩa là người dùng không được phép thay đổi nữa
            if(cb_classname.Enabled == false) { return 0; }
            //ngược lại thì vẫn có thể tiếp tục cập nhật
            //có thể người dùng chưa chọn dữ liệu
            if (cb_classname.SelectedIndex < 0) { return 0; }
           
            string classname = cb_classname.SelectedItem.ToString();
            return accountsBLL.updateStudents(username, classname);
        }
        //hàm thực hiện cập nhật các môn dạy học (dành cho GV)
        private int updateTeaching(string username)
        {
            //nếu bị khóa nghĩa là người dùng không được phép thay đổi nữa
            if (group_subjects.Enabled == false) { return 0; }
            //ngược lại thì vẫn có thể tiếp tục cập nhật
            //tạo mảng các môn học mà người muốn cập nhật giảng dạy
            List<Subjects> listTeaching = new List<Subjects>();
            //duyệt mảng để thêm thông tin
            foreach(Control control in group_subjects.Controls)
            {
                CheckBox cb = (CheckBox)control;
                if (cb.Checked == true)
                {
                    listTeaching.Add(new Subjects(cb.Tag.ToString(), cb.Text.ToString()));
                }
            }
            //có thể người dùng chưa chọn
            if(listTeaching.Count <= 0) { return 0; }
            //chọn rồi thì tiến hành cập nhật
            return accountsBLL.updateTeaching(username, listTeaching);
        }
        //tiền hành valid một số giá trị trong form trước khi cập nhật
        private void validForm(string email)
        {
            MyValid myValid = new EmailValidator();
            myValid.valid(email);
        }
        private DialogResult createMessageBox(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            return MessageBox.Show(message, title, button);
        }

        private void AccountDetailsForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (User.getInstance().getAccount().Rolename != "AM")
            {
                goToHomeForm();
            }
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
