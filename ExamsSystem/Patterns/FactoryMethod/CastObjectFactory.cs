using ExamsSystem.Patterns.StrategyPattern.CastObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.FactoryMethod
{
    class CastObjectFactory
    {
        public CDRStrategy getCastObject(string name)
        {
            switch (name)
            {
                case "Accounts":
                    return new AccountsCDRStrategy();
                case "Exams":
                    return new ExamsCDRStrategy();
                case "Questions":
                    return new QuestionsCDRStrategy();
                case "StudentsTests":
                    return new StudentsTestsCDRStrategy();
                case "Tests":
                    return new TestsCDRStrategy();
                default:
                    return null;
            }
                
        }
    }
}
