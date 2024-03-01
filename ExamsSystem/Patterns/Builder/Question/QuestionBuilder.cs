using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Builder.Question
{
    public interface QuestionBuilder
    {
        //mã câu hỏi
        public QuestionBuilder buildId(string id);
        //tiêu đề câu hỏi
        public QuestionBuilder buildTitle(string title);
        //mảng câu trả lời
        public QuestionBuilder buildAnswers(List<string> answers);
        //câu trả lời đúng
        public QuestionBuilder buildRightAnswer(string rightanswer);
        //kiểu câu trả lời
        public QuestionBuilder buildQuestionType(int typeQuestion);
        //môn học
        public QuestionBuilder buildSubject(Subjects subject);
        //chủ câu hỏi
        public QuestionBuilder buildOwner(string username);
        //tiến hành build và trả về 1 question
        public Questions build();

    }
}
