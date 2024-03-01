using ExamsSystem.MyData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.DAL
{
    class QuestionsDAL
    {
        //hàm lấy dữ liệu 1 row của một DataTable (nếu có) -- hoặc là không có sẽ null
        private DataRow getOneRowFromDataTable(DataTable dataTable)
        {
            //nếu > 0 ==> tồn tại
            if (dataTable.Rows.Count > 0)
            {
                return dataTable.Rows[0];
            }
            //nếu tới đây thì nghĩa là không tồn tại
            return null;
        }
        //thêm một câu hỏi
        public int insert(string title, string answera, string answerb, string answerc, string answerd, string rightanswer, int typequestion, int subjectid, string username)
        {
            string querystring = "insert into questions(title,answera,answerb,answerc,answerd,rightanswer,typequestion,subjectid,username) values" +
                "(  @title , @answera , @answerb , @answerc , @answerd , @rightanswer , @typequestion , @subjectid , @username )";
            object[] para = { title, answera, answerb, answerc, answerd, rightanswer, typequestion, subjectid , username };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //thêm một câu hỏi và nhận về id của câu hỏi mới thêm
        public DataRow insertAndGetIt(string title, string answera, string answerb, string answerc, string answerd, string rightanswer, int typequestion, int subjectid, string username)
        {
            string querystring = "insert into questions(title,answera,answerb,answerc,answerd,rightanswer,typequestion,subjectid,username) Output Inserted.id values" +
                "(  @title , @answera , @answerb , @answerc , @answerd , @rightanswer , @typequestion , @subjectid , @username )";
            object[] para = { title, answera, answerb, answerc, answerd, rightanswer, typequestion, subjectid ,username};
            DataTable dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            return getOneRowFromDataTable(dataGet);
        }
        //xóa một câu hỏi (theo id)
        public int deleteQuestion(int questionid)
        {
            string querystring = " delete from questions where id = @questionid ";
            object[] para = { questionid };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //lấy ra một câu hỏi theo id (có kèm môn học)
        public DataRow getQuestion(int id)
        {
            string querystring = "select tmp1.id, tmp1.title, tmp1.answera , tmp1.answerb , tmp1.answerc , tmp1.answerd , tmp1.rightanswer , tmp1.typequestion , tmp1.subjectid ,tmp2.name, tmp1.username from subjects as tmp2 inner join " +
                "(select top(1) * from questions where id = @id ) as tmp1 on tmp1.subjectid = tmp2.id";
            object[] para = { id };
            DataTable dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            return getOneRowFromDataTable(dataGet);
        }
        //lấy ra danh sách câu hỏi theo id đề thi
        public DataTable getQuestionsListByExamsId(int examid)
        {
            string querystring = " select tmp1.id, tmp1.title, tmp1.answera , tmp1.answerb , tmp1.answerc , tmp1.answerd , tmp1.rightanswer , tmp1.typequestion , tmp1.subjectid ,tmp2.name , tmp1.username from subjects as tmp2 inner join (select tmp0.*,tmp.id as tmpid from questions as tmp0 inner join (select * from exams_questions where examid = @examid ) as tmp on tmp.questionid = tmp0.id ) as tmp1 on tmp1.subjectid = tmp2.id order by tmp1.tmpid";
            object[] para = { examid };
            DataTable dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            return dataGet;
        }
        //lấy ra sách danh câu hỏi
        public DataTable getQuestionsList(string field_subject, string field_username)
        {
            object[] para = new object[5];
            int index = 0;
            string querystring = "select tmp1.id as 'Mã câu hỏi', tmp1.username as 'Người tạo' , tmp2.name as 'Môn học' , tmp1.typequestion as 'Dạng câu hỏi' from subjects as tmp2 inner join(" +
                                  "select* from questions) as tmp1 on tmp1.subjectid = tmp2.id";
            if (!string.IsNullOrWhiteSpace(field_subject))
            {
                querystring = createSearchValueString(querystring, " tmp2.name like @subjectname ");
                para[index] = field_subject+"%"; //thêm dấu % để toán tử like hoạt động
                index += 1;
            }
            if (!string.IsNullOrWhiteSpace(field_username))
            {
                querystring = createSearchValueString(querystring, " tmp1.username like @username ");
                para[index] = field_username+"%";
                index += 1;
            }
            return DataProvider.Instance().ExecuteQuery(querystring, para);
            
        }
        //tạo thêm một số giá trị truy vấn
        private string createSearchValueString(string querystring, string valuesearch)
        {
            if (querystring.Contains("where"))
            {
                querystring += " and ";
            }
            else
            {
                querystring += " where ";
            }
            querystring += valuesearch;
            return querystring;
        }
        //kiểm tra xem question có được dùng hay chưa thông qua truy vấn
        public DataRow getExam_Question(int questionid)
        {
            string querystring = "select * from exams_questions where questionid = @questionid ";
            object[] para = { questionid };
            DataTable dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            return getOneRowFromDataTable(dataGet);
        }
        //update một câu hỏi
        public int updateQuestion(int questionid, string title, string answera, string answerb, string answerc, string answerd, string rightanswer, int typequestion, int subjectid)
        {
            string querystring = "update questions set title = @title , answera = @answera , answerb = @answerb , answerc = @answerc , answerd = @answerd , rightanswer = @rightanswer , typequestion = @typequestion , subjectid = @subjectid where id = @questionid ";
            object[] para = { title, answera, answerb, answerc, answerd, rightanswer, typequestion, subjectid, questionid };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }

    }
}
