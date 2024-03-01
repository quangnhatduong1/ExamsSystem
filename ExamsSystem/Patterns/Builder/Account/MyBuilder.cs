using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Builder.Account
{
    public interface MyBuilder
    {
        public MyBuilder addUsername(string username);

        public MyBuilder addRoleName(string rolename);

        public MyBuilder addPassword(string password);

        public MyBuilder addFullname(string fullname);

        public MyBuilder addPhonenumber(string phonenumber);

        public MyBuilder addEmail(string email);

        public MyBuilder addClassname(string classname);

        public MyBuilder addSubjectStudy(List<Subjects> subjectsStudy);

        public MyBuilder addBirthday(string birthday);
        public Accounts build();
       

    }
}
