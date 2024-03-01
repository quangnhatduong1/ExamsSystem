using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Builder.Account
{
    class AccountBuilder : MyBuilder
    {
        public string Username
        {
            get; set;
        }

        public string Rolename
        {
            get; set;
        }

        public string Password
        {
            get; set;
        }

        public string Fullname
        {
            get; set;
        }
        public string Birthday
        {
            get; set;
        }
        public string Phonenumber
        {
            get; set;
        }
        public string Email
        {
            get; set;
        }
        public string Classname
        {
            get; set;
        }
        //môn dạy học (dành cho giáo viên)
        public List<Subjects> SubjectStudy
        {
            get; set;
        }
        public MyBuilder addUsername(string username)
        {
            Username = username;
            return this;
        }
        public MyBuilder addRoleName(string rolename)
        {
            Rolename = rolename;
            return this;
        }
        public MyBuilder addPassword(string password)
        {
            Password = password;
            return this;
        }
        public MyBuilder addFullname(string fullname)
        {
            Fullname = fullname;
            return this;
        }
        public MyBuilder addPhonenumber(string phonenumber)
        {
            Phonenumber = phonenumber;
            return this;
        }
        public MyBuilder addEmail(string email)
        {
            Email = email;
            return this;
        }
        public MyBuilder addClassname(string classname)
        {
            Classname = classname;
            return this;
        }
        public MyBuilder addSubjectStudy(List<Subjects> subjectsStudy)
        {
            SubjectStudy = subjectsStudy;
            return this;
        }
        public MyBuilder addBirthday(string birthday)
        {
            Birthday = birthday;
            return this;
        }
        public Accounts build()
        {
            return new Accounts(Username, Password, Rolename, Fullname, Birthday, Phonenumber, Email, Classname, SubjectStudy);
        }
    }
}
