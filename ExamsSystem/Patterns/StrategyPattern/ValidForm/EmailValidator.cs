using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.ValidForm
{
    class EmailValidator : MyValid
    {
        public void valid(object ob)
        {
            string email = (string)ob;
            if (!string.IsNullOrWhiteSpace(email))
            {
                Regex reg = new Regex(@"\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*");
                if (!reg.IsMatch(email))
                {
                    throw new Exception("Định dạng email không hợp lệ");
                }
            }
        }
    }
}
