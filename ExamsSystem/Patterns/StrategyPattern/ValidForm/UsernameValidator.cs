using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.ValidForm
{
    class UsernameValidator : MyValid
    {
        public void valid(object ob)
        {
            string username = (string)ob;
            if(username.Trim().Length <= 0)
            {
                throw new Exception("Vui lòng nhập tài khoản");
            }
            if(username.Length < 3 || username.Length > 18)
            {
                throw new Exception("Độ dài tài khoản không hợp lệ");
            }

            
        }
    }
}
