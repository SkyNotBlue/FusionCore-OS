using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace FusionCoreX86
{
    public class FusionCore : Sys.Kernel
    {

        protected override void BeforeRun()
        {
            Console.WriteLine("Booting FusionCore...");
        }

        protected override void Run()
        {
            Console.Clear();
            CoreConsole ConsInit = new CoreConsole();
            ConsInit.FusionCoreConsole();
        }
                
    }

}

