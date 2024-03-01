using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsSystem.MyTools;
using ExamsSystem.MyData;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.StrategyPattern.CastObject;

namespace ExamsSystem.DAL
{
    class AccountsDAL
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
        //lấy danh sách tài khoản
        public DataTable getList(string field_username, string field_rolename )
        {
            string querystring = "select username, rolename from accounts";
            object[] para = new object[5];
            int index = 0;
            if (!string.IsNullOrWhiteSpace(field_username))
            {
                querystring = createSearchValueString(querystring, " username like @username ");
                para[index] = field_username+"%"; //thêm kí hiệu % để toán tử like hoạt động
                index += 1;
            }
            if (!string.IsNullOrWhiteSpace(field_rolename))
            {
                querystring = createSearchValueString(querystring, " rolename = @rolename ");
                para[index] = field_rolename;
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
        //tạo một tài khoản
        public int insert(string username, string password, string rolename)
        {

            try
            {
                //chuẩn bị câu truy vấn
                string querystring = "insert into accounts(username, password, rolename) values ( @username , @password , @rolename )";
                //chuẩn bị dữ liệu
                object[] para = { username, password, rolename };
                //gọi lớp DataProvider để thêm vào csdl
                return DataProvider.Instance().ExecuteNonQuery(querystring, para);
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                //bị lỗi ở khúc này là do bị trùng khóa chính
                throw new Exception("Tài khoản đã tồn tại, vui lòng thử lại");
            }
        }
        //lấy ra một dòng tài khoản
        public DataRow getOne(string username)
        {
            // chuẩn bị câu truy vấn
            string querystring = "select top(1) username, password, rolename from accounts where username = @username ";
            //chuẩn bị dữ liệu
            object[] para = { username};
            //lấy ra một dòng dữ liệu đầu tiên từ kết quả trả về
            var dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            //gọi hàm lấy một hàng dữ liệu đầu tiên (là account cần tìm) trong DataTable vừa lấy được (có thể null nếu k tồn tại)
            return getOneRowFromDataTable(dataGet);
            
        }
        //update mật khẩu một tài khoản
        public int updatePassword(string username, string password)
        {
            string querystring = "update accounts set password = @password where username = @username ";
            object[] para = { password, username };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        
     

        //thêm thông tin cho tài khoản
        public int insertInformation(string username, string fullname, string birthday, string email, string phonenumber)
        {
            string querystring = " insert into information(username,fullname,birthday,email,phonenumber) values ( @username , @fullname , @birthday , @email , @phonenumber )";
            object[] para = { username, fullname, birthday, email, phonenumber };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        public int updateInformation(string username, string fullname, string birthday, string email, string phonenumber)
        {
            string querystring = " update information set fullname = @fullname ," +
                " birthday = @birthday , email = @email , phonenumber = @phonenumber " +
                "where username = @username ";
            object[] para = { fullname, birthday, email, phonenumber, username };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //lấy thông tin (information) - dựa vào username
        public DataRow getInformation(string username)
        {
            string querystring = "select top(1) fullname, birthday, phonenumber, email from information where username = @username ";
            object[] para = { username };
            var dataGet = DataProvider.Instance().ExecuteQuery(querystring,para);
            //gọi hàm lấy một hàng dữ liệu đầu tiên (là information cần tìm) trong DataTable vừa lấy được (có thể null nếu k tồn tại)
            return getOneRowFromDataTable(dataGet);
        }

        //chèn thông tin vào bảng students
        public int insertStudents(string username , string classname)
        {
            string querystring = "insert into students(username,classname) values ( @username , @classname ) ";
            object[] para = { username, classname };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //cập nhật thông bảng students
        public int updateStudents(string username, string classname)
        {
            string querystring = " update students set classname = @classname " +
                "where username = @username ";
            object[] para = { classname,username };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //lấy thông tin 1 student (cụ thể hơn là lấy ra lớp mà student này đang học)
        public DataRow getStudent(string username)
        {
            string querystring = " select top(1) classname from students where username = @username ";
            object[] para = { username };
            var dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            //gọi hàm lấy một hàng dữ liệu đầu tiên (là student cần tìm) trong DataTable vừa lấy được (có thể null nếu k tồn tại)
            return getOneRowFromDataTable(dataGet);
        }


        //chèn thông tin vào bảng teacher
        public int insertTeachers(string username)
        {
            string querystring = "insert into teachers(username) values ( @username ) ";
            object[] para = { username };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //lấy thông tin teaching(thông tin dạy học) -- số lượng nhiều
        public DataTable getTeaching(string username)
        {
            string querystring = " select id, name from subjects where id in " +
                "  (select subjectid from teaching where username = @username ) ";
            object[] para = { username };
            DataTable dataGet = DataProvider.Instance().ExecuteQuery(querystring, para);
            Console.WriteLine("count: " + dataGet.Rows.Count);
            return dataGet.Rows.Count > 0 ? dataGet : null;
        }
        //xóa thông tin trong bảng teaching (xóa hết -- vì một người dùng chỉ có tối 3 dòng)
        // xóa hết sẽ dễ dàng hơn trong việc cập nhật dữ liệu
        public int deleteTeaching(string username)
        {
            string querystring = "delete from teaching where username = @username ";
            object[] para = {username };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
        //update bằng việc thêm (mỗi lần chỉ thêm 1 lần)
        public int updateTeaching(string username, int subjectid)
        {
            string querystring = "insert into teaching values ( @username , @subjectid )";
            object[] para = { username, subjectid };
            return DataProvider.Instance().ExecuteNonQuery(querystring, para);
        }
    }
}
