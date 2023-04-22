using System;
using System.Linq;

namespace Command_Handler.Commands
{
    class Beep : Command
    {
        public Beep(string name) : base(name) { }

        public override string execute(string[] args)
        {
            if (args.Length == 0)
            {
                Console.Beep();
                return "beep";
            }
            else if (args.Length == 1)
            {
                int i = 0;
                try
                {
                    while (i != Int32.Parse(args.First()))
                    {
                        Console.Beep();
                        i++;
                    }
                }
                catch (Exception)
                {
                    return "Unexpected argument " + args[0];
                }
                return $"beep {i}";
            }
            else
            {
                return "Invalid arguments for beep. Requires either 0 or 1 arguments";
            }
        }
    }
}
