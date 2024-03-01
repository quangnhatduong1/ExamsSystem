using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.Observer;
using ExamsSystem.Patterns.Observer.Question;
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
    public partial class QuestionManagerForm : Form, MyObserver
    {
        private QuestionsBLL questionsBLL;
        private int selectedIndex = -1;
        private Exams exam;
        private List<MyQuestionObserver> observerList;
        private int toNewScreen = 0; //biến để chuyển đến form khác mà không hiển thị form trang chủ
        //nếu khởi tạo từ menu
        public QuestionManagerForm()
        {
            InitializeComponent();
            cb_subjects.SelectedIndex = 0;
            questionsBLL = new QuestionsBLL();
            //nếu đến từ trang quản lý đề thi thì ẩn đi nút chọn câu hỏi
            btn_choose_question.Hide();
        }
        //nếu khởi tạo lúc tạo một câu hỏi cho đề thi
        public QuestionManagerForm(object data)
        {
            InitializeComponent();
            this.exam = (Exams)data;
            //khóa khu vực search môn học
            cb_subjects.Enabled = false;
            //gắn giá trị là môn học của exam
            cb_subjects.SelectedItem = exam.Subject.SubjectName;
            //ẩn nút quản lý đề thi
            btn_exam_manager.Hide();
            questionsBLL = new QuestionsBLL();
        }
        private void QuestionManager_Load(object sender, EventArgs e)
        {
            defaultSearch();
        }
        //thực hiện tìm kiếm mặc định
        private void defaultSearch()
        {
            if (exam == null) //nếu không có bài exam thì tìm kiếm tất cả
            {
                showExamsList("", "");
            }
            else //nếu có bài exam thì chỉ tìm kiếm theo môn của exam
            {
                showExamsList(exam.Subject.SubjectName, "");
            }
        }
        //hiển thị danh sách Questions
        private void showExamsList(string field_subject , string field_username)
        {

            data_questions_list.DataSource = questionsBLL.getQuestionsList(field_subject, field_username);
        }

        private void btn_question_manager_Click(object sender, EventArgs e)
        {
            toNewScreen = 1;
            Form form = FormFactory.getInstance().getForm("ExamManager");
            this.Hide();
            form.ShowDialog();
            this.Close();
        }
        public void refreshUI(int changeType)
        {

            //nếu là sửa
            if (changeType == 1)
            {

                //lấy giá trị question id được chọn
                int questionid = int.Parse(data_questions_list.Rows[selectedIndex].Cells[0].Value.ToString());
                //làm mới giao diện và cập nhật bảng câu hỏi
                clearSearch();
                clearForm();
                //tìm row có chứa questionid tương ứng để click vào
                DataGridViewRow rowtoSelected = data_questions_list.Rows.Cast<DataGridViewRow>()
                    .Where(r => r.Cells[0].Value.ToString().Equals(questionid.ToString()))
                    .First();
                //bỏ chọn row đầu tiên
                data_questions_list.Rows[0].Selected = false;
                //chọn row được chỉ định
                rowtoSelected.Selected = true;
              
                //show câu hỏi lên view
                showForm(rowtoSelected.Index);
            }

            else
            {
                //làm mới giao diện và cập nhật bảng câu hỏi nếu là xóa và thêm mới
                clearSearch();
                clearForm();
            }            
            
           
        }


        private void btn_search_Click(object sender, EventArgs e)
        {
            searchQuestion();
        }
        //tiến hành xử lý search câu hỏi
        private void searchQuestion()
        {
            int subject_index_selected = cb_subjects.SelectedIndex;
            string field_subject = "";
            if (subject_index_selected != 0)
            {
                field_subject = cb_subjects.SelectedItem.ToString();
            }
            string field_username = txt_creator_search.Text.ToString();
            showExamsList(field_subject, field_username);
        }
        private void btn_clearsearh_Click(object sender, EventArgs e)
        {
            clearSearch();
            clearForm();
        }
        private void clearForm()
        {
            txt_questionid.Text = null;
            txt_subject.Text = null;
            txt_typequestion.Text = null;
            txt_username.Text = null;
            btn_choose_question.Enabled = false;
            btn_question_detail.Enabled = false;
        }
        private void clearSearch()
        {
            txt_creator_search.Text = null;
            cb_subjects.SelectedIndex = 0;
            defaultSearch();
        }

        private void data_questions_list_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            try
            {
                showForm(e.RowIndex);
                selectedIndex = e.RowIndex;
            }
            catch(Exception err)
            {
                Console.WriteLine(err.Message);
                clearForm();
                selectedIndex = -1;
            }
        }
        //hiển thị dữ liệu lên form
        private void showForm(int index)
        {
            DataGridViewRow rowSelected = data_questions_list.Rows[index];
            btn_choose_question.Enabled = true;
            btn_question_detail.Enabled = true;
            //lấy dữ liệu questionid ra
            int questionid = int.Parse(rowSelected.Cells[0].Value.ToString());
            //lấy câu hỏi từ csdl
            Questions question = questionsBLL.getQuestion(questionid);
            //hiển thị question lên view
            showQuestion(question);

        }
        private void showQuestion(Questions question)
        {
            txt_questionid.Text = question.Id;
            txt_username.Text = question.Username;
            txt_subject.Text = question.Subject.SubjectName;
            txt_typequestion.Text = question.TypeQuestion == 0 ? "Một câu trả lời" : "Nhiều câu trả lời";
        }

        private void btn_question_detail_Click(object sender, EventArgs e)
        {
            int questionid = int.Parse(txt_questionid.Text.ToString());
            QuestionDetailsForm form = (QuestionDetailsForm) FormFactory.getInstance().getForm("QuestionDetails", questionid);
            form.addObserver(this);
            form.ShowDialog();
        }
        public void setObserver(MyQuestionObserver myob)
        {
            if (observerList == null)
            {
                observerList = new List<MyQuestionObserver>();
            }
            observerList.Add(myob);
        }

        //khi nhấn chọn câu hỏi
        private void btn_choose_question_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = createMessageBoxYesNo("Bạn có chắc muốn chọn câu hỏi này cho đề thi của bạn ?", "Thông báo");
            if(dialogResult == DialogResult.Yes)
            {
                //có thể bị chọn trùng câu hỏi
                try
                {
                    //tiến hành chọn câu hỏi
                    int questionid = int.Parse(txt_questionid.Text.ToString());
                    //lấy câu hỏi
                    Questions question = questionsBLL.getQuestion(questionid);
                    // gọi hàm gửi cho ob
                    dataChose(question);
                    //đóng form
                    this.Close();
                }
                catch(Exception err)
                {
                    createMessageBox("Câu hỏi bạn chọn đã tồn tại trong đề thi, vui lòng chọn câu hỏi khác", "Thông báo");
                }
                
            }
        }
        private void dataChose(Questions question)
        {
            foreach(MyQuestionObserver myob in observerList)
            {
                myob.refreshUI(question);
            }
        }
        private DialogResult createMessageBoxYesNo(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            return MessageBox.Show(message, title, button);
        }
        private DialogResult createMessageBox(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            return MessageBox.Show(message, title, button);
        }

        private void btn_create_exam_Click(object sender, EventArgs e)
        {
            //hiển thị form thêm câu hỏi
            
            CreateQuestionForm createQuestionForm;
            if(exam != null)//nếu có exam thì hiển thị cùng với exam và observer
            {
                createQuestionForm = (CreateQuestionForm)FormFactory.getInstance().getForm("CreateQuestion", exam);
                foreach(MyQuestionObserver ob in observerList)
                {
                    createQuestionForm.setObserver(ob);
                }
                this.Hide();
                createQuestionForm.ShowDialog();
                this.Close();
            }
            else
            {
                createQuestionForm = (CreateQuestionForm)FormFactory.getInstance().getForm("CreateQuestion");
                createQuestionForm.setObserver(this);
                createQuestionForm.ShowDialog();
            }
            
        }

        private void QuestionManagerForm_FormClosed(object sender, FormClosedEventArgs e)
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
