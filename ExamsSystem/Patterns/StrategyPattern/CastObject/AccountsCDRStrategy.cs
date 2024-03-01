using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExamsSystem.DAL;
using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.Builder.Account;

namespace ExamsSystem.Patterns.StrategyPattern.CastObject
{
    public class AccountsCDRStrategy : CDRStrategy
    {
        private AccountsDAL accountsDAL; //sử dụng DAL để lấy thêm nhiều thông tin hơn
        private MyBuilder accountBuilder;
        public AccountsCDRStrategy()
        {
            accountsDAL = new AccountsDAL();
            accountBuilder = new AccountBuilder();
        }
        public object castDataRow(DataRow dataRow)
        {
            DataRow dataRowAccount = dataRow;
            string username = dataRowAccount[0].ToString();
            string password = dataRowAccount[1].ToString();
            string rolename = dataRowAccount[2].ToString();
            //sử dụng builder để xây dựng thông tin tài khoản
            
            accountBuilder
                .addUsername(username)
                .addPassword(password)
                .addRoleName(rolename);
            //tiếp tục lấy information
            getInformation(username,accountBuilder);
            
            //kiểm tra quyền để lấy thêm classname(đối với học sinh) và teaching(thông tin dạy học) (đối với giáo viên)
            if (rolename == "HS") //nếu là học sinh thì lấy thêm thông tin đang học lớp nào
            {
                getClassName(username, accountBuilder);
            }
            else if (rolename == "GV" || rolename == "AM")// nếu là giáo viên thì lấy thêm thông tin đang dạy học những môn nào
            {
                getTeaching(username, accountBuilder);
            }

            //cuối cùng là build đối tượng account dựa trên những thông tin đã thêm
            Accounts account = accountBuilder.build();
            return account;
        }
        private void getInformation(string username, MyBuilder accountBuilder)
        {
            DataRow dataRowInformation = accountsDAL.getInformation(username);
            if (dataRowInformation != null)
            {
                string fullname = dataRowInformation[0].ToString();
                string birthday = dataRowInformation[1].ToString();
                string phonenumber = dataRowInformation[2].ToString();
                string email = dataRowInformation[3].ToString();
                accountBuilder
                    .addFullname(fullname)
                    .addBirthday(birthday)
                    .addPhonenumber(phonenumber)
                    .addEmail(email);
            }
        }
        private void getClassName(string username, MyBuilder accountBuilder)
        {
            DataRow dataRowStudent = accountsDAL.getStudent(username);
            if (dataRowStudent != null)
            {
                string classname = dataRowStudent[0].ToString();
                accountBuilder.addClassname(classname);
            }
        }
        private void getTeaching(string username, MyBuilder accountBuilder)
        {
            DataTable dataTeaching = accountsDAL.getTeaching(username);
            if (dataTeaching != null)
            {
                List<Subjects> teachingList = new List<Subjects>();
                //duyệt mảng để lấy thông tin các môn học mà người dùng đang dạy
                foreach(DataRow dt in dataTeaching.Rows)
                {
                    //id môn học
                    string id = dt[0].ToString();
                    //tên môn học
                    string name = dt[1].ToString();
                   
                    teachingList.Add(new Subjects(id, name));
                }
                accountBuilder.addSubjectStudy(teachingList);
                
            }
        }
    }
}
