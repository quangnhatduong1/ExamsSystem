using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    class OnControlCommand : EAQCommand
    {
        private Control control;
        public OnControlCommand(Control control)
        {
            this.control = control;
        }
        public void execute()
        {
            control.Enabled = true; ;
        }
    }
}
