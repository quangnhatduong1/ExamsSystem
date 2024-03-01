using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using ExamsSystem.Patterns.Builder.Question;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.CastObject
{
    class QuestionsCDRStrategy : CDRStrategy
    {
        private QuestionBuilder builder;
        public object castDataRow(DataRow dataRow)
        {
           
            string id = dataRow[0].ToString();string title = dataRow[1].ToString();string answera = dataRow[2].ToString();string answerb = dataRow[3].ToString();string answerc = dataRow[4].ToString();string answerd = dataRow[5].ToString();string rightanswer = dataRow[6].ToString();int typeQuestion = int.Parse(dataRow[7].ToString());string subjectid = (dataRow[8].ToString());string subjectname =(dataRow[9].ToString());string username = dataRow[10].ToString();Subjects subject = new Subjects(subjectid, subjectname);
            //gôm 4 câu trả lời vào một mảng
            List<string> answers = new List<string>(){};
            answers.Add(answera);answers.Add(answerb);answers.Add(answerc);answers.Add(answerd);
            
            if (typeQuestion == 0) //nếu câu hỏi là dạng radiobuton
            {
                builder = new RadioQuestionBuilder();
            }
            else // nếu là dạng câu hỏi checkbox thì phải biến đổi câu trả lời đúng thành một mảng chuỗi các câu trả lời đúng
                //ví dụ ABC -> A và B và C
            {

                builder = new CheckboxQuestionBuilder();
            }
            //có thể xem lớp QuestionsCDRStrategy hiện tại như là một class Director (class sử dụng builder để khởi tạo đối tượng)
            Questions question = builder
                .buildTitle(title) //build title
                .buildSubject(subject) // build môn học
                .buildRightAnswer(rightanswer) // build câu trả lời đúng
                .buildQuestionType(typeQuestion) // build kiểu câu hỏi
                .buildOwner(username) //build chủ nhân
                .buildId(id) //build id
                .buildAnswers(answers) //build các câu trả lời cho câu hỏi
                .build(); //tiến hành build và trả về question

            return question;
        }
    }
}
