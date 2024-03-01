using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    //off một item trên menu
    class OffItemCommand : EAQCommand
    {
        private ToolStripMenuItem item;
        public OffItemCommand(ToolStripMenuItem item)
        {
            this.item = item;
        }
        public void execute()
        {
            item.Enabled = false;
        }
    }
}
