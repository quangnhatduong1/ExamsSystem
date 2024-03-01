using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Observer.Question
{
    //observer cho việc nhận câu hỏi mới
    public interface MyQuestionObserver
    {

        public void refreshUI(Questions question);
    }
}
