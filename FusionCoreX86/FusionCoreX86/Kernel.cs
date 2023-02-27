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
            Console.WriteLine("FusionCore has booted successfully.");
            Console.WriteLine("FusionCoreX86 Version b0.0.1 Codename Stanley");
        }

        protected override void Run()
        {
            CoreConsole ConsInit = new CoreConsole();
            ConsInit.FusionCoreConsole();
        }
                
    }

}

