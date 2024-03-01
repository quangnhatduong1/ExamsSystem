using ExamsSystem.MyData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.DAL
{
    class ExamsDAL
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
        //thêm một exam mới
        public int insertExam(string username, int subjectid, int checkout, int dotime)
        {
            string querystring = "insert into exams(username, subjectid, checkout, dotime) " +
                "values ( @username , @subjectid , @checkout , @dotime )";
            object[] para = { username, subjectid, checkout, dotime };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //thêm một exam mới và lấy id của nó
        public DataRow insertExamAndGetIt(string username, int subjectid, int checkout, int dotime)
        {
            string querystring = "insert into exams(username, subjectid, checkout, dotime) Output Inserted.id " +
                "values ( @username , @subjectid , @checkout , @dotime )";
            object[] para = { username, subjectid, checkout, dotime };
            DataTable dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            return getOneRowFromDataTable(dataGet);
        }
        //lấy danh sách exam
        public DataTable getExamsList(string field_subject, string field_username)
        {
            string querystring = "select tmp2.id as 'ID', tmp2.username as 'Người tạo' , tmp1.name as 'Môn học' from exams as tmp2 inner join subjects as tmp1 on tmp1.id=tmp2.subjectid";
            object[] para = new object[5];
            int index = 0;
            if (!string.IsNullOrWhiteSpace(field_subject))
            {
                querystring = createSearchValueString(querystring, " tmp1.name like @subjectname ");
                para[index] = field_subject+"%";
                index += 1;
            }
            if (!string.IsNullOrWhiteSpace(field_username))
            {
                querystring = createSearchValueString(querystring, " tmp2.username like @username ");
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
        //lấy danh sách exam được duyệt
        //lấy danh sách đề thi đã được duyệt
        public DataTable getCheckedExamsList(int examid)
        {
            string querystring = "select tmp2.id as 'ID', tmp2.username as 'Người tạo' , tmp1.name as 'Môn học' from exams as tmp2 inner join subjects as tmp1 on tmp1.id=tmp2.subjectid where tmp2.checkout = 1 ";
            object[] para = new object[5];
            if (examid != -1)
            {
                querystring = createSearchValueString(querystring, " tmp2.id = @examid ");
                para[0] = examid;
            }
            return DataProvider.Instance().ExecuteQuery(querystring, para);
        }
        //lấy một exam (dựa vào id)
        public DataRow getExam(int id)
        {
            string querystring = "select top(1) tmp2.id , tmp2.username , tmp1.id , tmp1.name , tmp2.checkout , tmp2.dotime from exams as tmp2 inner join subjects as tmp1 on tmp1.id=tmp2.subjectid where " +
                "tmp2.id = @id ";
            object[] para = { id };
            DataTable dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            return getOneRowFromDataTable(dataGet);

        }
        //chèn một câu hỏi vào đề thi
        public int insertQuestionToExam(int examid, int questionid)
        {
            string querystring = "insert into exams_questions(questionid,examid) values ( @questionid , @examid ) ";
            object[] para = { questionid, examid };
            return DataProvider.Instance().ExecuteNonQuery(querystring,para);
        }
        //update một câu hỏi vào đề thi (thay thế vị trí đã có thành một id câu hỏi khác)
        public int updateQuestionToExam(int examid, int oldquestionid, int newquestionid)
        {
            string querystring = "update exams_questions set questionid = @newquestionid  where examid = @examid and questionid = @oldquestionid ";
            object[] para = { newquestionid, examid, oldquestionid };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //xóa một câu hỏi ra khỏi đề thi (xóa liên kết trong bảng exams_questions)
        public int deleteQuestionToExam(int examid, int questionid)
        {
            string querystring = "delete from exams_questions where examid = @examid and questionid = @questionid ";
            object[] para = { examid, questionid };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //update thời gian làm bài của đề thi
        public int updateExamDotime(int examid, int dotime)
        {
            string querystring = "update exams set dotime = @dotime where id = @examid ";
            object[] para = { dotime, examid };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //update trạng thái duyệt của đề thi
        public int updateExamCheckout(int examid, int checkout)
        {
            string querystring = "update exams set checkout = @checkout where id = @examid ";
            object[] para = { checkout, examid };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //xóa toàn bộ câu hỏi của đề thi
        public int deleteAllExamQuestions(int examid)
        {
            string querystring = "delete from exams_questions where examid = @examid ";
            object[] para = {  examid };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //xóa đề thi
        public int deleteExam(int examid)
        {
            string querystring = "delete from exams where id = @examid ";
            object[] para = { examid };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //hàm trả về một row chứa số lần xuất hiện của examid trong bảng test
        // để kiểm tra xem exam đã được áp dụng hay chưa ? (tức là đã được đem vào tổ chức thi chưa)
        public DataRow getExamsCountInTests(int examid)
        {
            string querystring = "select count(examid) as examcount from tests where examid = @examid ";
            object[] para = { examid };
            DataTable dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            return getOneRowFromDataTable(dataGet);
        }
    }
}
