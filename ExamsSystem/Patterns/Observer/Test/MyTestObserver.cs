using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Observer.Test
{
    public interface MyTestObserver
    {
        public void refreshUI(Tests test, int option); // option: 0: thêm, 1: sửa,  2: xóa
    }
}
