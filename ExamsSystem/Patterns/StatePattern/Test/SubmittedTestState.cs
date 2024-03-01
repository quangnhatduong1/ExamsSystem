using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.Observer.DoTest;
using ExamsSystem.Patterns.Visitor.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.StatePattern.Test
{
    //trạng thái đã nộp bài
    class SubmittedTestState : TestState
    {
        private Tests test;
        private StudentsTestsBLL studentsTestsBLL;
        public SubmittedTestState(Tests test)
        {
            this.test = test;
            studentsTestsBLL = new StudentsTestsBLL();
        }
        public override void action(DoTestObserver ob)
        {
            //tiến hành chấm điểm cho bài test
            //lấy bài exam ra
            Exams exam = test.Exam;
            //thực hiện chấm bài
            QuestionsVisitor questionsVisitor = new MarkerQuestion();
            foreach(Questions question in exam.Questions)
            {
                //sử dụng marker question để chấm điểm từng câu hỏi của bài thi
                question.accept(questionsVisitor);
            }
            //lấy ra số lượng câu hỏi
            int countQuestion = exam.Questions.Count;
            //lấy ra số lượng câu đúng
            int countRightQuestion = exam.Questions.FindAll(t => t.Right ==true).Count;
            //tính điểm
            double score = (countRightQuestion * 1.0 * 10.0) / countQuestion;
            score = Math.Round(score, 1);//làm trọn 1 chữ số thập phân
            //lưu thông tin vào csdl
          
                //thực hiện thêm vào csdl
                string username = User.getInstance().getAccount().Username;
                int SaveDoTestResult = studentsTestsBLL.saveDoTest(username, int.Parse(test.Id), test.Startdotime, test.Submittime, countRightQuestion, score);
                if(SaveDoTestResult > 0)
                {
                    //tiến hành lấy dữ liệu mới thêm
                    StudentsTests studentsTests = studentsTestsBLL.getStudentTest(username, int.Parse(test.Id));
                    //chuyển sang trạng thái đã hoàn thành bài thi
                    ob.refreshUI(new FinishedTestState(studentsTests), 3);//option nghĩa là gửi một dữ liệu state thuộc nhánh teststate

                }
          
            
        }
    }
}
