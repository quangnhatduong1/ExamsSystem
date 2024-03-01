using ExamsSystem.MyObjects.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Visitor.Questions
{
    //visitor dùng để chấm điểm
    public class MarkerQuestion : QuestionsVisitor
    {
        public void visitor(RadioQuestions radioQuestions)
        {

            //thực hiện chấm điểm theo câu hỏi dạng radio
            //lấy ra câu trả lời của người dùng
            string userAnswer = radioQuestions.UserAnswer != null ? radioQuestions.UserAnswer : "" ;
            //lấy ra câu trả lời đúng
            string rightAnswer = radioQuestions.RightAnswer;
            if (userAnswer.Equals(rightAnswer))
            {
                radioQuestions.Right = true;
            }
            else
            {
                radioQuestions.Right = false;
            }
        }

        public void visitor(CheckboxQuestions checkboxQuestions)
        {
            //thực hiện chấm điểm theo câu hỏi dạng checkbox
            //lấy ra câu trả lời của người dùng
             
            List<string> userAnswers = checkboxQuestions.UserAnswer !=null ? checkboxQuestions.UserAnswer : new List<string>();
            string userAnswer = "";
            foreach(string ua in userAnswers)
            {
                userAnswer += ua;
            }
            //lấy ra câu trả lời đúng
            List<string> rightAnswers = checkboxQuestions.RightAnswer;
            string rightAnswer = "";
            foreach(string ra in rightAnswers)
            {
                rightAnswer += ra;
            }
            if (userAnswer.Equals(rightAnswer))
            {
                checkboxQuestions.Right = true;
            }
            else
            {
                checkboxQuestions.Right = false;
            }
        }
    }
}
