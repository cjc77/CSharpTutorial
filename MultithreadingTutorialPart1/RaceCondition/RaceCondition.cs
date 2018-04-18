using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Part4
{
    class RaceCondition
    {
        // static fields shared between all threads
        static bool done;

        static void Main(string[] args)
        {
            new Thread(Go).Start();
        }

        static void Go()
        {
            //if (!done) { done = true; Console.WriteLine("Done"); }
            // 'done' may or may not be printed twice
            if (!done) { Console.WriteLine("Done"); done = true; }
        }
    }
}
