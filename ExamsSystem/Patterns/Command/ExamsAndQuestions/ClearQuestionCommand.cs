using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    class ClearQuestionCommand : EAQCommand
    {
        private QuestionHandling questionHandling;
        public ClearQuestionCommand(QuestionHandling questionHandling)
        {
            this.questionHandling = questionHandling;
        }
        public void execute()
        {
            questionHandling.clear();
        }
    }
}
