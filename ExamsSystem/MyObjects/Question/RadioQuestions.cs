using ExamsSystem.Patterns.Visitor.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects.Question
{
    //dạng câu hỏi chỉ 1 câu trả lời
    public class RadioQuestions : Questions
    {
        public string RightAnswer // câu trả lời đúng (vì là dạng radio nên chỉ có một đáp án*/
        {
            get;set;
        }
        public string UserAnswer //câu trả lời của người dùng
        {
            get;set;
        }

        public RadioQuestions(string id, string title, List<string> answers, int type, Subjects subject, string rightAnswer,string username) :base(id,title,answers,type,subject, username)
        {
            RightAnswer = rightAnswer;
        }


        public override void accept(QuestionsVisitor questionVisitor)
        {
            questionVisitor.visitor(this);
        }

        public override Questions Clone()
        {
            RadioQuestions question = (RadioQuestions)this.MemberwiseClone();
            question.Id = null;
            question.RightAnswer = null;
          
            return question;
        }
    }
}
