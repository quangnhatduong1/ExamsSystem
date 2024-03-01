using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsSystem.DAL;
using ExamsSystem.MyTools;
using System.Data;
using ExamsSystem.Patterns.StrategyPattern.CastObject;
using ExamsSystem.Patterns.FactoryMethod;

namespace ExamsSystem.BLL
{
    class AccountsBLL
    {
        private AccountsDAL accountsDAL;
        private MyCastObject myCastObject;
        private CastObjectFactory getCast;
        public AccountsBLL()
        {
            accountsDAL = new AccountsDAL();
            
            getCast = new CastObjectFactory();
            myCastObject = new MyCastObject();
            myCastObject.setCDRStrategy(getCast.getCastObject("Accounts"));
        }
        //lấy 1 tài khoản từ csdl
        public Accounts getAccount(string username)
        {
            //lấy 1 row account dựa trên thông tin user
            DataRow accountRow = accountsDAL.getOne(username);
            //gọi hàm chuyển đổi và cast dữ liệu
            Accounts account = (Accounts)myCastObject.CastDataRowToObject(accountRow);
            return account;
        }
        public int updatePassword(string username, string password)
        {
            return accountsDAL.updatePassword(username, password);
        }
        public Accounts checkLogin(string username, string password)
        {
            //lấy 1 row account dựa trên thông tin user
            DataRow accountRow = accountsDAL.getOne(username);
            //nếu tài khoản không tồn tại thì bắn ra lỗi
            if (accountRow == null)
            {
                throw new Exception("Tên tài khoản hoặc mật khẩu không đúng");
            }
            //nếu có row tồn tại thì lấy ra thông tin từ row
            string hashPassword = accountRow[1].ToString();
            //kiểm tra mật khẩu
            bool corretPass = MyHashPass.getInstance().verify(password, hashPassword);
            if (!corretPass)
            {
                throw new Exception("Tên tài khoản hoặc mật khẩu không đúng");
            }
            //nếu mật khẩu không có lỗi thì tiến hành cast object
            Accounts account = (Accounts)myCastObject.CastDataRowToObject(accountRow);
            
            return account;
        }
        //thực hiện đăng ký account
        public int Register(string username, string password, string rolename)
        {
            //mã hóa mật khẩu trước khi chèn vào csdl
            string encryptPassword = MyHashPass.getInstance().Encrypt(password);
            int resultAccount =  accountsDAL.insert(username, encryptPassword, rolename);

            if (resultAccount != 1)
            {
                throw new Exception("Đăng ký tài khoản không thành công, vui lòng thử lại");
            }
            return resultAccount;
        }
        //thực hiện thêm thông tin cá nhân của tài khoản vào bảng information
        public int insertInformation(string username, string fullname, string birthday, string email, string phonenumber)
        {
            return accountsDAL.insertInformation(username, fullname, birthday, email, phonenumber);
        }
        public int updateInformation(string username, string fullname, string birthday, string email, string phonenumber)
        {
            return accountsDAL.updateInformation(username, fullname, birthday, email, phonenumber);
        }
        //thực hiện chèn thông tin vào bảng students(đối với người dùng HS)
        public int insertStudents(string username, string classname)
        {
            return accountsDAL.insertStudents(username,classname);
        }
        public int updateStudents(string username, string classname)
        {
            return accountsDAL.updateStudents(username, classname);
        }
        //thực hiện chèn thông tin vào bảng teachers(đối với người dùng GV)
        public int insertTeachers(string username)
        {
            return accountsDAL.insertTeachers(username);
        }
        //xóa việc dạy học
        public int deleteTeaching(string username)
        {
            return accountsDAL.deleteTeaching(username);
        }
        //update việc dạy học
        public int updateTeaching(string username, List<Subjects> teachingList)
        {
            //đầu tiên xóa đi các dữ liệu teaching đang có (1 người tối đa chỉ có 3 record)
            //nên xóa sẽ dễ dàng hơn để kiểm soát dữ liệu -- sau đó thêm lại
            deleteTeaching(username);
            int result = 0;
            foreach(Subjects tc in teachingList)
            {
                //cập nhật theo username và tên môn học
                result=accountsDAL.updateTeaching(username, int.Parse(tc.SubjectID));
            }
            return result;
        }
        //lấy danh sách tài khoản
        public DataTable getAccountsList(string field_username, string field_rolename)
        {
            return accountsDAL.getList(field_username,field_rolename);
        }
      
    }
}
