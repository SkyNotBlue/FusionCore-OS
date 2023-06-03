using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Sys = Cosmos.System;

namespace FusionCoreX86
{
    public class FusionCore : Sys.Kernel
    {
        Sys.FileSystem.CosmosVFS fs;
        string current_directory = "0:\\";
        protected override void BeforeRun()
        {
            fs = new Sys.FileSystem.CosmosVFS();
            Sys.FileSystem.VFS.VFSManager.RegisterVFS(fs);
            Console.WriteLine("Booting FusionCore...");
        }

        protected override void Run()
        {
            string[] dirs = GetDirFadr(current_directory);
            var CoreVer = "b1.0A";
            Console.Clear();
        StartPoint:
            Console.WriteLine("FusionCore has booted successfully.");
            Console.WriteLine("FusionCoreX86 " + CoreVer + " Codename Stanley");
            var loop = true;
            while (loop == true)
            {
                Console.Write("Ready. " + current_directory + "> ");
                var input = Console.ReadLine();

                if (input.StartsWith("echo "))
                {
                    EchoCommand(input);
                }
                else if (input.StartsWith("theme "))
                {
                    ThemeCommand(input);
                }
                else if (input.StartsWith("clear"))
                {
                    Console.Clear();
                    goto StartPoint;
                }
                else if (input.StartsWith("about"))
                {
                    if (input.StartsWith("about theme"))
                    {
                        Console.WriteLine("There are 4 themes:");
                        Console.WriteLine("darkmode - default theme.");
                        Console.WriteLine("lightmode - inverted darkmode.");
                        Console.WriteLine("blackhat - green text, black background.");
                        Console.WriteLine("whitehat - blackhat but inverted.");
                    }
                    else
                    {
                        Console.WriteLine("FusionCore Beta Version " + CoreVer + " Codename Stanley.");
                        Console.WriteLine("(C) 2023 Reece Andersen. All source code under an MIT license.");
                        Console.WriteLine("echo - Echo's the text after it to the console.");
                        Console.WriteLine("theme - Changes the theme. For more help for the theme command, type 'about theme.");
                        Console.WriteLine("clear - Clears the screen of all clutter.");
                        Console.WriteLine("shutdown - Powers off your computer.");
                    }
                }
                else if (input.StartsWith("about theme"))
                {
                    Console.WriteLine("There are 4 themes:");
                    Console.WriteLine("darkmode - default theme.");
                    Console.WriteLine("lightmode - inverted darkmode.");
                    Console.WriteLine("blackhat - green text, black background.");
                    Console.WriteLine("whitehat - blackhat but inverted.");
                }
                else if (input.StartsWith("shutdown"))
                {
                    Sys.Power.Shutdown();
                }
                else if (input.StartsWith("dir"))
                {
                    foreach (var item in dirs)
                    {
                        Console.WriteLine(item);
                    }
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
            else
            {
                Console.WriteLine("Invalid Theme.");
            }
        }
        private string[] GetDirFadr(string adr) // Get Directories From Address
        {
            var dirs = Directory.GetDirectories(adr);
            return dirs;
        }
    }

}

