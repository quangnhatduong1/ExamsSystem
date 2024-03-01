using ExamsSystem.BLL;
using ExamsSystem.MyForms;
using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.Visitor.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.StatePattern.DoingTest
{
    public class DoTestContext
    {
        private Timer aTimer;
        private DoTestState doTestState;
        private TestDoingForm testDoingForm;
        private Tests test;private int currentIndex = 0; // vị trí hiện tại của câu hỏi (mặc định bằng 0)
        private Exams exam;private GroupBox group_answers; //group đáp án mà người dùng chọn
        public DoTestContext(TestDoingForm testDoingForm,Tests test, GroupBox group_answers)
        {
            //khởi tạo lần đầu thì gán vị trí ở câu hỏi đầu tiên
            this.doTestState = new FirstQuestionState(this);
            this.testDoingForm = testDoingForm;this.test = test;this.exam = test.Exam;
            this.group_answers = group_answers;
            aTimer = new Timer();
            //update câu hỏi đầu tiên lên giao diện
            updateQuestionToView();
            //chạy hàm đếm thời gian làm bài
            countDownTimeDoTest();
        }
        public void changeState(DoTestState doTestState)
        {
            this.doTestState = doTestState;
        }
        public void clickNext()
        {
            doTestState.clickNext();
        }
        public void clickPrevious()
        {
            doTestState.clickPrevious();
        }
        public void clickCell(int cellIndex)
        {
            doTestState.clickCell(cellIndex);
        }
        public void clickSubmit()
        {
            doTestState.clickSubmit();
        }
        public void showAlert()
        {
            doTestState.showAlert();
        }
        //câu hỏi kế tiếp
        public void nextQuestion()
        {
            //lưu kết quả hiện tại mà người dùng chọn
            SaveUserAnswer();
            currentIndex += 1;
            updateQuestionToView();
        }
        //câu hỏi trước
        public void previousQuestion()
        {
            //lưu kết quả hiện tại mà người dùng chọn
            SaveUserAnswer();
            currentIndex -= 1;
            updateQuestionToView();
        }
        //nhảy đến 1 câu hỏi
        public void jumpToQuestion(int cellIndex)
        {
            //lưu kết quả hiện tại mà người dùng chọn
            SaveUserAnswer();
            currentIndex = cellIndex;
            updateQuestionToView();
        }
        //nộp bài
        public void submitTest()
        {
            //lưu kết quả làm bài hiện tại
            SaveUserAnswer();
            //lưu thời gian nộp bài
            DateTime submittime = DateTime.Now;
            test.Submittime = submittime.ToString("dd/MM/yyyy HH:mm:ss");
            //tiến hành chấm điểm cho bài test
           
            //thực hiện chấm bài
            QuestionsVisitor questionsVisitor = new MarkerQuestion();
            foreach (Questions question in exam.Questions)
            {
                //sử dụng marker question để chấm điểm từng câu hỏi của bài thi
                question.accept(questionsVisitor);
            }
            //lấy ra số lượng câu hỏi
            int countQuestion = exam.Questions.Count;
            //lấy ra số lượng câu đúng
            int countRightQuestion = exam.Questions.FindAll(t => t.Right == true).Count;
            //tính điểm
            double score = (countRightQuestion * 1.0 * 10.0) / countQuestion;
            score = Math.Round(score, 1);//làm trọn 1 chữ số thập phân
                                         //lưu thông tin vào csdl

            //thực hiện thêm vào csdl
            string username = User.getInstance().getAccount().Username;
            StudentsTestsBLL studentsTestsBLL = new StudentsTestsBLL();
            int SaveDoTestResult = studentsTestsBLL.saveDoTest(username, int.Parse(test.Id), test.Startdotime, test.Submittime, countRightQuestion, score);
            if (SaveDoTestResult > 0)
            {
                //khởi tạo lại timer để ngưng nó
                aTimer.Enabled = false;
                aTimer = new Timer();

                StudentsTests studentsTests = studentsTestsBLL.getStudentTest(username, int.Parse(test.Id));
                //hiển thị form hoàn thành bài thi
                FinishedDoTestForm form = (FinishedDoTestForm)FormFactory.getInstance().getForm("FinishedDoTest", studentsTests);
                testDoingForm.Hide();
                form.ShowDialog();
                testDoingForm.Close();



            }
        }
        
        //khóa thành động làm bài và sau đó đếm ngược thời gian nộp bài
        public void lockActionDoTest()
        {
            //khóa hành động chọn đáp án
            group_answers.Enabled = false;
            //đếm lùi thời gian tự động nộp bài
            countDownTimeDoSubmit();
        }
        //hàm xác nhận nộp bài
        public void submitTestConfirm()
        {
            DialogResult dialogResult = createMessageBoxYesNo("Bạn có chắc muốn nộp bài thi này không ? Khi đã nộp thì không thể quay lại làm nữa.", "Thông báo");
            //nếu người dùng đồng ý nộp bài thì tiến hành nộp bài
            if (dialogResult == DialogResult.Yes)
            {
                submitTest();
            }
        }
        //hàm thực hiện update câu hỏi lên giao diện
        private void updateQuestionToView()
        {
            //lấy ra câu hỏi
            Questions question = exam.Questions[currentIndex];
            //gọi hàm hiển thị question lên view
            testDoingForm.QuestionToView(question, currentIndex);
        }


        //lấy vị trí câu hỏi hiện tại
        public int getCurrentIndex()
        {
            return currentIndex;
        }
        //lấy số lượng câu hỏi
        public int getCountQuestions()
        {
            return exam.Questions.Count;
        }
        //lưu kết quả hiện tại mà người dùng chọn
        private void SaveUserAnswer()
        {
            //lấy câu hỏi hiện tại ra
            Questions question = exam.Questions[currentIndex];
            //tùy vào dạng câu hỏi mà lưu câu trả lời
            string userAnswer = "";
            foreach (Control control in group_answers.Controls)
            {
                if (control is RadioButton || control is CheckBox)
                {
                    if (question.TypeQuestion == 0)
                    {
                        RadioButton rd = (RadioButton)control;
                        if (rd.Checked)
                        {
                            userAnswer += rd.Tag.ToString();
                            break; //dạng câu hỏi 1 câu trả lời thì chỉ cần 1 lần là được
                        }
                    }
                    else
                    {
                        CheckBox cb = (CheckBox)control;
                        if (cb.Checked)
                        {
                            userAnswer += cb.Tag.ToString();

                        }
                    }
                }
            }
            //sau đó lưu vào biến question thông qua visitor
            question.accept(new SaveUserAnswer(userAnswer));
        }

        TimeSpan timeCountDoTest; // biến dùng để đếm thời gian làm bài
        //hàm đếm thời gian làm bài
        private void countDownTimeDoTest()
        {
            //lấy ra thời gian làm bài (số phút)
            double totalMinutes = test.Exam.Dotime;
          
            //chuyển về lại timeSpan để đếm
            timeCountDoTest = TimeSpan.FromMinutes(totalMinutes); // từ phút chuyển thành TimeSpan dựa theo phút (nếu hơn 59 phút tự đồng chuyển sang định dạng giờ )
                                                                  //hiển thị lên view lần đầu
            testDoingForm.changeContentCountDowm($"Bạn còn {timeCountDoTest.ToString()} để làm bài");
            aTimer.Enabled = false; //đóng trước
            aTimer = new Timer();// tạo mới
            aTimer.Interval = 1000; // ngắt quãng 1s (đếm lùi mỗi 1s)
            aTimer.Tick += new EventHandler(countDownDoTest); //thiết lập sự kiện khi bắt đầu đếm thời gian
            aTimer.Start();//bắt đầu đếm lùi
        }
        //hàm đếm ngược thời gian làm bài và up về giao diện
        private void countDownDoTest(object sender, EventArgs e)
        {

            double tmptimecount = timeCountDoTest.TotalSeconds - 1; /* lấy thời gian trong TimeSpan ra đổi thành giây và trừ đi 1 */
            timeCountDoTest = TimeSpan.FromSeconds(tmptimecount); /* chuyển nó lại dạng TimeSpan dựa theo số giây */
            //tiếp tục cập nhật giao diện người dùng
            testDoingForm.changeContentCountDowm($"Bạn còn {timeCountDoTest.ToString()} để làm bài");
            if (tmptimecount == 0) /* nếu đếm lùi đến 0 thì ngưng đếm */
            {
                aTimer.Stop();
                //tiếp tục chuyển người dùng sang trạng thái hết thời gian làm bài nếu người dùng chưa nộp bài
                changeState(new OverTimeState(this));
                showAlert();

            }
        }
        //hàm đếm ngược thời gian nộp bài
        TimeSpan timeCountDoSubmit; // biến dùng để đếm thời gian nộp bài
        private void countDownTimeDoSubmit()
        {
            //gán thời gian là 6s
            double totalMinutes = 0.1;
            //chuyển về lại timeSpan để đếm
            timeCountDoSubmit = TimeSpan.FromMinutes(totalMinutes); // từ phút chuyển thành TimeSpan dựa theo phút (nếu hơn 59 phút tự đồng chuyển sang định dạng giờ )
                                                                  //hiển thị lên view lần đầu
            testDoingForm.changeContentCountDowm($"Đã hết thời gian làm bài, hệ thống sẽ tự động nộp bài sau {timeCountDoSubmit.ToString()}");
            aTimer.Enabled = false; //đóng trước
            aTimer = new Timer();// tạo mới
            aTimer.Interval = 1000; // ngắt quãng 1s (đếm lùi mỗi 1s)
            aTimer.Tick += new EventHandler(countDownDoSubmit); //thiết lập sự kiện khi bắt đầu đếm thời gian
            aTimer.Start();//bắt đầu đếm lùi
        }
        private void countDownDoSubmit(object sender, EventArgs e)
        {

            double tmptimecount = timeCountDoSubmit.TotalSeconds - 1; /* lấy thời gian trong TimeSpan ra đổi thành giây và trừ đi 1 */
            timeCountDoSubmit = TimeSpan.FromSeconds(tmptimecount); /* chuyển nó lại dạng TimeSpan dựa theo số giây */
            //tiếp tục cập nhật giao diện người dùng
            testDoingForm.changeContentCountDowm($"Đã hết thời gian làm bài, hệ thống sẽ tự động nộp bài sau {timeCountDoSubmit.ToString()}");
            if (tmptimecount == 0) /* nếu đếm lùi đến 0 thì ngưng đếm */
            {
                aTimer.Stop();
                //tự động nộp bài
                submitTest();

            }
        }
        private DialogResult createMessageBoxYesNo(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            return MessageBox.Show(message, title, button);
        }

    }
}
