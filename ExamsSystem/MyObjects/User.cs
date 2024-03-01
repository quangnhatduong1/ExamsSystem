using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.MyObjects
{
    //class lưu một số dữ liệu
    class User
    {
        private Accounts account;
        private static User instance;
        private User() { }
        public static User getInstance()
        {
            if (instance == null)
            {
                instance = new User();
            }
            return instance;
        }
        public void setAccount(Accounts account)
        {
            instance.account = account;
        }
        public Accounts getAccount()
        {
            return instance.account;
        }
        //câu hỏi được copy 
        public Questions copiedQuestion { get; set; }
        //đề thi được copy
        public Exams copiedExam{ get; set; }
        
        //Text được copy
        public string copiedText { get; set; }
    }
}
