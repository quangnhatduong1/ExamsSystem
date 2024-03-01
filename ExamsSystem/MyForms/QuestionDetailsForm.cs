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
    public partial class QuestionDetailsForm : Form
    {
        private Questions question;
        private int currentCopied = 0;
        private QuestionsBLL questionsBLL;
        private MyObserver myObserver;
        public QuestionDetailsForm()
        {
            InitializeComponent();
        }
        public QuestionDetailsForm(object data)
        {
            InitializeComponent();
            int questionid = (int)data;
            questionsBLL = new QuestionsBLL();
            question = questionsBLL.getQuestion(questionid);
        }
        private void QuestionDetailsForm_Load(object sender, EventArgs e)
        {
            //cập nhật question lên view
            QuestionToView(question);
            //kiểm tra xem question này được dùng hay chưa ?
            checkUsedQuestion();
            //kiểm tra chủ nhân câu hỏi và quyền môn học
            checkOwnerQuestion();
        }
        //hàm kiểm tra question được dùng chưa
        private void checkUsedQuestion()
        {
            //kiểm tra xem question này được dùng hay chưa ?
            int questionid = int.Parse(question.Id);
            //nếu ròi thì khóa form + check vào ô checkbox
            if (questionsBLL.getExam_Question(questionid) != null)
            {
                cb_used.Checked = true;
                lockForm();
            }
        }
        //hàm kiểm tra chủ nhân của question
        private void checkOwnerQuestion()
        {
            Accounts account = User.getInstance().getAccount();
            string rolename = account.Rolename;
            if (rolename == "HV") //nếu là học vụ thì cứ việc khóa form
            {
                lockForm();
            }
            if (rolename == "GV")
            {
                string ownerquestion = question.Username;
                //nếu không phải chủ nhân thì khóa form luôn
                if (!ownerquestion.Equals(account.Username))
                {
                    lockForm();
                }
                else //nếu phải thì kiểm tra quyền hạn môn học trước khi hiển thị
                {
                    //kiểm tra để cập lại danh sách môn học
                    List<Subjects> subjects = account.SubjectStudy;
                    if (subjects == null || subjects.Count <= 0)
                    {
                        foreach (Control control in group_subjects.Controls) { control.Hide(); }
                    }
                    else
                    {
                        foreach (Control control in group_subjects.Controls)
                        {
                            Subjects subject = subjects.Find(t => t.SubjectID.ToString().Equals(control.Tag.ToString()));
                            if (subject == null)
                            {
                                control.Hide();
                            }
                        }
                    }
                }
                
                
            }
        }
        private void lockForm()
        {
            group_answers.Enabled = false;
            group_subjects.Enabled = false;
            group_type.Enabled = false;
            rtxt_question_title.Enabled = false;
            btn_save_question.Enabled = false;
            btn_delete_question.Enabled = false;
        }
        //dán một câu hỏi lên view
        public void QuestionToView(Questions question)
        {
            //set giá trị này để loại bỏ trạng thái đang tương tác với câu hỏi copy
            currentCopied = 0;
            //cập nhật tiêu đề 
            lb_question.Text = $"Câu hỏi";
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
            //gọi hàm set kết quả đúng vào các nút chọn kết quả
            setRightAnswerToGroupAnswer(question, typeQuestion);
            //gọi hàm set môn học vào môn học
            setSubjectForQuestion(question);
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
        //hàm set kết quả đúng vào các nút chọn kết quả 
        private void setRightAnswerToGroupAnswer(Questions question, int typeQuestion)
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
                string rightAnswer = radioQuestion.RightAnswer;
                foreach (Control control in group_answers.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton rd = (RadioButton)control;
                        if (rd.Tag.ToString().Equals(rightAnswer))
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
                List<string> rightAnswer = checkboxQuestion.RightAnswer;
                foreach (Control control in group_answers.Controls)
                {
                    if (control is CheckBox)
                    {
                        CheckBox cb = (CheckBox)control;
                        if (rightAnswer.IndexOf(cb.Tag.ToString()) >= 0)
                        {
                            cb.Checked = true;
                        }
                    }
                }
            }
        }
        //set môn học tương ứng với câu hỏi
        private void setSubjectForQuestion(Questions question)
        {
            foreach(Control control in group_subjects.Controls)
            {
                RadioButton rd = (RadioButton)control;
                if (rd.Tag.ToString().Equals(question.Subject.SubjectID))
                {
                    rd.Checked = true;
                    break;
                }
            }
        }

        private void btn_question_clear_Click(object sender, EventArgs e)
        {
            QuestionToView(question);
        }
        //copy một câu hỏi
        private void btn_copy_question_Click(object sender, EventArgs e)
        {
            User.getInstance().copiedQuestion = question.Clone();
        }
        //khi click vào một button đổi dạng câu hỏi
        private void rd_answer_single_Click(object sender, EventArgs e)
        {
            //lấy type câu hỏi mà người dùng chọn thông qua tag của radio button
            RadioButton typeRadio = (RadioButton)sender;
            int typeQuestion = int.Parse(typeRadio.Tag.ToString());
            deleteControlInAnswerForm();
            string[] answerTag = { "A", "B", "C", "D" };
            int sizeX = 58;
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
            
            //nếu đang làm việc với câu hỏi copy thì return;
            if (currentCopied == 1)
            {
                return;
            }
            //nếu quay về dạng cũ ban đầu ta phải hiển thị lại đáp án trước đó
      
            //nếu người dùng chuyển dạng mà không phải dạng cũ thì return                             
            if (question.TypeQuestion != typeQuestion)
            {
                return;
            }
            //còn nếu quay về dạng cũ thì ta xem dạng cũ là gì để gán lại kết quả cho phù hợp
            setRightAnswerToGroupAnswer(question, typeQuestion);
        }

        //lưu câu hỏi hiện tại
        private void btn_save_question_Click(object sender, EventArgs e)
        {
            updateQuestion();
        }
        private void updateQuestion()
        {
            string title = rtxt_question_title.Text.ToString();
            string answerA = rtxt_answerA.Text.ToString();
            string answerB = rtxt_answerB.Text.ToString();
            string answerC = rtxt_answerC.Text.ToString();
            string answerD = rtxt_answerD.Text.ToString();
            int typeQuestion = rd_answer_single.Checked ? 0 : 1;
            //lấy ra câu trả lời đúng
            string rightAnswer = "";
            if (typeQuestion == 0)
            {
                foreach (Control control in group_answers.Controls)
                {
                    if (control is RadioButton)
                    {
                        RadioButton rd = (RadioButton)control;
                        if (rd.Checked)
                        {
                            rightAnswer = rd.Tag.ToString();
                            break;
                        }
                    }
                }
            }
            else
            {
                foreach (Control control in group_answers.Controls)
                {
                    if (control is CheckBox)
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
            int subjectid = int.Parse(question.Subject.SubjectID);
            foreach(Control control in group_subjects.Controls)
            {
                RadioButton rd = (RadioButton)control;
                if (rd.Checked == true)
                {
                    subjectid = int.Parse(rd.Tag.ToString());
                    break;
                }
            }
            bool resultCompare = true;
            resultCompare = compareQuestion(title, answerA, answerB, answerC, answerD, rightAnswer, typeQuestion,subjectid);

            //nếu kiểm tra không có sự thay đổi thì không làm gì hết => return;
            if (resultCompare)
            {
                return;
            }
            //còn nếu có thì hỏi người dùng xem rằng họ có thật sự muốn cập nhật câu hỏi này không ?
            DialogResult dialogResult = createMessageBoxYesNo("Bạn thật sự có muốn thay đổi câu hỏi này không ?", "Thông báo");
            //nếu người dùng nhấn Yes -- ta sẽ thay thế câu hỏi hiện tại thành một câu hỏi hoàn toàn mới (khác cả id)
            if (dialogResult == DialogResult.Yes)
            {
                int resultUpdate = questionsBLL.updateQuestion(int.Parse(question.Id), title, answerA, answerB, answerC, answerD, rightAnswer, typeQuestion, subjectid);
                if(resultUpdate  >0)
                {
                    DialogResult dialogupdate = createMessageBox("Cập nhật câu hỏi thành công", "Thông báo");
                    if(dialogupdate == DialogResult.OK)
                    {
                        changeData(1);
                        this.Close();
                    }
                }
                else
                {
                    DialogResult dialogupdate = createMessageBox("Cập nhật câu hỏi thất bại", "Thông báo");
                }


            }
        }
        private bool compareQuestion(string title, string answerA, string answerB, string answerC, string answerD, string rightAnswer, int typeQuestion, int subjectid)
        {

           
            //kiểm tra câu hỏi
            if (!question.Title.Equals(title))
            {
                return false;
            }
            //kiểm tra các câu trả lời
            if (!question.Answers[0].Equals(answerA))
            {
                return false;
            }
            if (!question.Answers[1].Equals(answerB))
            {
                return false;
            }
            if (!question.Answers[2].Equals(answerC))
            {
                return false;
            }
            if (!question.Answers[3].Equals(answerD))
            {
                return false;
            }
            //kiểm tra dạng câu hỏi
            if (typeQuestion != question.TypeQuestion)
            {
                return false;
            }
            //kiểm tra câu trả lời đúng có thay đổi không (áp dụng hàm này cho việc chấm điểm )
            if (typeQuestion == 0) //nếu là dạng 1 câu trả lời
            {
                RadioQuestions rdQuestion = (RadioQuestions)question;
                if (!rightAnswer.Equals(rdQuestion.RightAnswer))
                {
                    return false;
                }
            }
            else //nếu là dạng nhiều câu tra lời
            {
                CheckboxQuestions cbquestion = (CheckboxQuestions)question;

                string currentrightAnswer = "";//biến ghi các kết quả đúng của câu hỏi được lưu trong exam
                foreach (string str in cbquestion.RightAnswer)
                {
                    currentrightAnswer += str;
                }

                if (!currentrightAnswer.Equals(rightAnswer))
                {
                    return false;
                }
            }
            //kiểm tra sự thay đổi của môn học
            if(int.Parse(question.Subject.SubjectID) != subjectid)
            {
                return false;
            }
            return true;
        }

        private void btn_delete_question_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = createMessageBoxYesNo("Bạn có chắc muốn xóa câu hỏi này không ?", "Thông báo");
            if (dialogResult == DialogResult.Yes)
            {
                deleteQuestion();
            }
        }
        //hàm thực hiện xóa câu hỏi
        private void deleteQuestion()
        {
            int questionid = int.Parse(question.Id);
            int deleteResult = questionsBLL.deleteQuestion(questionid);
            if(deleteResult > 0)
            {
                DialogResult dialogresult = createMessageBox("Xóa câu hỏi thành công", "Thông báo");
                if (dialogresult == DialogResult.OK)
                {
                    changeData(2);//thông báo dữ liệu bị xóa
                    this.Close();
                }

            }

        }


        public void addObserver(MyObserver observer)
        {
            myObserver = observer;
        }
        public void changeData(int changeType)
        {
            myObserver.refreshUI(changeType);
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

       
    }

}
