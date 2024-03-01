using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Builder.Question
{
    class CheckboxQuestionBuilder : QuestionBuilder
    {
        private string id;
        private string title;
        private List<string> answers; // danh sách câu trả lời
        private int typeQuestion;
        private Subjects subject;
        private string username;
        private List<string> RightAnswers; // câu trả lời đúng (vì là dạng checkbox nên sẽ có nhiều câu trả lời đúng */
        public QuestionBuilder buildAnswers(List<string> answers)
        {
            this.answers = answers;
            return this;
        }
        public QuestionBuilder buildId(string id)
        {
            this.id = id;
            return this;
        }
        public QuestionBuilder buildOwner(string username)
        {
            this.username = username;
            return this;
        }
        public QuestionBuilder buildQuestionType(int typeQuestion)
        {
            this.typeQuestion = typeQuestion;
            return this;
        }
        public QuestionBuilder buildRightAnswer(string rightanswer)
        {
            // nếu là dạng câu hỏi checkbox thì phải biến đổi câu trả lời đúng thành một mảng chuỗi các câu trả lời đúng
            //ví dụ ABC -> A và B và C
            //chuyển đổi câu hỏi đúng thành nhiều câu trả lời nhỏ hơn
            List<string> rightAnswerList = new List<string>();
            foreach (char right in rightanswer)
            {
                rightAnswerList.Add(right.ToString());
            }
            this.RightAnswers = rightAnswerList;
            return this;
        }
        public QuestionBuilder buildSubject(Subjects subject)
        {
            this.subject = subject;
            return this;
        }
        public QuestionBuilder buildTitle(string title)
        {
            this.title = title;
            return this;
        }
        public Questions build()
        {
            return new CheckboxQuestions(id, title, answers, typeQuestion, subject, RightAnswers, username);
        }
    }
}
