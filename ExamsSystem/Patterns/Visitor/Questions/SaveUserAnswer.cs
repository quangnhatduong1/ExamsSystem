using ExamsSystem.MyObjects.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Visitor.Questions
{
    //class visitor dùng để lưu câu trả lời của người dùng
    class SaveUserAnswer : QuestionsVisitor
    {
        private string userAnswer;
        public SaveUserAnswer(string userAnswer)
        {
            this.userAnswer = userAnswer;
        }
        public void visitor(RadioQuestions radioQuestions)
        {
            //nếu là câu hỏi dạng 1 câu trả lời thì đơn giản thêm vào là được
            radioQuestions.UserAnswer = userAnswer;
        }

        public void visitor(CheckboxQuestions checkboxQuestions)
        {
            //nếu là câu hỏi dạng nhiều câu trả lời thì phải foreach
            //từng kí tự (tương ứng với mỗi câu A,B,C,D) rồi add vào mảng
            List<string> userAnswers = new List<string>();
            if (!string.IsNullOrWhiteSpace(userAnswer)) //nếu không có câu trả lời thì không làm gì
            {
                foreach (char us in userAnswer)
                {
                    userAnswers.Add(us.ToString());
                }
            }
            
            
            //lưu lại kết quả
            checkboxQuestions.UserAnswer = userAnswers;
            
        }
    }
}
