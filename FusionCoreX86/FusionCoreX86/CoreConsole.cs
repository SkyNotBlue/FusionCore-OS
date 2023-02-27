using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace FusionCoreX86
{
    internal class CoreConsole
    {
        internal void FusionCoreConsole()
        {
            var loop = true;
            while (loop = true)
            {
                Console.Write("Ready. ");
                var input = Console.ReadLine();

                if (input.StartsWith("echo "))
                {
                    EchoCommand(input);
                }
                else if (input.StartsWith("theme "))
                {
                    ThemeCommand(input);
                }
                else
                {
                    Console.WriteLine("Invalid command.");
                }
            }


        }

        private static void EchoCommand(string input)
        {
            string echoText = input.Substring(5);
            Console.WriteLine(echoText);
            }
        private static void ThemeCommand(string input)
        {
                string ThemeText = input.Substring(6);
            if (ThemeText == "hacker")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (ThemeText == "darkmode")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
            }
            else if (ThemeText == "lightmode")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
        }
    }
}