using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using ExamsSystem.Patterns.Observer.DoTest;
using ExamsSystem.Patterns.StatePattern.DoingTest;
using ExamsSystem.Patterns.StatePattern.Test;
using ExamsSystem.Patterns.Visitor.Questions;
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
    public partial class TestDoingForm : Form, DoTestObserver
    {
        private Tests test;
        private Exams exam;
        private Accounts account;
        private DoTestContext doTestContext;
        public TestDoingForm()
        {
            InitializeComponent();
        }
        public TestDoingForm(object data)
        {
            InitializeComponent();
            account = User.getInstance().getAccount();
            this.test = (Tests)data;
            this.exam = test.Exam;
          
            //update bảng câu hỏi nằm bên trái
            updateAnswerQuestionTable();
        }
        
        //khi load form
        private void TestDoingForm_Load(object sender, EventArgs e)
        {
            //thiết lập giá trị mặc định
            lb_test_title.Text = $"Bài thi môn {exam.Subject.SubjectName}";
            //lưu giá trị thời gian bắt đầu làm bài
            DateTime startdotime = DateTime.Now;
            test.Startdotime = startdotime.ToString("dd/MM/yyyy HH:mm:ss");
            //thiết lập trạng thái đang làm bài để tính thời gian
            //testsContext.setState(new DoingTestState(test));
            //testsContext.actionState();
            //khởi tạo doTestContext
            doTestContext = new DoTestContext(this, test, group_answers);

        }
       
        //dán một câu hỏi lên view
        public void QuestionToView(Questions question, int indexQuestion)
        {
           
            //cập nhật tiêu đề 
            lb_question.Text = $"Câu hỏi {indexQuestion + 1}:";
            //cập nhật câu hỏi
            rtxt_question_title.Text = question.Title;
            // cập nhật câu trả lời
            rtxt_answerA.Text = question.Answers[0];
            rtxt_answerB.Text = question.Answers[1];
            rtxt_answerC.Text = question.Answers[2];
            rtxt_answerD.Text = question.Answers[3];
            // cập nhật phần các nút chọn câu trả lời
            int typeQuestion = question.TypeQuestion;
            updateAnswerQuestionBox(typeQuestion);
            //gọi hàm set kết quả mà người dùng đã chọn vào các nút chọn kết quả (nếu không chọn thì cũng k set)
            setUserAnswerToGroupAnswer(question, typeQuestion);

        }
        //hàm set kết quả đúng vào các nút chọn kết quả 
        private void setUserAnswerToGroupAnswer(Questions question, int typeQuestion)
        {
            //nếu question không có id thì ta không cần phải chuyển dạng qua lại
            // vì coi như là ta đang tương tác với một question mới khác với question cũ
            if (question.Id == null)
            {
                return;
            }
            // gắn kết quả lên nút -- đồng thời cũng click một radiobutton trong bảng dạng câu hỏi
            if (typeQuestion == 0) // nếu câu hỏi dạng radio (1 câu trả lời)
            {
                rd_answer_single.Checked = true;
                RadioQuestions radioQuestion = (RadioQuestions)question;

                //lấy kết quả mà người dùng đã chọn ra
                string userAnswer = radioQuestion.UserAnswer;
                foreach (Control control in group_answers.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton rd = (RadioButton)control;
                        if (rd.Tag.ToString().Equals(userAnswer))
                        {
                            rd.Checked = true;
                        }
                    }
                }
            }
            else // nếu câu hỏi dạng checkbox (nhiều câu trả lời)
            {
                rd_answer_multiple.Checked = true;
                CheckboxQuestions checkboxQuestion = (CheckboxQuestions)question;
                if(checkboxQuestion.UserAnswer == null)
                {
                    checkboxQuestion.UserAnswer = new List<string>();
                }
                List<string> userAnswer = checkboxQuestion.UserAnswer;
                foreach (Control control in group_answers.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox cb = (CheckBox)control;
                        if (userAnswer.Count > 0 &&  userAnswer.IndexOf(cb.Tag.ToString()) >= 0)
                        {
                            cb.Checked = true;
                        }
                    }
                }
            }
        }
        //cập nhật các nút câu trả lời dựa theo dạng câu hỏi
        private void updateAnswerQuestionBox(int typeQuestion)
        {
            //xóa đi các nút cũ
            deleteControlInAnswerForm();
            //cập nhật lại phần nút
            string[] answerTag = { "A", "B", "C", "D" };

            int sizeX = 57;
            int sizeY = 17;
            int pointX = 6;
            int pointY = 20;
            foreach (string tag in answerTag)
            {
                Control answerControl = null;
                //nếu là dạng câu hỏi 1 câu trả lời thì tạo radio button
                if (typeQuestion == 0)
                {
                    answerControl = new RadioButton()
                    {
                        Width = sizeX,
                        Height = sizeY,
                        Location = new Point(pointX, pointY),
                        Tag = tag,
                        Text = $"{tag}.",
                        Name = $"rd_answer_{tag}"
                    };
                }
                //nếu là câu hỏi dạng nhiều câu trả lời thì tạo checkbox
                if (typeQuestion == 1)
                {
                    answerControl = new CheckBox()
                    {
                        Width = sizeX + 2,
                        Height = sizeY,
                        Location = new Point(pointX, pointY),
                        Tag = tag,
                        Text = $"{tag}.",
                        Name = $"rd_answer_{tag}"
                    };
                }
                pointY += 74;
                group_answers.Controls.Add(answerControl);
            }
        }
        private void deleteControlInAnswerForm()
        {
            List<Control> controlToDelete = new List<Control>();
            //xóa đi các nút cũ
            foreach (Control control in group_answers.Controls)
            {
                string namecontrol = control.Name;
                if (namecontrol.Equals("rd_answer_A") || namecontrol.Equals("rd_answer_B") || namecontrol.Equals("rd_answer_C") || namecontrol.Equals("rd_answer_D"))
                {
                    controlToDelete.Add(control);
                }
            }
            foreach (Control control in controlToDelete)
            {
                group_answers.Controls.Remove(control);
            }
        }
        private void updateAnswerQuestionTable()
        {
            //lấy ra length danh sách câu hỏi hiện tại
            int questionLength = exam.Questions.Count;
            //nếu chưa có câu hỏi nào thì return
            if (questionLength <= 0)
            {
                return;
            }
            //làm sạch group cell câu hỏi
            group_questions_list.Controls.Clear();
            //chuẩn bị dữ liệu và thêm các ô câu hỏi
            int locationX = 17;
            int locationY = 25;
            int countCreate = 0; /* dùng để đếm số lần đã tạo để cập nhật lại giá trị location */
            for (int i = 0; i < questionLength; i++)
            {
                if (countCreate == 5)
                {
                    locationX = 17;
                    locationY += 38;
                    countCreate = 0;
                }
                //tạo trước một label
                Label label = new Label()
                {
                    Text = $"{i + 1}", /* thứ tự câu hỏi */
                    Tag = $"{i}", /* tag để xác định vị trí câu hỏi */
                    BackColor = Color.FromArgb(0, 123, 255),
                    Dock = DockStyle.Fill,
                    TextAlign = ContentAlignment.MiddleCenter,
                    AutoSize = false,
                    ForeColor = Color.White,
                    Size = new Size(26, 21)
                };
                //gắn sự kiện khi nhấn vào label (sẽ chuyển đến câu hỏi tương ứng )
                label.Click += label_cell_question_click;
                //tạo một panel chứa label
                Panel panel = new Panel()
                {
                    BorderStyle = BorderStyle.FixedSingle,
                    Size = new Size(28, 23),
                    Location = new Point(locationX, locationY)
                };
                //gắn label vào panel
                panel.Controls.Add(label);
                //thêm vào group
                group_questions_list.Controls.Add(panel);
                //tăng giá trị locationX
                locationX += 34;
                //tăng giá biến countcreate;
                countCreate += 1;
            }

        }
        //sự kiện nhấn vào một ô câu hỏi trong bảng danh sách câu hỏi
        private void label_cell_question_click(object sender, EventArgs e)
        {
          
            Label labelClicked = (Label)sender;
            string tag = labelClicked.Tag.ToString();
            //lấy ra cell index
            int cellIndex = int.Parse(tag);

            doTestContext.clickCell(cellIndex);

        }
        //khi nhấn nút next sẽ chuyển trang vị trí câu hỏi tiếp theo
        private void btn_next_Click(object sender, EventArgs e)
        {
            doTestContext.clickNext();
        }
        //khi nhấn nút previous sẽ chuyển trang vị trí câu hỏi trước
        private void btn_previous_Click(object sender, EventArgs e)
        {
            doTestContext.clickPrevious();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            doTestContext.clickSubmit();

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
        //lưu lại câu trả lời của người dùng đã chọn khi nhấn nút next, previous hay khi hàm nộp bài được gọi
        

        public void refreshUI(object data, int option)
        {
            
        }

        //khi nhấn nút nộp bài
       
        //hàm thay đổi nội dung của label đếm thời gian
        public void changeContentCountDowm(string content)
        {
            lb_countdown.Text = content;
        }
        
    }
    
}
