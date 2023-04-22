using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Handler.Commands
{
    class Help : Command
    {
        public Help(string name) : base(name) { }

        public override string execute(string[] args)
        {
            if (args.Length == 0)
            {
                CommandHandler ch = new CommandHandler();

                string helpList = "List of Commands: ";

                foreach (Command c in ch.commands)
                {
                    helpList += $"\n{c.name}";
                }

                return helpList;
            }
            else
            {
                return "Invalid arguments for help";
            }
        }
    }
}
