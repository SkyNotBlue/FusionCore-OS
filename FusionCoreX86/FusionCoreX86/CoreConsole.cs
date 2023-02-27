using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace FusionCoreX86
{
    internal class CoreConsole
    {
        CoreConsole ConsInit = new CoreConsole();
        internal void FusionCoreConsole()
        {
            StartPoint:
            Console.WriteLine("FusionCore has booted successfully.");
            Console.WriteLine("FusionCoreX86 Version b0.0.1 Codename Stanley");
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
                else if (input.StartsWith("clear "))
                {
                    Console.Clear();
                    goto StartPoint;
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
        private static void ClearCommand(string input)
        {
            string clearText = input.Substring(6);
            if (clearText == "reset")
            {
                ConsInit.FusionCoreConsole();
                Console.Clear();
            }
            else if (clearText == " ")
            {
                Console.Clear();
            }
            else if (clearText == "")
            {
                Console.Clear();
            }
        }
        private static void ThemeCommand(string input)
        {
                string ThemeText = input.Substring(6);
            if (ThemeText == "blackhat")
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
            else if (ThemeText == "whitehat")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
            }
        }
    }
}
