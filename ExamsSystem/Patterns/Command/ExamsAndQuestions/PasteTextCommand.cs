using ExamsSystem.MyObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    class PasteTextCommand : EAQCommand
    {
        private Control control;
        public PasteTextCommand(Control control)
        {
            this.control = control;
        }
        public void execute()
        {
            //lấy text được copy ra
            string copiedText = User.getInstance().copiedText;
            Console.WriteLine(copiedText);
            //nếu text không rỗng thì gán vào control
            if (string.IsNullOrWhiteSpace(copiedText))
            {
                return;
            }
            RichTextBox richTextBox = (RichTextBox)control;
            //vị trí trỏ chuột
            int index = richTextBox.SelectionStart;
            Console.WriteLine(index);
            if(index >= 0) //nếu người có chỉ định vị trí để paste thì paste vào đó
            {
                
                //text có hiện tại trong richtextbox
                string currentText = richTextBox.Text;
                
               string newstring = currentText.Insert(index, copiedText);
                richTextBox.Text = newstring;
            }
            else // nếu người dùng không chỉ định thì thay thế toàn bộ
            {
                richTextBox.Text = copiedText;
            }
            
        }
    }
}
