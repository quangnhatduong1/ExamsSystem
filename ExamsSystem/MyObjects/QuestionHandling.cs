using ExamsSystem.BLL;
using ExamsSystem.MyObjects.Question;
using ExamsSystem.Patterns.Observer;
using ExamsSystem.Patterns.Observer.Question;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.MyObjects
{
    //bộ xử lý view sang câu hỏi và ngược lại
    class QuestionHandling
    {
        private Control rtxt_question_title;
        private Control rtxt_answerA;
        private Control rtxt_answerB;
        private Control rtxt_answerC;
        private Control rtxt_answerD;
        private Control group_type;
        private Control group_answers;
        private Control group_subjects;
        private Exams exam;
        private List<MyQuestionObserver> observerList;
        private MyObserver myObserver;
        private QuestionsBLL questionBLL;
        public QuestionHandling(Control rtxt_question_title, Control rtxt_answerA, Control rtxt_answerB, Control rtxt_answerC, Control rtxt_answerD, Control group_type, Control group_answers, Control group_subjects, Exams exam)
        {
            this.rtxt_question_title = rtxt_question_title;
            this.rtxt_answerA = rtxt_answerA;
            this.rtxt_answerB = rtxt_answerB;
            this.rtxt_answerC = rtxt_answerC;
            this.rtxt_answerD = rtxt_answerD;
            this.group_type = group_type;
            this.group_answers = group_answers;
            this.group_subjects = group_subjects;
            this.exam = exam;
            questionBLL = new QuestionsBLL();
            observerList = new List<MyQuestionObserver>();
        }

        public void clear()
        {
            rtxt_question_title.Text = null;
            rtxt_answerA.Text = null;
            rtxt_answerB.Text = null;
            rtxt_answerC.Text = null;
            rtxt_answerD.Text = null;
            //mặc định là chọn câu hỏi 1 câu trả lời
            RadioButton rd_answer_single = (RadioButton)group_type.Controls[1];
            rd_answer_single.Checked = true;
            deleteControlInAnswerForm();
            //tạo lại phần chọn câu trả lời là single
            string[] answerTag = { "A", "B", "C", "D" };
            int sizeX = 57;
            int sizeY = 17;
            int pointX = 6;
            int pointY = 20;
            foreach (string tag in answerTag)
            {
                Control answerControl = null;
                answerControl = new RadioButton()
                {
                    Width = sizeX,
                    Height = sizeY,
                    Location = new Point(pointX, pointY),
                    Tag = tag,
                    Text = $"{tag}.",
                    Name = $"rd_answer_{tag}"
                };
                pointY += 74;

                group_answers.Controls.Add(answerControl);
            }
            //nếu tạo câu hỏi không phải cho một đề thi cố định thì ta clear luôn cái phần chọn môn học
            if (exam != null) { return; }
            foreach (Control control in group_subjects.Controls)
            {
                RadioButton rd = (RadioButton)control;
                rd.Checked = false;
            }
        }

        public void create()
        {
            try
            {
                //lấy ra title của câu hỏi
                string title = rtxt_question_title.Text.ToString();

                //lấy ra 4 câu trả lời

                string answerA = rtxt_answerA.Text.ToString();

                string answerB = rtxt_answerB.Text.ToString();

                string answerC = rtxt_answerC.Text.ToString();

                string answerD = rtxt_answerD.Text.ToString();

                //lấy ra dạng câu hỏi
                int typeQuestion = -1;
                foreach (Control control in group_type.Controls)
                {
                    RadioButton rd = (RadioButton)control;
                    if (rd.Checked)
                    {
                        typeQuestion = int.Parse(rd.Tag.ToString());
                    }
                }
                //lấy ra câu trả lời đúng (dựa theo dạng câu hỏi nào mà xử lý)
                string rightAnswer = null;
                foreach (Control control in group_answers.Controls)
                {

                    if (control is CheckBox || control is RadioButton)
                    {
                        if (typeQuestion == 0) // nếu câu hỏi dạng 1 câu trả lời
                        {
                            RadioButton rd = (RadioButton)control;
                            if (rd.Checked)
                            {
                                rightAnswer += rd.Tag.ToString();
                                break;
                            }
                        }
                        else // nếu câu hỏi dạng nhiều câu trả lời
                        {
                            CheckBox cb = (CheckBox)control;
                            if (cb.Checked)
                            {
                                rightAnswer += cb.Tag.ToString();

                            }
                        }
                    }

                }


                //lấy ra mã môn học
                int subjectid = -1;
                foreach (Control control in group_subjects.Controls)
                {
                    RadioButton rd = (RadioButton)control;
                    if (rd.Checked)
                    {
                        subjectid = int.Parse(rd.Tag.ToString());
                        break;
                    }
                }

                //lấy thông tin người dùng hiện tại
                string username = User.getInstance().getAccount().Username;
                //thêm câu hỏi và nhận về một giá trị id của câu hỏi vừa mới thêm
                int questionid = questionBLL.insertAndGetIt(title, answerA, answerB, answerC, answerD, rightAnswer, typeQuestion, subjectid, username);
                //sau đó lấy giá trị câu hỏi từ id mới thêm
                Questions newQuestion = questionBLL.getQuestion(questionid);
                //sau đó gọi hàm newQuestionData để gửi dữ liệu cho những đối tượng đang đợi dữ liệu mới
                newQuestionData(newQuestion);
                //hiển thị hộp thoại xác nhận và đóng form
                DialogResult dialogResult = createMessageBox("Tạo thành công một câu hỏi", "Thông báo");
                if (dialogResult == DialogResult.OK)
                {
                    rtxt_question_title.FindForm().Close();
                }
            }
            catch (Exception err)
            {
                createMessageBox(err.Message, "Thông báo");
            }
        }

        public void paste()
        {
            //lấy câu hỏi được copy ra
            Questions question = User.getInstance().copiedQuestion;
            if (question == null)
            {
                return;
            }
            //kiểm tra sự trùng khớp về môn học khi tạo câu hỏi cho một đề thi cố định
            if (exam != null && !question.Subject.SubjectID.Equals(exam.Subject.SubjectID))
            {
                createMessageBox("Câu hỏi hiện tại không trùng với môn học của đề thi", "Thông báo");
                return;
            }
            QuestionToView(question);
        }
        //set observer
        public void setObserver(MyQuestionObserver myQuestionObserver)
        {
            observerList.Add(myQuestionObserver);
        }
        public void setObserver(MyObserver myObserver)
        {
            this.myObserver = myObserver;
        }
        //hàm được gọi khi có một câu hỏi mới được tạo
        //nhằm gửi câu hỏi mới này để phía mong chờ nhận
        //được câu hỏi mới và updata giao diện
        public void newQuestionData(Questions newQuestion)
        {
            if (observerList != null)
            {
                //nếu có câu hỏi mới thì gửi về cho phía đợi
                foreach (MyQuestionObserver ob in observerList)
                {
                    ob.refreshUI(newQuestion);
                }
            }

            if (myObserver != null)
            {
                myObserver.refreshUI(0);
            }
        }
        //hàm xóa đi các nút chọn câu trả lời trong khung group_answer hiện tại
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

        public void QuestionToView(Questions question)
        {
            //cập nhật câu hỏi
            rtxt_question_title.Text = question.Title;
            // cập nhật câu trả lời
            rtxt_answerA.Text = question.Answers[0];
            rtxt_answerB.Text = question.Answers[1];
            rtxt_answerC.Text = question.Answers[2];
            rtxt_answerD.Text = question.Answers[3];
            // cập nhật phần các nút chọn câu trả lời
            int typeQuestion = question.TypeQuestion;
            //cập nhật phần nút
            updateAnswerQuestionBox(typeQuestion);
        }
        //hàm thay đổi phần nút chọn câu trả lời
        private void updateAnswerQuestionBox(int typeQuestion)
        {
            deleteControlInAnswerForm();

            string[] answerTag = { "A", "B", "C", "D" };

            int sizeX = 57;
            int sizeY = 17;
            int pointX = 6;
            int pointY = 20;
            if (typeQuestion == 0)
            {
                RadioButton rd_answer_single = (RadioButton)group_type.Controls[1];
                rd_answer_single.Checked = true;
            }
            else
            {
                RadioButton rd_answer_multiple = (RadioButton)group_type.Controls[0];
                rd_answer_multiple.Checked = true;
            }
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
        private DialogResult createMessageBox(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.OK;
            return MessageBox.Show(message, title, button);
        }
    }
}
