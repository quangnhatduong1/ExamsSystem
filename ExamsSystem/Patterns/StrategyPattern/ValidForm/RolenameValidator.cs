using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.ValidForm
{
    class RolenameValidator : MyValid
    {
        public void valid(object ob)
        {
            string rolename = (string)ob;
            if (string.IsNullOrEmpty(rolename))
            {
                throw new Exception("Vui lòng chọn quyền tài khoản");
            }
        }
    }
}
