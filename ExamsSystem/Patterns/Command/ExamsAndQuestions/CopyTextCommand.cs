using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    class CopyTextCommand : EAQCommand
    {
        private Control control;
        public CopyTextCommand(Control control)
        {
            this.control = control;
        }

        public void execute()
        {
            RichTextBox richTextBox = (RichTextBox)control;

            
          
            //lấy text phần bôi đen
            string textFormBox = richTextBox.SelectedText;
            //nếu người dùng bôi đen một phần text thì chỉ copy đoạn đó
            if (!string.IsNullOrWhiteSpace(textFormBox))
            {
                User.getInstance().copiedText = textFormBox;
            }
            //ngược lại thì copy toàn bộ
            else
            {
                User.getInstance().copiedText = richTextBox.Text;
            }
            
        }
    }
}
