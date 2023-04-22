using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_Handler
{
    class Program
    {
        static void Main(string[] args)
        {
            CommandHandler ch = new CommandHandler();

            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("Enter Command: ");
                Console.ForegroundColor = ConsoleColor.White;
                string input = Console.ReadLine();
                Console.WriteLine(ch.runCommand(input));
            }
        }
    }
}
