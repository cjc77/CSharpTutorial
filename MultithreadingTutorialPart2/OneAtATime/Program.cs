using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OneAtATime
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var mutex = new Mutex (false, "Carson Cook Mutex Tutorial"))
            {
                // wait until other instances have the chance to shut down
                if (!mutex.WaitOne(TimeSpan.FromSeconds(3)))
                {
                    Console.WriteLine("Another instance of this application is already running.");
                    return;
                }
                RunProgram();
            }
        }

        static void RunProgram()
        {
            Console.WriteLine("Running... press [ENTER] to exit.");
            Console.ReadLine();
        }
    }
}
