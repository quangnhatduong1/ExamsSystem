using ExamsSystem.BLL;
using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using ExamsSystem.Patterns.Observer;
using ExamsSystem.Patterns.Observer.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    class CreateQuestionCommand : EAQCommand
    {
        private QuestionHandling questionHandling;


        public CreateQuestionCommand(QuestionHandling questionHandling)
        {
            this.questionHandling = questionHandling;
        }
        public void execute()
        {
            questionHandling.create();
        }

    }
    
    
}
