using Command_Handler.Commands;
using System.Collections.Generic;
using System.Linq;

namespace Command_Handler
{
    class CommandHandler
    {
        public List<Command> commands;

        public CommandHandler()
        {
            this.commands = new List<Command>();

            this.commands.Add(new Beep("beep"));
            this.commands.Add(new File("file"));
            this.commands.Add(new Help("help"));
        }

        public string runCommand(string cmd)
        {
            string[] sp = cmd.Split(' ');
            string name = sp.First();
            string[] args = sp.Skip(1).ToArray();

            foreach (Command c in this.commands)
            {
                if (c.name.ToLower() == name)
                {
                    return c.execute(args);
                }
            }

            return $"Command \"{cmd}\" does not exist";
        }
    }
}