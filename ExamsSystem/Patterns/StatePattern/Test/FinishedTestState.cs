using ExamsSystem.MyObjects;
using ExamsSystem.Patterns.FactoryMethod;
using ExamsSystem.Patterns.Observer.DoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.StatePattern.Test
{
    class FinishedTestState : TestState
    {
        private StudentsTests studentsTests;
        public FinishedTestState(StudentsTests studentsTests)
        {
            this.studentsTests = studentsTests;
        }
        public override void action(DoTestObserver ob)
        {
            //sau đó kêu observer mở form hoàn thành
            Form form = FormFactory.getInstance().getForm("FinishedDoTest", studentsTests);
            ob.refreshUI(form, 2);
        }
    }
}
