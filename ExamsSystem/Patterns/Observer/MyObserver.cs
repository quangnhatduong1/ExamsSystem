using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Observer
{
    public interface MyObserver
    {
        public void refreshUI(int changeType); //kiểu thay đổi: 0 thêm, 1: sửa, 2: xóa
    }
}
