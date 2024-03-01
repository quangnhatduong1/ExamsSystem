using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    class OnItemMenuCommand : EAQCommand
    {
        private ToolStripMenuItem item;
        public OnItemMenuCommand(ToolStripMenuItem item)
        {
            this.item = item;
        }
        public void execute()
        {
            item.Enabled = true; ;
        }
    }
}
