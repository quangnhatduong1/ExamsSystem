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
    public partial class ExamDetailsForm : Form, MyQuestionObserver
    {
        private QuestionsBLL questionsBLL;
        private ExamsBLL examsBLL;
        private Exams exam;
        Accounts account;
        private int currentIndex = 0; // vị trí câu hỏi hiện tại
        private int currentCopied = 0; //nếu người dùng đang làm việc với câu hỏi được copy (=1)
        private MyObserver myObserver;
        public ExamDetailsForm()
        {
            InitializeComponent();
        }

        public ExamDetailsForm(object data)
        {
            InitializeComponent();
            questionsBLL = new QuestionsBLL();
            examsBLL = new ExamsBLL();
            //lấy tài khoản người dùng hiên tại
            account = User.getInstance().getAccount();
            //kiểm tra xem quyền người dùng để ẩn hiện nút duyệt đề thi
            HideCheckOutButton();
            //data được gửi lên là id của bài exam
            int examid = (int)data;
            //lấy ra bài exam dựa theo examid
            exam = examsBLL.getExam(examid);
            //update câu hỏi đầu tiên lên giao diện
            updateQuestionsToList(currentIndex);
            //update bảng câu hỏi nằm bên trái
            updateAnswerQuestionTable();
            
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        //gắn một observer(trang quản lý đề thi)
        public void addObserver(MyObserver observer)
        {
            myObserver = observer;
        }
        // khi dữ liệu ở đây thay đổi thì trang quản lý cũng phải thay đổi
        public void changeData(int changeType)
        {
            myObserver.refreshUI(changeType);
        }
        private void ExamDetailsForm_Load(object sender, EventArgs e)
        {
            //gọi hàm hiển thị thông tin lên
            showDetailsForm();
            //nếu người dùng không có bản copy nào thì ẩn đi nút paste
            if (User.getInstance().copiedQuestion == null)
            {
                btn_paste_question.Enabled = false;
            }
        }
        //hàm hiển thị thông tin ở phần thông tin đề thi
        private void showDetailsForm()
        {
            string examid = exam.Id;
            txt_examid.Text = examid;
            txt_questionscount.Text = exam.Questionscount.ToString();
            txt_username.Text = exam.Username.ToString();
            
            cb_dotime.SelectedItem = exam.Dotime.ToString();

            string subjectid = exam.Subject.SubjectID;
            //kiểm tra bài thi thuộc môn nào (chỉ hiện chứ không cho người dugnf sửa)
            foreach(Control control in group_subjects.Controls)
            {
                RadioButton rd = (RadioButton)control;
                if (rd.Tag.ToString().Equals(subjectid))
                {
                    rd.Checked = true;
                }
            }
            //kiểm tra quyền người dùng đang hiển thị nội dung trên form
            string rolename = User.getInstance().getAccount().Rolename;
            if (rolename != "AM") // nếu không phải admin thì kiểm tra xem người dùng hiện tại có phải
                                // chủ nhân bài exam này hay không thì hiển thị các nút tương tác
            {
                // nếu không phải admin thì kiểm tra xem người dùng hiện tại có phải
                // chủ nhân bài exam này hay không thì hiển thị các nút tương tác
                string currentUser = User.getInstance().getAccount().Username;
                if (!currentUser.Equals(exam.Username))
                {
                    //khóa một số thành phần
                    lockAllExamForm(false); //false là thực hiện khóa
                    lockAllQuestionsForm(false);
                }
                //nếu người dùng là phòng hV thì ẩn đi các nút tương tác khác chỉ để lại nút duyệt
                // và nút chuyển câu hỏi qua lại
                if (rolename == "HV")
                {
                    btn_delete.Hide();
                    btn_copy_exam.Hide();
                    btn_save_exam.Hide();
                    btn_update_question.Hide();
                    btn_delete_exam.Hide();
                    btn_copy_question.Hide();
                    btn_paste_question.Hide();
                    btn_add_question.Hide();
                }
               
            }
            //kiểm tra duyệt chưa
            if(exam.Checkout == 1) //nếu duyệt rồi thì 
            {
                //stick vào ô duyệt
                checkbox_checkout.Checked = true;
                //khóa một số thành phần
                lockAllExamForm(false); //false là thực hiện khóa
                lockAllQuestionsForm(false);
                //chuyển nút duyệt thành nút không duyệt
                changeCheckoutButton(1);
            }
            //kiểm tra áp dụng chưa
            int countExist = examsBLL.getExamsCountInTests(int.Parse(examid));
            if (countExist > 0) // nếu lớn hơn không thì đã áp dụng rồi
            {
                //stick nút đã áp dụng
                checkbox_used.Checked = true;
                //khóa nút bỏ duyệt luôn
                btn_checkout.Enabled = false;
            }
        }
        private void HideCheckOutButton()
        {
            //kiểm tra người dùng hiện tại để ẩn đi nút duyệt
            string rolename = account.Rolename;
            if(rolename!="AM" && rolename != "HV")
            {
                btn_checkout.Hide();
            }
        }
        

        private void btn_add_question_Click(object sender, EventArgs e)
        {
            CreateQuestionForm form = (CreateQuestionForm)FormFactory.getInstance().getForm("CreateQuestion", exam);
            //thiết lập observer để có thể nhận một giá trị exam được tạo mới và cập nhật giao diện
            MyQuestionObserver ob = this;
            form.setObserver(ob);
            form.ShowDialog();
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
        //hàm set kết quả đúng vào các nút chọn kết quả 
        private void setRightAnswerToGroupAnswer(Questions question,int typeQuestion)
        {
            //nếu question không có id thì ta không cần phải chuyển dạng qua lại
            // vì coi như là ta đang tương tác với một question mới khác với question cũ
            if(question.Id == null)
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
        //dán một câu hỏi lên view
        public void QuestionToView(Questions question, int indexQuestion)
        {
            //set giá trị này để loại bỏ trạng thái đang tương tác với câu hỏi copy
            currentCopied = 0;
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
            //gọi hàm set kết quả đúng vào các nút chọn kết quả
            setRightAnswerToGroupAnswer(question, typeQuestion);
        }
        //cập nhật giao diện phần danh sách câu hỏi tương ứng với câu hỏi
        public void updateQuestionsToList(int indexQuestion)
        {
            //nếu chưa có câu hỏi nào thì làm sạch và khóa form
            if(exam.Questions.Count <= 0)
            {

                ClearQuestionForm();
            }
            else//ngược lại thì mở khóa
            {
                //nếu đề thi đã được duyệt thì không mở khóa
                if (exam.Checkout != 1)
                {
                    unclockQuestionForm();
                }
                
                btn_copy_question.Enabled = true;
            }
            //nếu không có câu hỏi hoặc vị trí không hợp lệ
            if (exam.Questions.Count <= 0 || indexQuestion >= exam.Questions.Count)
            {
                return;
            }
            //tạm thời mở khóa 2 nút next và previous
            btn_next.Enabled = true;
            btn_previous.Enabled = true;
            //lấy ra số lượng câu hỏi
            int questionLength = exam.Questions.Count;
            //nếu vị trí hiện tại < số lượng câu hỏi -1 thì nghĩa là đã đến câu hỏi cuối 
            // vì thế ta khóa nút next
            if(indexQuestion == questionLength-1)
            {
                btn_next.Enabled = false;
            }
            //nếu vị trí hiện tại == 0
            //nghĩa là đang ở câu hỏi đầu tiên ta sẽ khóa nút previous
            if (indexQuestion == 0)
            {
                btn_previous.Enabled = false;
            }

          
           //lấy ra câu hỏi tương ứng với vị trí
            Questions question = exam.Questions[indexQuestion];
            //gọi hàm đưa nội dung question lên view
            QuestionToView(question, indexQuestion);

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
        //cập nhật giao diện phần danh sách câu hỏi tương ứng với mảng câu hỏi
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
            for(int i = 0; i < questionLength; i++)
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
                    Dock= DockStyle.Fill,
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
                    Location = new Point(locationX,locationY)
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
            //khi nhấn vào một ô câu hỏi ta sẽ dùng tag của nó và gán cho vị trí hiện tại
            currentIndex = int.Parse(tag);
            //sau đó update câu hỏi được chọn lên giao diện
            updateQuestionsToList(currentIndex);
            
        }
     
        //cập nhật lại giao diện với question mới được tạo
        public void refreshUI(Questions newQuestion)
        {
            //khi nhận được câu hỏi mới ta sẽ tiến hành cập nhật vào csdl
            int examid = int.Parse(exam.Id);
            int questionid = int.Parse(newQuestion.Id);
            examsBLL.insertQuestionToExam(examid, questionid);
            //thêm vào mảng danh sách câu hỏi hiện tại
            exam.addQuestion(newQuestion);
            //cập nhật lại giao diện (ta sẽ chọn giao diện hiển thị câu hỏi vừa thêm)
            //tức là câu hỏi cuối cùng
            currentIndex = exam.Questions.Count - 1;
            updateGUI(currentIndex);
            //gọi hàm thay đổi ở trang quản lý
            changeData(1); //1: cập nhật

        }
        //khi nhấn nút next sẽ chuyển trang vị trí câu hỏi tiếp theo
        private void btn_next_Click(object sender, EventArgs e)
        {
            currentIndex += 1;
            updateQuestionsToList(currentIndex);
           
        }
        //khi nhấn nút previous sẽ chuyển trang vị trí câu hỏi trước
        private void btn_previous_Click(object sender, EventArgs e)
        {
            currentIndex -= 1;
            updateQuestionsToList(currentIndex);
            
        }

        //khi nhấn một trong hai radiobutton chuyển dạng câu hỏi trong group
        private void change_type_question_radio_click(object sender, EventArgs e)
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
            //lấy ra câu hỏi hiện tại xem người dùng chuyển dạng qua lại thì
            //nếu chưa có câu hỏi nào thì return
            if(exam.Questions.Count <= 0)
            {
                return;
            }
            //nếu đang làm việc với câu hỏi copy thì return;
            if (currentCopied == 1)
            {
                return;
            }
            //nếu quay về dạng cũ ban đầu ta phải hiển thị lại đáp án trước đó
            Questions currentQuestion = exam.Questions[currentIndex];
            //nếu người dùng chuyển dạng mà không phải dạng cũ thì return                             
            if (currentQuestion.TypeQuestion != typeQuestion)
            {
                return;
            }
            //còn nếu quay về dạng cũ thì ta xem dạng cũ là gì để gán lại kết quả cho phù hợp
            setRightAnswerToGroupAnswer(currentQuestion, typeQuestion);
        }
        //hàm so sánh sự thay đổi giữa câu hỏi hiện tại trên view
        //với câu hỏi hiện tại được lưu trong exam
        //hàm này được thực hiện khi người dùng nhấn nút sửa câu hỏi
        //ta sẽ so sánh các giá trị lấy được trên view với giá trị câu hỏi được uu trong exam
        //nếu khác nhau => người dùng muốn thay đổi câu hỏi => flase là không bằng nhau
        // ngược lại thì trả true là bằng nhau => nghĩa là người dùng không thay đổi câu hỏi
        private bool compareQuestion(string title, string answerA, string answerB, string answerC, string answerD, string rightAnswer, int typeQuestion)
        {
            
            //lấy ra câu hỏi ở vị trí hiện tại
            Questions question = exam.Questions[currentIndex];

           
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
                foreach(string str in cbquestion.RightAnswer)
                {
                    currentrightAnswer += str;
                }
              
                if (!currentrightAnswer.Equals(rightAnswer))
                {
                    return false;
                }
            }
            return true;
        }

        private void btn_update_question_Click(object sender, EventArgs e)
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
                foreach(Control control in group_answers.Controls)
                {
                    if(control is RadioButton)
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
            bool resultCompare = true;
            if (exam.Questions.Count > 0) //nếu có câu hỏi trong danh sách mới thực hiện so sánh
            {
                resultCompare = compareQuestion(title, answerA, answerB, answerC, answerD, rightAnswer, typeQuestion);
            }
            else
            {
                resultCompare = false;
            }
            
            //nếu kiểm tra không có sự thay đổi thì không làm gì hết => return;
            if (resultCompare)
            {
                return;
            }
            //còn nếu có thì hỏi người dùng xem rằng họ có thật sự muốn cập nhật câu hỏi này không ?
            DialogResult dialogResult = createMessageBoxYesNo("Bạn thật sự có muốn thay đổi câu hỏi này không ?","Thông báo");
            //nếu người dùng nhấn Yes -- ta sẽ thay thế câu hỏi hiện tại thành một câu hỏi hoàn toàn mới (khác cả id)
            if (dialogResult == DialogResult.Yes)
            {
                updateQuestionForExam(title, answerA, answerB, answerC, answerD, rightAnswer, typeQuestion);
                
                
            }
        }
        //mặc dù ghi tên hàm là update nhưng thật chất là tạo một câu hỏi hoàn toàn mới và thay thế vị trí của câu hỏi cũ trong bảng exams_questions
        private void updateQuestionForExam(string title, string answerA, string answerB, string answerC, string answerD, string rightAnswer, int typeQuestion)
        {
            try
            {
                //tạo một câu hỏi mới dựa trên những gì người dùng cập nhật
                int subjectid = int.Parse(exam.Subject.SubjectID);//lấy thông tin môn học
                string username = User.getInstance().getAccount().Username; //lấy tên người tạo
                //nhận được một id câu hỏi mới
                int newid = questionsBLL.insertAndGetIt(title, answerA, answerB, answerC, answerD, rightAnswer, typeQuestion, subjectid, username);
                //lấy câu hỏi đó ra
                Questions newQuestion = questionsBLL.getQuestion(newid);

                
                //lấy id exam hiện tại
                int examid = int.Parse(exam.Id);
                //xử lý dữ liệu câu hỏi cũ trong bảng exams_questions
                if (exam.Questions.Count <= 0) //nếu chưa có câu hỏi nào
                {
                    //chưa có thì thêm mới
                    examsBLL.insertQuestionToExam(examid, newid);
                    //thêm vào vị trí đầu tiên trong mảng (vì trong mảng chưa có câu hỏi nào)
                    exam.Questions.Add(newQuestion);
                }
                else //đã có câu hỏi
                {
                    //lấy câu hỏi cũ ra
                    Questions question = exam.Questions[currentIndex];
                    //thay thế id câu hỏi cũ thành id câu hỏi mới trong csdl
                    //lấy id của câu hỏi cũ ra
                    int oldid = int.Parse(question.Id);
                    //hàm update lại câu hỏi mới tại vị trí cũ
                    examsBLL.updateQuestionToExam(examid, oldid, newid);
                    //gán lại vào mảng tại vị trí tương ứng
                    exam.Questions[currentIndex] = newQuestion;
                }
             
                
                //sau đó update lại giao diện
                updateGUI(currentIndex);
                createMessageBox("Cập nhật câu hỏi thành công", "Thông báo");
            }
            catch (Exception err)
            {
                createMessageBox(err.Message,"Thông báo");
            }
            
        }
        //hàm xóa đi câu hỏi ra khỏi exam (chỉ cần xóa đi liên kết trong bảng exams_questions)
        private void deleteQuestionToExam()
        {
            try
            {
                //lấy ra id của exam
                int examid = int.Parse(exam.Id);
                //lấy ra id câu hỏi hiện tại
                int questionid = int.Parse(exam.Questions[currentIndex].Id);
                //tiến hành xóa liên kết bảng exams_questions
                examsBLL.deleteQuestionToExam(examid, questionid);
                //xóa trong exam hiện tại
                exam.deleteQuestion(currentIndex);
                //gán lại vị trí currentIndex thụt lui về một vị trí (nếu đang là 0 thì không cần thụt lui)
                if (currentIndex != 0)
                {
                    currentIndex = currentIndex - 1;
                }
                //cập nhật lại giao diện
                updateGUI(currentIndex);
                createMessageBox("Bạn đã xóa một câu hỏi ra khỏi bài thi", "Thông báo");
            }
            catch(Exception err)
            {
                createMessageBox(err.Message, "Thông báo");
            }
            


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
        //hàm update lại giao diện
        private void updateGUI(int index)
        {
            updateQuestionsToList(index); //cập nhật câu hỏi vừa thêm lên giao diện
            updateAnswerQuestionTable(); // cập nhật lại bảng câu hỏi
            showDetailsForm();//cập nhật lại phần thông tin chi tiết
        }
        //khi nhấn nút xóa câu hỏi
        private void btn_delete_Click(object sender, EventArgs e)
        {
            //xác nhận trước khi xóa
            DialogResult dialogResult = createMessageBoxYesNo("Bạn có chắc muốn xóa câu hỏi này ra khỏi bài thi ? ", "Thông báo");
            //nếu xác nhận mới xóa
            if (dialogResult == DialogResult.Yes)
            {
                deleteQuestionToExam();
                //gọi hàm cập nhật lại giao diện ở trang quản lý
                changeData(1);
            }
            
        }
        //làm sạch khu vực câu hỏi (đồng thời khóa luôn)
        private void ClearQuestionForm()
        {
            lb_question.Text = "Câu hỏi:";
            rtxt_question_title.Text = "";
            rtxt_question_title.Enabled = false;
            group_questions_list.Controls.Clear();
            group_type.Enabled = false;
            btn_delete.Enabled = false;
            btn_update_question.Enabled = false;
            btn_copy_question.Enabled = false;
            foreach(Control control in group_answers.Controls)
            {
                control.Enabled = false;
                if(control is RichTextBox)
                {
                    control.Text = "";
                }
                if(control is RadioButton)
                {
                    RadioButton rd = (RadioButton)control;
                    rd.Checked = false;
                }
                if (control is CheckBox)
                {
                    CheckBox cb = (CheckBox)control;
                    cb.Checked = false;
                }
            }
        }
        //mở khóa khu vực câu hỏi
        private void unclockQuestionForm()
        {
            //nếu người dùng là học vụ thì không cần mở
            
            if (User.getInstance().getAccount().Rolename.Equals("HV"))
            { 
                return; 
            }
            //nếu người dùng hiện tại là giáo viên và không phải chủ nhân của bài exam thì cũng không cần mở
            else if (User.getInstance().getAccount().Rolename.Equals("GV") && !exam.Username.Equals(User.getInstance().getAccount().Username))
            {
                return;
            }
            //nếu đê thi được duyệt rồi thì cũng không mở khóa
            if (exam.Checkout == 1) { return; }
            rtxt_question_title.Enabled = true;
            group_type.Enabled = true;
            btn_delete.Enabled = true;
            btn_update_question.Enabled = true;
            
            foreach (Control control in group_answers.Controls)
            {
                control.Enabled = true;
            }
        }
        //khi nhấn nút copy câu hỏi
        private void btn_copy_question_Click(object sender, EventArgs e)
        {
            //clone câu hỏi hiện tại
            Questions cloneQuestion = exam.Questions[currentIndex].Clone();
            //copy vào class User
            User.getInstance().copiedQuestion = cloneQuestion;
            //mở khóa nút paste nếu đang bị đóng
            btn_paste_question.Enabled = true;
        }
        //khi nhấn nút paste câu hỏi
        private void btn_paste_question_Click(object sender, EventArgs e)
        {
           
            //lấy câu hỏi ra
            Questions question = User.getInstance().copiedQuestion.Clone();
            if (question == null)
            {
                //nếu không có câu hỏi nào thì return
                return;
            }
            //nếu câu hỏi hiện tại không cùng môn với đề thì báo lỗi
            if (!question.Subject.SubjectID.Equals(exam.Subject.SubjectID))
            {
                createMessageBox("Câu hỏi không khớp với môn của đề thi, vui lòng chọn câu hỏi khác","Thông báo");
                return;
            }

            //dán lên view
            QuestionToView(question, currentIndex);
            //set giá trị currentCopied để nhận biết là đang tương tác với câu hỏi được copy
            currentCopied = 1;
            //unclock form đối với trường hợp đang bị khóa
            unclockQuestionForm();
        }
        //nhấn nút lưu (chủ yếu là lưu thời gian làm bài vì mấy thông tin khác không đổi được)
        private void btn_save_exam_Click(object sender, EventArgs e)
        {
            try
            {
                //khi lưu một bài thi, nghĩa là update bài thi, ta chỉ có thể update thời gian làm bài của nó
                //nếu người dùng không chọn
                if (cb_dotime.SelectedIndex < 0)
                {
                    throw new Exception("Vui lòng chọn thời gian làm bài");
                    
                }
                
                int examid = int.Parse(exam.Id);//lấy id của đề thi
                int dotime = int.Parse(cb_dotime.SelectedItem.ToString()); //lấy ra thời gian làm bài
                //cập nhật trong csdl
                int updateResult = examsBLL.updateExamDotime(examid,dotime);
                //nếu thành công
                if(updateResult > 0)
                {
                    createMessageBox("Cập nhật thành công", "Thông báo");
                    //cập nhật lại trong đối tượng exam
                    exam.Dotime = dotime;
                    //gọi hàm cập nhật lại ở giao diện quản lý
                    changeData(1); //1: là cập nhật
                }
            }
            catch(Exception err)
            {
                createMessageBox(err.Message, "Thông báo");
            }


        }
        
        //khi nhấn nút duyệt đề thi
        private void btn_checkout_Click(object sender, EventArgs e)
        {
            try
            {
                int examid = int.Parse(exam.Id);//lấy id của đề thi
                                                //tiến hành cập nhật tình trạng duyệt trong csdl
                                                //hỏi xác nhận trước
                DialogResult dialogResult = createMessageBoxYesNo("Bạn có chắc muốn duyệt đề thi này không ? ", "Thông báo");
                if (dialogResult == DialogResult.Yes)
                {
                    int checkout = 1; // 1 là duyệt
                    int updateResult = examsBLL.updateExamCheckout(examid, checkout);
                    if(updateResult > 0)
                    {
                        createMessageBox("Duyệt đề thi thành công", "Thông báo");
                        //chuyển nút duyệt thành nút không duyệt
                        changeCheckoutButton(checkout);
                        //khóa toàn bộ các nút trong form lại để không được phép thay đổi nội dung nào nữa sau khi duyệt
                        lockAllExamForm(false); //false là khóa
                        lockAllQuestionsForm(false);
                        //stick vào ô checkbox duyệt
                        checkbox_checkout.Checked = true;
                        //cập nhật lại trong đối tượng 
                        exam.Checkout = 1;
                        //gọi hàm cập nhật lại ở trang quản lý
                        changeData(1); //cập nhật
                    }

                }
            }
            catch(Exception err)
            {
                createMessageBox(err.Message, "Thông báo");
            }
        }
        //khi nhấn nút không duyệt đề thi
        private void btn_not_checkout_Click(object sender, EventArgs e)
        {
            try
            {
                int examid = int.Parse(exam.Id);//lấy id của đề thi
                                                //tiến hành cập nhật tình trạng duyệt trong csdl
                                                //hỏi xác nhận trước
                DialogResult dialogResult = createMessageBoxYesNo("Bạn có chắc muốn bỏ duyệt đề thi này không ? ", "Thông báo");
                if (dialogResult == DialogResult.Yes)
                {
                    int checkout = 0; // 0 là không duyệt
                    int updateResult = examsBLL.updateExamCheckout(examid, checkout);
                    if (updateResult > 0)
                    {
                        createMessageBox("Bỏ duyệt đề thi thành công", "Thông báo");
                        //chuyển nút duyệt thành nút không duyệt
                        changeCheckoutButton(checkout);
                        //mở khóa toàn bộ các nút trong form (chỉ dành cho AM)
                        if (User.getInstance().getAccount().Rolename.Equals("AM"))
                        {
                            lockAllExamForm(true); //true là mở khóa
                            lockAllQuestionsForm(true);
                        }
                        
                        //bỏ stick ô duyệt
                        checkbox_checkout.Checked = false;
                        //gọi hàm cập nhật lại ở trang quản lý
                        changeData(1); //cập nhật
                    }

                }
            }
            catch (Exception err)
            {
                createMessageBox(err.Message, "Thông báo");
            }
        }

        //hàm khóa một số thành phần giao diện ở phần exam
        public void lockAllExamForm(bool lockControl) //lockControl = false : khóa
                                                      //lockControl = true : bỏ khóa
        {
            cb_dotime.Enabled = lockControl;
            btn_save_exam.Enabled = lockControl;
            btn_delete_exam.Enabled = lockControl;
        }
        //hàm khóa một số thành phần giao diện ở phần questions
        public void lockAllQuestionsForm(bool lockControl)
        {
            group_answers.Enabled = lockControl;
            group_type.Enabled = lockControl;
            rtxt_question_title.Enabled = lockControl;
           
            btn_update_question.Enabled = lockControl;
            btn_delete.Enabled = lockControl; //nút xóa câu hỏi
            btn_paste_question.Enabled = lockControl;
            btn_add_question.Enabled = lockControl;
        }
        //chuyển đỏi nút duyệt => duyệt và ngươc lại
        public void changeCheckoutButton(int checkout)
        {
            //nếu đang trong trạng thái duyệt thì chuyển nút thành không duyệt và ngược lại
            if(checkout == 1)//nếu đang trong trạng thái duyệt thì chuyển thành nút không duyệt
            {
                btn_checkout.Text = "Không duyệt đề thi";
                //xóa sự kiện cũ
                btn_checkout.Click -= btn_checkout_Click;
                //set sự kiện là hàm không duyệt
                btn_checkout.Click += btn_not_checkout_Click;
            }
            else // ngược lại nếu đang ở trạng thái không duyệt thì chuyển thành duyệt
            {
                btn_checkout.Text = "Duyệt đề thi";
                // xóa sự kiện cũ
                btn_checkout.Click -= btn_not_checkout_Click;
                //set sự kiện là hàm duyệt
                btn_checkout.Click += btn_checkout_Click;
            }
        }
        //thực hiện xóa đề thi
        private void btn_delete_exam_Click(object sender, EventArgs e)
        {
            //xác nhận trước khi xóa
            DialogResult dialogResult = createMessageBoxYesNo("Bạn có chắc muốn xóa đề thi này không ?", "Thông báo");
            if (dialogResult == DialogResult.Yes)
            {
                try
                {
                    //lấy id exam
                    int examid = int.Parse(exam.Id);
                    //tiến hành xóa
                    int deleteResult = examsBLL.deleteExam(examid);
                    if(deleteResult > 0) 
                    {
                        DialogResult dialogconfirm = createMessageBox("Xóa đề thi thành công","Thông báo");
                        if (dialogconfirm == DialogResult.OK)
                        {
                            //gọi hàm cập nhật lại ở trang quản lý
                            changeData(2); //dữ liệu bị xóa
                            this.Close();
                        }
                    }
                }
                catch (Exception err)
                {
                    createMessageBox(err.Message, "Thông báo");
                }

            }
        }
        //khi nhấn nút copy một đề thi
        private void btn_copy_exam_Click(object sender, EventArgs e)
        {
            Exams copiedExam = exam.Clone();
            
            User.getInstance().copiedExam = copiedExam;
        }
    }
}
