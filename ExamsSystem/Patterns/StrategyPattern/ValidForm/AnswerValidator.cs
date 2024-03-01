using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StrategyPattern.ValidForm
{
    class AnswerValidator : MyValid
    {
        public void valid(object ob)
        {
            string mytext = (string)ob;
            if (string.IsNullOrWhiteSpace(mytext))
            {
                throw new Exception("Vui lòng nhập câu trả lời");
            }
            if (mytext.Length < 2)
            {
                throw new Exception("Độ dài câu trả lời quá ngắn");
            }
        }
    }
}
