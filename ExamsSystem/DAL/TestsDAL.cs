using ExamsSystem.MyData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.DAL
{
    class TestsDAL
    {
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
        //thêm một test
        public int insertTest(int examid, string datestart, int openstate)
        {
            string querystring = "insert into tests(examid, datestart, openstate) values ( @examid , @datestart , @openstate )";
            object[] para = { examid, datestart, openstate };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //lấy danh sách bài tests
        public DataTable getTestsList(string field_subject, int field_openstate)
        {
            string querystring = "select tmp3.id as 'Mã số', tmp3.examid as 'Mã đề thi', tmp4.name as 'Môn học' ,tmp3.datestart as 'Thời gian mở', tmp3.openstate as 'Trạng thái mở' from subjects as tmp4 inner join(" +
                                    "(select tmp1.*, tmp2.subjectid as sjid from exams as tmp2 inner join(select * from tests) as tmp1 on tmp1.examid = tmp2.id)) as tmp3 on tmp3.sjid = tmp4.id";
            object[] para = new object[5];
            int index = 0;
            if (!string.IsNullOrWhiteSpace(field_subject))
            {
                querystring = createSearchValueString(querystring, " tmp4.name like @subjectname ");
                para[index] = field_subject+"%";
                index += 1;
            }
            if (field_openstate != -1)
            {
                querystring = createSearchValueString(querystring, " tmp3.openstate = @openstate ");
                para[index] = field_openstate;
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
        //lấy một bài test dựa vào id
        public DataRow getTest(int id)
        {
            string querystring = " select * from tests where id = @id ";
            object[] para = { id };
            DataTable dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            return getOneRowFromDataTable(dataGet);
        }
        //lấy giá trị count testid từ bảng students_tests để kiểm tra xem bài thi có được áp dụng (được làm hay chưa)
        public DataRow getCountStudentsTest(int testid)
        {
            string querystring = " select count(testid) as counttest from students_tests where testid = @testid group by testid ";
            object[] para = { testid };
            DataTable dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            return getOneRowFromDataTable(dataGet);
        }
        //cập nhật một bài thi
        public int updateTest(int examid, string datestart, int openstate , int testid)
        {
            string querystring = "update tests set examid = @examid , datestart = @datestart , openstate = @openstate where id = @testid  ";
            object[] para = { examid, datestart, openstate, testid };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //xóa một bài test
        public int deleteTest(int testid)
        {
            string querystring = "delete from tests where id = @testid ";
            object[] para = { testid };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        
    }
}
