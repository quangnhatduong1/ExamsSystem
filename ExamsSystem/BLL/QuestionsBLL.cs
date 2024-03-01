using ExamsSystem.DAL;
using ExamsSystem.MyData;
using ExamsSystem.MyObjects.Question;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.StrategyPattern.CastObject;
using ExamsSystem.Patterns.StrategyPattern.ValidForm;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.BLL
{
    class QuestionsBLL
    {
        private QuestionsDAL questionsDAL;
        private MyCastObject myCastObject;
        private MyValid myValid;
        private CastObjectFactory getCast;
        public QuestionsBLL()
        {
            questionsDAL = new QuestionsDAL();
            getCast = new CastObjectFactory();
            myCastObject = new MyCastObject();
            myCastObject.setCDRStrategy(getCast.getCastObject("Questions"));
            
        }
        //hàm kiểm tra thông tin câu hỏi trước khi tạo
        private void checkQuestion(string title, string answerA, string answerB, string answerC, string answerD, string rightAnswer, int typeQuestion, int subjectid)
        {
            
            myValid = new QuestionValidator();
            myValid.valid(title);
            myValid = new AnswerValidator();
            myValid.valid(answerA);
            myValid.valid(answerB);
            myValid.valid(answerC);
            myValid.valid(answerD);
            if (rightAnswer == null || string.IsNullOrWhiteSpace(rightAnswer) )
            {
                if (typeQuestion == 0)
                {
                    throw new Exception("Vui lòng chọn câu trả lời đúng");
                }
                else
                {
                    throw new Exception("Vui lòng chọn ít nhất 1 câu trả lời đúng");
                }

            }
            if (subjectid == -1)
            {
                throw new Exception("Vui lòng chọn môn học");
            }
        }
        //hàm thêm một câu hỏi
        public int insert(string title, string answera, string answerb, string answerc, string answerd, string rightanswer, int typequestion, int subjectid,string username)
        {
            checkQuestion(title, answera, answerb, answerc, answerd, rightanswer, typequestion, subjectid);
            return questionsDAL.insert(title,answera,answerb,answerc,answerd,rightanswer,typequestion,subjectid,username);
        }
        
        //hàm thêm một câu hỏi và nhận lại giá trị id của câu hỏi từ việc thêm
        public int insertAndGetIt(string title, string answera, string answerb, string answerc, string answerd, string rightanswer, int typequestion, int subjectid,string username)
        {
            //gọi hàm kiểm tra thông tin trước khi thêm
            //hàm này tự throw lỗi nếu thông tin không hợp lệ
            checkQuestion(title, answera, answerb, answerc, answerd, rightanswer, typequestion, subjectid);
            DataRow dataRow = questionsDAL.insertAndGetIt(title, answera, answerb, answerc, answerd, rightanswer, typequestion, subjectid,username);
            int questionid = int.Parse(dataRow[0].ToString());
            return questionid;
        }
        //xóa một câu hỏi (theo id)
        public int deleteQuestion(int questionid)
        {
            return questionsDAL.deleteQuestion(questionid);
        }
        //lấy ra một câu hỏi theo id
        public Questions getQuestion(int id)
        {
            DataRow dataRow = questionsDAL.getQuestion(id);
            //cast dữ liệu lại thành Questions object
            return (Questions)myCastObject.CastDataRowToObject(dataRow);
        }
        //lấy ra danh sách câu hỏi theo id đề thi
        public DataTable getQuestionsListByExamsId(int examid)
        {
            return questionsDAL.getQuestionsListByExamsId(examid);
        }
        //lấy ra danh sách câu hỏi
        public DataTable getQuestionsList(string field_subject, string field_username)
        {
            return questionsDAL.getQuestionsList(field_subject, field_username);
        }
        //kiểm tra xem question có được dùng hay chưa thông qua truy vấn
        public DataRow getExam_Question(int questionid)
        {
            return questionsDAL.getExam_Question(questionid);
        }

        //update một câu hỏi
        public int updateQuestion(int questionid, string title, string answera, string answerb, string answerc, string answerd, string rightanswer, int typequestion, int subjectid)
        {
            return questionsDAL.updateQuestion(questionid, title, answera, answerb, answerc, answerd, rightanswer, typequestion, subjectid);
        }

    }
}
