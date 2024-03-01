using ExamsSystem.MyObjects.Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Visitor.Questions
{
    public interface QuestionsVisitor
    {
        public void visitor(RadioQuestions radioQuestions);
        public void visitor(CheckboxQuestions checkboxQuestions);
    }
}
