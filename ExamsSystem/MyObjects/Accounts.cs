using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects
{
    public class Accounts
    {
        public Accounts(string username, string password, string rolename, string fullname, string birthday, string phonenumber, string email, string classname, List<Subjects> subjectsStudy)
        {
            //3 thông tin bắt buộc phải có
            Username = username;
            Password = password;
            Rolename = rolename;
            Fullname = fullname;
            Birthday = birthday;
            Phonenumber = phonenumber;
            Email = email;
            Classname = classname;
            SubjectStudy = subjectsStudy;
        }
        
        public string Username
        {
            get;set;
        }
        
        public string Rolename
        {
            get;set;
        }
       
        public string Password
        {
            get; set;
        }

        public string Fullname
        {
            get;set;
        }
        public string Birthday
        {
            get;set;
        }
        public string Phonenumber
        {
            get;set;
        }
        public string Email
        {
            get;set;
        }
        public string Classname
        {
            get;set;
        }
        //môn dạy học (dành cho giáo viên)
        public List<Subjects> SubjectStudy
        {
            get;set;
        }
    }
}
