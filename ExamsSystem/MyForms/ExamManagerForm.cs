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

namespace ExamsSystem.MyForms
{
    public partial class ExamManagerForm : Form, MyObserver
    {
        private ExamsBLL examsBLL;
        private int selectedIndex = -1; //vị trí hiện tại được nhấn trong row
        private int toNewScreen = 0;
        public ExamManagerForm()
        {
            InitializeComponent();
            lockForm();
            examsBLL = new ExamsBLL();
            cb_subjects.SelectedIndex = 0;
            
        }

        public void refreshUI(int changeType) //changeType: kiểu thay đổi -- 0:thêm mới -- 1: cập nhật -- 2:dữ liệu bị xóa
        {
        
            if(changeType == 0)
            {
                //load lại danh sách
                showExamsList("","");
            }
            if(changeType == 1) //dữ liệu bị thay đổi về nội dung
            {
                //cập nhật thông tin trong form bên phải
                //lấy thông tin id từ row được chọn
                int id = getIdData(selectedIndex); //selectedIndex chứa row được chọn
                //gọi hàm hiển thị thông tin lên form
                showForm(id);
                

            }
            else if(changeType == 2) //dữ liệu bị xóa thì clear form bên phải và lock một số thành phần
            {
                showExamsList("","");
                clearForm();
                lockForm();
            }
        }


        private void btn_create_exam_Click(object sender, EventArgs e)
        {
            //hiển thị form tạo đề thi
            CreateExamForm form = (CreateExamForm) FormFactory.getInstance().getForm("CreateExam");
            // gắn observer để nhận sự thông báo khi có một exam được thêm
            form.addObserver(this);
            form.ShowDialog();
        }

        //hiển thị danh sách Exams
        private void showExamsList(string field_subject, string field_username)
        {
            data_exams_list.DataSource = examsBLL.getExamsList(field_subject,field_username);
        }

        private void ExamManagerForm_Load(object sender, EventArgs e)
        {
            showExamsList("","");
        }

        //hàm lấy dữ liệu id từ một row trong bảng data
        private int getIdData(int index)
        {
           
            DataGridViewRow rowSelected = data_exams_list.Rows[index];
            //lấy ra id bài Exam
            int id = int.Parse(rowSelected.Cells[0].Value.ToString());
            return id;
        }
        private void data_exams_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                selectedIndex = e.RowIndex;
               //lấy thông tin id từ row được chọn
                int id = getIdData(e.RowIndex);
                //gọi hàm hiển thị thông tin lên form
                showForm(id);
                
            }
            catch(Exception err)
            {
                clearForm();
                lockForm();
                selectedIndex = -1;

            }
        }

        //làm sạch form
        private void clearForm()
        {
            txt_checkout.Text = "";
            txt_creator_search.Text = "";
            txt_dotime.Text = "";
            txt_examid.Text = "";
            txt_questionscount.Text = "";
            txt_subject.Text = "";
            txt_username.Text = "";
            cb_subjects.SelectedIndex = 0;
        }
        //khóa một số thành phần trong form
        private void lockForm()
        {
            txt_checkout.Enabled = false;
            
            txt_dotime.Enabled = false;
            txt_examid.Enabled = false;
            txt_questionscount.Enabled = false;
            txt_subject.Enabled = false;
            txt_username.Enabled = false;
            btn_exam_detail.Enabled = false;
            clearForm();
        }
        //mở khóa một số thành phần của form
        private void unlockForm()
        {
            btn_exam_detail.Enabled = true;
        }
        //hiển thị thông tin bài kiểm tra lên form
        private void showForm(int id)
        {
            try
            {
                //lấy exam từ csdl
                Exams exam = examsBLL.getExam(id);
                //hiển thị thông tin exam lên view
                txt_username.Text = exam.Username;
                txt_subject.Text = exam.Subject.SubjectName;
                txt_questionscount.Text = exam.Questionscount.ToString();
                txt_examid.Text = exam.Id;
                txt_dotime.Text = exam.Dotime.ToString();
                txt_checkout.Text = exam.Checkout == 0 ? "Chưa duyệt" : "Đã duyệt";
                
                unlockForm();
            }
            catch(Exception e)
            {
                createMessageBox(e.Message, "Thông báo");
            }

        }
        private DialogResult createMessageBox(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            return MessageBox.Show(message, title, button);
        }

        private void btn_exam_detail_Click(object sender, EventArgs e)
        {
            //lấy ra id bài Exam
            int id = int.Parse(txt_examid.Text.ToString());
            //tạo form hiển thị chi tiết với tham số là id
            ExamDetailsForm form = (ExamDetailsForm) FormFactory.getInstance().getForm("ExamDetails", id);
            form.addObserver(this); //gắn observer để nhận dữ liệu
            form.ShowDialog();
        }

        private void btn_question_manager_Click(object sender, EventArgs e)
        {
            toNewScreen = 1;
            Form form = FormFactory.getInstance().getForm("QuestionManager");
            this.Hide();
            form.ShowDialog();
            this.Close();
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            string field_subject = "";
            if(cb_subjects.SelectedIndex != 0)
            {
                field_subject = cb_subjects.SelectedItem.ToString();
            }
            string field_username = txt_creator_search.Text.ToString();
            showExamsList(field_subject, field_username);
        }

        private void btn_clearsearh_Click(object sender, EventArgs e)
        {
            clearForm();
            lockForm();
            showExamsList("", "");
        }

        private void ExamManagerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(toNewScreen == 0)
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
