using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.StatePattern.DoingTest
{
    public abstract class DoTestState
    {
        protected DoTestContext doTestContext;
        public DoTestState(DoTestContext doTestContext)
        {
            this.doTestContext = doTestContext;
        }
        public void setContext(DoTestContext doTestContext)
        {
            this.doTestContext = doTestContext;
        }
        public abstract void clickNext();
        public abstract void clickPrevious();
        public abstract void clickCell(int cellIndex);
        public abstract void clickSubmit();
        public abstract void showAlert();
        protected DialogResult createMessageBoxYesNo(string message, string title)
        {
            MessageBoxButtons button = MessageBoxButtons.YesNo;
            return MessageBox.Show(message, title, button);
        }
    }
}
