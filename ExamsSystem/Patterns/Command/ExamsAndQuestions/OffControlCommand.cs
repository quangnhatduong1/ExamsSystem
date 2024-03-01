using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    class OffControlCommand : EAQCommand
    {
        private Control control;
        public OffControlCommand(Control control)
        {
            this.control = control;
        }
        public void execute()
        {
            control.Enabled = false;
        }
    }
}
