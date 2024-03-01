using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
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
    public partial class CreateExamForm : Form
    {
        private MyObserver myObserver;
        private Accounts account;
        private AccountsBLL accountsBLL;
        private ExamsBLL examsBLL;
        private Exams examCopied; //chứa một exam nếu được gán vào
        public CreateExamForm()
        {
            InitializeComponent();
            accountsBLL = new AccountsBLL();
            examsBLL = new ExamsBLL();
            //lấy ra username hiện tại
            string username = User.getInstance().getAccount().Username;
            //lấy ra thông tin tài khoản hiện tại từ csdl
            account = accountsBLL.getAccount(username);

           
            //tạo group chọn môn học cho đề thi dựa theo những môn dạy học
            createGroupSubject();
        }

        //hàm tạo group chọn môn học cho đề thi dựa theo những môn dạy học của tài khoản
        private void createGroupSubject()
        {
            //lấy ra danh sách môn học đang dạy
            List<Subjects> listTeaching = account.SubjectStudy;
            if (listTeaching == null) { return; }
            int locationY = 19;
            int locationX = 6;
            foreach(Subjects tc in listTeaching)
            {
                //tạo ra các radiobutton
                RadioButton rd = new RadioButton
                {
                    Tag = tc.SubjectID,
                    Text = tc.SubjectName,
                    Location = new Point(locationX,locationY),
                    Size = new Size(116,17)
                };
                group_subjects.Controls.Add(rd);
                locationY += 23;
            }
        }
        
        //hàm tạo exam nhập = tay
        private void createExamDefault(int subjectid, int checkout, int dotime)
        {
            //thêm vào csdl
            int result = examsBLL.insertExam(account.Username, subjectid, checkout, dotime);
            if (result == 1)
            {
                DialogResult dialogResult = createMessageBox("Tạo bài thi thành công", "Thông báo");
                if (dialogResult == DialogResult.OK)
                {
                    //clearform
                    clearForm();
                    //refresh lại UI ở trang quản lý
                    changeData(0);
                    //tắt đề thi hiện tại
                    this.Close();

                }
            }
        }
        //hàm tạo exam từ việc dán
        private void createExamPaste(int subjectid, int checkout, int dotime)
        {
            try
            {
                //gọi hàm thêm vào csdl và nhận về một id mới thêm
                int examid = examsBLL.insertExamAndGetIt(account.Username, subjectid, checkout, dotime);
                //thêm câu hỏi vào đề thi mới tạo này
                foreach (Questions question in examCopied.Questions)
                {
                    examsBLL.insertQuestionToExam(examid, int.Parse(question.Id));
                }
                DialogResult dialogResult = createMessageBox("Tạo bài thi thành công", "Thông báo");
                if (dialogResult == DialogResult.OK)
                {
                    //clearform
                    clearForm();
                    //refresh lại UI ở trang quản lý
                    changeData(0);
                    //tắt đề thi hiện tại
                    this.Close();
                }
            }
            catch(Exception err)
            {
                createMessageBox(err.Message, "Thông báo");
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            try
            {


                //kiểm tra và lấy thời gian làm bài
                int dotime = int.Parse(CheckAndGetDotime());
                //kiểm tra và lấy môn học cho bài làm
                int subjectid = int.Parse(CheckAndGetSubject());
                //mới tạo nên trạng thái kiểm duyệt là 0 (nghĩa là chưa kiểm)
                int checkout = 0;
                if (examCopied == null)
                {
                    createExamDefault(subjectid,checkout,dotime);
                }
                else
                {
                    createExamPaste(subjectid, checkout, dotime);
                }

               
                

            }
            catch(Exception err)
            {
                createMessageBox(err.Message, "Thông báo");
            }
            
        }
        private string CheckAndGetDotime()
        {
            //kiểm tra và lấy thời gian làm bài
            if (cb_dotime.SelectedIndex < 0)
            {
                throw new Exception("Vui lòng chọn thời gian làm bài");
            }
            string dotime = cb_dotime.SelectedItem.ToString();
            return dotime;
        }
        private string CheckAndGetSubject()
        {
            //kiểm tra và lấy môn học
            foreach(Control control in group_subjects.Controls)
            {
                RadioButton rd = (RadioButton)control;
                if (rd.Checked)
                {
                    //tag là id của môn học
                    return rd.Tag.ToString();
                }
            }
            throw new Exception("Vui lòng chọn môn học");
        }
        private void changeData(int changeType)
        {
            myObserver.refreshUI(changeType); //0 là thêm một dữ liệu mới
        }
        //gắn một observer
        public void addObserver(MyObserver observer)
        {
            myObserver = observer;
        }
      

        //khi nhấn nút dán đề thi
        private void btn_paste_Click(object sender, EventArgs e)
        {
            //lấy ra đề thi
            Exams exam = User.getInstance().copiedExam.Clone();
            if (exam == null)
            {
                return;
            }
            //kiểm tra xem bài thi người dùng muốn dán vào có phải quyền hạn trong môn học
            // người dùng giảng dạy không ?
            bool haveSubject = false;
            foreach(Control control in group_subjects.Controls)
            {
                RadioButton rd = (RadioButton)control;
                if (rd.Tag.ToString().Equals(exam.Subject.SubjectID))
                {
                    haveSubject = true;
                    break;
                }
                
            }
            if (haveSubject == false)
            {
                createMessageBox("Bài thi bạn dán vào không phù hợp với môn học bạn dạy", "Thông báo");
                return;
            }
           
            examCopied = exam;
            //gọi hàm hiển thị câu hỏi mới tạo lên view
            ShowExamsToView();
        }
        private void ShowExamsToView()
        {
            //gắn thời gian làm bài
            cb_dotime.SelectedItem = examCopied.Dotime.ToString();
            //gắn số lượng câu hỏi hiện tại
            txt_questions_count.Text = examCopied.Questions.Count.ToString();
            //gắn môn học
            foreach(Control control in group_subjects.Controls)
            {
                RadioButton rd = (RadioButton)control;
                if (rd.Tag.ToString().Equals(examCopied.Subject.SubjectID))
                {
                    rd.Checked = true;
                    break;
                }
            }
            //khóa khu vực môn học
            group_subjects.Enabled = false;

        }
       
        private DialogResult createMessageBox(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            return MessageBox.Show(message, title, button);
        }
        private DialogResult createMessageBoxYesNo(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            return MessageBox.Show(message, title, button);
        }

        private void CreateExamForm_Load(object sender, EventArgs e)
        {
            //nếu người dùng không có bản copy nào thì ẩn đi nút paste
            if (User.getInstance().copiedExam == null)
            {
                btn_paste.Enabled = false;
            }
        }
        private void clearForm()
        {
            cb_dotime.SelectedIndex = -1;
            txt_questions_count.Text = "0";
            foreach(Control control in group_subjects.Controls)
            {
                RadioButton rd = (RadioButton)control;
                rd.Checked = false;
            }
            group_subjects.Enabled = true;
            examCopied = null;

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            //clearform
            clearForm();
        }
    }
}
