using ExamsSystem.MyObjects;
using ExamsSystem.MyObjects.Question;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    class PasteQuestionCommand : EAQCommand
    {
        private QuestionHandling questionHandling;
        public PasteQuestionCommand(QuestionHandling questionHandling)
        {
            this.questionHandling = questionHandling;
        }
            
        
        public void execute()
        {
            questionHandling.paste();
        }  
    }
}
