using ExamsSystem.Patterns.Observer.DoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StatePattern.Test
{
    class ClosedTestState : TestState
    {
        public ClosedTestState()
        {

        }

        public override void action(DoTestObserver ob)
        {
            ob.refreshUI("Bài thi bạn muốn làm đã đóng", 0);
        }
    }
}
