using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.FactoryMethod;
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
    public partial class TestsResultForm : Form
    {
        private StudentsTestsBLL studentsTestsBLL;
        private Accounts account;
        public TestsResultForm()
        {
            InitializeComponent();
            studentsTestsBLL = new StudentsTestsBLL();
            this.account = User.getInstance().getAccount();
        }

        private void clearForm()
        {
            cb_search.SelectedIndex = 0;
            txt_search.Text = null;
            //thiết lập lại giá trị mặc định thì gọi hàm tìm kiếm để lấy lại giá trị mặc định
            searchTestsResult();
        }
        //hàm thực hiện tìm kiếm
        private void searchTestsResult()
        {
            int field = cb_search.SelectedIndex;
            string valuesearch = txt_search.Text.ToString();
            showStudentsResult(field, valuesearch);
        }

        private void TestsResultForm_Load(object sender, EventArgs e)
        {
            clearForm();
        }
        //lấy kết quả làm bài của một user
        private void showStudentsResult(int field, object valuesearch)
            //field: trường dữ liệu muốn tìm từ combobox - 0: tất cả, 1: theo mã bài thi 2: theo tên môn học
        {
            data_result_test_list.DataSource = studentsTestsBLL.getResultTestsBySearch(field, account.Username, valuesearch);
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            //gọi hàm tìm kiếm để lấy dữ liệu từ các ô input tìm kiếm và bắt đầu tìm kiếm
            searchTestsResult();
        }

        private void TestsResultForm_FormClosed(object sender, FormClosedEventArgs e)
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

        private void btn_clearsearh_Click(object sender, EventArgs e)
        {
            clearForm();
        }
    }
}
