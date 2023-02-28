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
                else if (input.StartsWith("about"))
                {
                    
                }
                else if (input.StartsWith("about"))
                {
                    Console.WriteLine("FusionCore Beta Version b0.0.2a. Codename Stanley.");
                    Console.WriteLine("(C) 2023 Reece Andersen. All source code under an MIT license.");
                    Console.WriteLine("echo - Echo's the text after it to the console.");
                    Console.WriteLine("theme - Changes the theme. For more help for the theme command, type 'help theme.");
                    Console.WriteLine("clear - Clears the screen of all clutter.");
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
            CoreConsole console = new CoreConsole();
            string clearText = input.Substring(6);
             Console.Clear();

        }
        private static void ThemeCommand(string input)
        {
            CoreConsole console = new CoreConsole();
             string ThemeText = input.Substring(6);
            if (ThemeText == "blackhat")
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                console.FusionCoreConsole();
            }
            else if (ThemeText == "darkmode")
            {
                Console.ForegroundColor = ConsoleColor.White;
                Console.BackgroundColor = ConsoleColor.Black;
                Console.Clear();
                console.FusionCoreConsole();
            }
              else if (ThemeText == "lightmode")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.White;
                Console.Clear();
                console.FusionCoreConsole();

            }
              else if (ThemeText == "whitehat")
            {
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Green;
                Console.Clear();
                console.FusionCoreConsole();

            }
          }
    }
}
