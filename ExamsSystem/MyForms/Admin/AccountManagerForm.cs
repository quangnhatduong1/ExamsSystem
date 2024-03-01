using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.Observer;
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
    public partial class AccountManagerForm : Form, MyObserver
    {
        private AccountsBLL accountsBLL;
        public AccountManagerForm()
        {
            InitializeComponent();
            accountsBLL = new AccountsBLL();
            ClearFrom();
            clearSearch();
            cb_search_rolename.SelectedIndex = 0;
        }

        //khi bấm vào 1 trong 3 nút button -- dựa vào tag mà đưa ra 1 nút để thực hiện việc đăng ký
        private void register_Click(object sender, EventArgs e)
        {
            //hiển thị form đăng ký
            showForm("Register");
        }

        private void btn_account_detail_Click(object sender, EventArgs e)
        {
            //lấy ra tên tài khoản vừa được click
            string username = txt_username.Text.ToString();
            //lấy toàn bộ thông tin tài khoản từ csdl dựa vào username
            Accounts account = accountsBLL.getAccount(username);
            //tạo và hiển thị form chi tiết tài khoản
            Form form = FormFactory.getInstance().getForm("AccountDetails", account);
            form.ShowDialog();
        }
        private void showForm(string formName)
        {
            Form form = FormFactory.getInstance().getForm(formName);
            if (form == null)
            {
                return;
            }
            form.ShowDialog();
        }

        private void AccountManagerForm_Load(object sender, EventArgs e)
        {
            //hiển thị danh sách tài khoản
            showAccountsList("","");
        }
        //hàm hiển thị danh sách tài khoản
        public void showAccountsList(string field_username, string field_rolename)
        {
            data_students_list.DataSource = accountsBLL.getAccountsList(field_username,field_rolename);
        }
        private void ClearFrom()
        {
            txt_username.Text = "";
            txt_rolename.Text = "";
            btn_account_detail.Enabled = false;
        }
        //hàm dùng để mở khóa một số phần của form
        private void unclockForm()
        {
            btn_account_detail.Enabled = true;
        }
        private void clearSearch()
        {
            txt_search_username.Text = "";
            cb_search_rolename.SelectedIndex = 0;
           
        }
       
        //khi nhấn vào một row của bảng tài khoản
        private void data_students_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow rowSelected = data_students_list.Rows[e.RowIndex]; //lấy ra dòng được chọn
                string username = rowSelected.Cells[0].Value.ToString();
                string rolename = rowSelected.Cells[1].Value.ToString();
                //hiển thị lên view
                txt_username.Text = username;
                txt_rolename.Text = rolename;
                //mở khóa 
                unclockForm();
            }
            catch(Exception err)
            {
                ClearFrom();
            }
        }

        private void btn_clearsearh_Click(object sender, EventArgs e)
        {
            clearSearch();
            ClearFrom();
            showAccountsList("","");
        }

        public void refreshUI(int changeType)
        {
           if(changeType == 0)
            {

            }
           else if(changeType == 1)
            {

            }
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string field_username = txt_search_username.Text.ToString();
            string field_rolename = cb_search_rolename.SelectedIndex != 0 ? cb_search_rolename.SelectedItem.ToString() : "";
            showAccountsList(field_username, field_rolename);
        }

        private void AccountManagerForm_FormClosed(object sender, FormClosedEventArgs e)
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
