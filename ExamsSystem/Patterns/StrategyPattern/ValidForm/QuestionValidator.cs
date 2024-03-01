using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.ValidForm
{
    class QuestionValidator : MyValid
    {
        public void valid(object ob)
        {
            string mytext = (string)ob;
            if (string.IsNullOrWhiteSpace(mytext))
            {
                throw new Exception("Vui lòng nhập câu hỏi");
            }
            if(mytext.Length < 6)
            {
                throw new Exception("Độ dài câu hỏi quá ngắn");
            }
        }
    }
}
