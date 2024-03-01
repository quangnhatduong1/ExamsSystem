using ExamsSystem.Patterns.Observer.DoTest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.StatePattern.Test
{
    class AwayFromTestState : TestState
    {
        //trạng thái khi ngày làm bài quá xa ngày mở bài
        private string dateopen;
        public AwayFromTestState(string dateopen)
        {
            this.dateopen = dateopen;
        }

        public override void action(DoTestObserver ob)
        {
            ob.refreshUI($"Vui lòng quay trở lại vào {dateopen} để làm bài", 0);
        }
    }
}
