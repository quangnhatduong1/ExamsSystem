using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    class ClearTextCommand : EAQCommand
    {
        private Control control;
        public ClearTextCommand(Control control)
        {
            this.control = control;
        }
        public void execute()
        {
            //clear text trong richtextbox
            RichTextBox richTextBox = (RichTextBox)control;
            richTextBox.Text = null;
        }
    }
}
