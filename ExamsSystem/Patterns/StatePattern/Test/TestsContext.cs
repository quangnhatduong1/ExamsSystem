using ExamsSystem.Patterns.Observer.DoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StatePattern.Test
{
    public class TestsContext
    {
        private TestState testState;
        protected DoTestObserver doTestObserver;
        public TestsContext(DoTestObserver doTestObserver)
        {
            this.doTestObserver = doTestObserver;
            testState = new DefaultTestState();
        }
        //thiết lập state
        public void setState(TestState testState)
        {
            this.testState = testState;
        }
        //làm hành động gì đó
        public void actionState()
        {
            testState.action(doTestObserver);
        }
        public void setObserver(DoTestObserver doTestObserver)
        {
            this.doTestObserver = doTestObserver;
        }

    }
}
