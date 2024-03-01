using ExamsSystem.Patterns.Visitor.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.Question
{
    //dạng câu hỏi nhiều câu trả lời
    public class CheckboxQuestions : Questions
    {
        public List<string> RightAnswer // câu trả lời đúng (vì là dạng checkbox nên sẽ có nhiều câu trả lời đúng */
        {
            get; set;
        }
        public List<string> UserAnswer // câu trả lời của người dùng (vì là dạng checkbox nên sẽ có nhiều câu trả */
        {
            get;set;
        }
        public CheckboxQuestions(string id, string title, List<string> answers, int type, Subjects subject, List<string> rightAnswers,string username) : base(id,title, answers, type, subject, username)
        {
            RightAnswer = rightAnswers;
        }
        //visitor dùng để chấm điểm
        public override void accept(QuestionsVisitor questionVisitor)
        {
            questionVisitor.visitor(this);
        }
        public override Questions Clone()
        {
            
            CheckboxQuestions question = (CheckboxQuestions)this.MemberwiseClone();
            question.Id = null;
            question.RightAnswer = new List<string>();
  
            return question;
        }
    }
}
