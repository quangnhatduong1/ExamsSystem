using ExamsSystem.MyData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.DAL
{
    class StudentsTestsDAL
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
        //lấy danh sách các học sinh thi một bài thi
        public DataTable getStudentsByTestsId(int testid)
        {
            string querystring = "select tmp1.username as N'Tên tài khoản' , tmp2.classname as 'Lớp học' , tmp1.submittime as N'Thời gian nộp bài' , tmp1.rightanswercount as N'Số câu đúng', tmp1.score as N'Điểm' from students as tmp2  inner join"+
                                 "(select* from students_tests where testid = @testid ) as tmp1 on tmp1.username = tmp2.username";
            object[] para = { testid };
            return DataProvider.Instance().ExecuteQuery(querystring, para);
        }

        //lưu thông tin thực hiện một bài thi
        public int saveDoTest(string username, int testid, string startdotime, string submittime, int rightanswercount, double score)
        {
            string querystring = "insert into students_tests values( @username , @testid , @startdotime , @submittime , @rightanswercount , @score )";
            object[] para = { username, testid, startdotime, submittime, rightanswercount, score };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //lấy thông tin của một học sinh làm bài thi
        public DataRow getStudentTest(string username, int testid)
        {
            string querystring = "select * from students_tests where username = @username and testid = @testid ";
            object[] para = { username, testid };
            DataTable dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            return getOneRowFromDataTable(dataGet);
        }
        //lấy kết quả thi của một user
        public DataTable getResultTest(string username)
        {
            string querystring = "select tmp5.testid as 'Mã bài thi', tmp5.examid as 'Mã đề thi', tmp6.name as 'Môn thi', tmp5.startdotime as 'Thời gian làm bài', tmp5.submittime as 'Thời gian nộp bài', tmp5.rightanswercount as 'Số câu đúng', tmp5.score as 'Điểm số' from subjects as tmp6 inner join " + 
                                "(select tmp3.*, tmp4.subjectid from exams as tmp4 inner join"+
                                "(select tmp1.*, tmp2.id, tmp2.examid from tests as tmp2 inner join"+
                                "(select * from students_tests where username = @username ) as tmp1 on tmp1.testid = tmp2.id) as tmp3 on tmp3.examid = tmp4.id) as tmp5 on tmp5.subjectid = tmp6.id";
            object[] para = { username };
            return DataProvider.Instance().ExecuteQuery(querystring, para);
        } 
        //lấy kết quả thi của một user dựa vào môn học
        public DataTable getReSultTestBySubject(string username ,string subjectname)
        {
            string querystring = "select tmp5.testid as 'Mã bài thi', tmp5.examid as 'Mã đề thi', tmp6.name as 'Môn thi', tmp5.startdotime as 'Thời gian làm bài', tmp5.submittime as 'Thời gian nộp bài', tmp5.rightanswercount as 'Số câu đúng', tmp5.score as 'Điểm số' from subjects as tmp6 inner join " +
                                "(select tmp3.*, tmp4.subjectid from exams as tmp4 inner join" +
                                "(select tmp1.*, tmp2.id, tmp2.examid from tests as tmp2 inner join" +
                                "(select * from students_tests where username = @username ) as tmp1 on tmp1.testid = tmp2.id) as tmp3 on tmp3.examid = tmp4.id) as tmp5 on tmp5.subjectid = tmp6.id  where tmp6.name like @subjectname  ";
            object[] para = { username, subjectname+"%" };
            return DataProvider.Instance().ExecuteQuery(querystring, para);
        }
        //lấy kết quả thi của một user dựa vào mã đề thi
        public DataTable getReSultTestByTestid(string username, int testid)
        {
            string querystring = "select tmp5.testid as 'Mã bài thi', tmp5.examid as 'Mã đề thi', tmp6.name as 'Môn thi', tmp5.startdotime as 'Thời gian làm bài', tmp5.submittime as 'Thời gian nộp bài', tmp5.rightanswercount as 'Số câu đúng', tmp5.score as 'Điểm số' from subjects as tmp6 inner join " +
                                "(select tmp3.*, tmp4.subjectid from exams as tmp4 inner join" +
                                "(select tmp1.*, tmp2.id, tmp2.examid from tests as tmp2 inner join" +
                                "(select * from students_tests where username = @username ) as tmp1 on tmp1.testid = tmp2.id) as tmp3 on tmp3.examid = tmp4.id) as tmp5 on tmp5.subjectid = tmp6.id  where tmp5.testid  = @testid  ";
            object[] para = { username, testid };
            return DataProvider.Instance().ExecuteQuery(querystring, para);
        }
    }
}
