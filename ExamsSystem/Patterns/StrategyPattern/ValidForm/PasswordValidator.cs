using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.ValidForm
{
    class PasswordValidator : MyValid
    {
        public void valid(object ob)
        {
            string password = (string)ob;
            if (password.Trim().Length <= 0)
            {
                throw new Exception("Vui lòng nhập mật khẩu");
            }
            if(password.Trim().Length <6 || password.Length > 12)
            {
                throw new Exception("Độ dài mật khẩu không hợp lệ");
            }
        }
    }
}
