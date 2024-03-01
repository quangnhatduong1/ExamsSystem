using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Observer.DoTest
{
    public interface DoTestObserver
    {
        public void refreshUI(object data, int option);
    }
}
