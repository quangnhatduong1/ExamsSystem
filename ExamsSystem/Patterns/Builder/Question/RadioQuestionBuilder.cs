using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Builder.Question
{
    class RadioQuestionBuilder : QuestionBuilder
    {
        private string id;
        private string title;
        private List<string> answers; // danh sách câu trả lời
        private int typeQuestion;
        private Subjects subject;
        private string username;
        private string rightAnswer; // câu trả lời đúng (vì là dạng radio nên chỉ có một đáp án*/
       
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
            this.rightAnswer = rightanswer;
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
            return new RadioQuestions(id, title, answers, typeQuestion, subject, rightAnswer, username);
        }
    }
}
