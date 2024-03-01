using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamsSystem.Patterns.Command.ExamsAndQuestions
{
    class EAQRemote
    {
        
        private List<EAQCommand> eAQCommands;
        public EAQRemote()
        {
            eAQCommands = new List<EAQCommand>();
            //tạo 20 slot trống
            for(int i=0; i < 20; i++)
            {
                eAQCommands.Add(null);
            }
        }
        //hàm thêm command không cần biết vị trí (thêm vào cuối)
        public void addCommand(EAQCommand command)
        {
            eAQCommands.Add(command);
        }
        public void deleteCommand(int index)
        {
            
            eAQCommands[index] = null;
        }
        //hàm set command vào một vị trí
        public void setCommand(EAQCommand command, int index)
        {
            
            eAQCommands[index] = command;
        }
        //hàm thực thi một command
        public void executeCommand(int index)
        {
            
            EAQCommand command = eAQCommands[index];
            if (command != null)
            {
                command.execute();
            }
            
        }
    }
}
