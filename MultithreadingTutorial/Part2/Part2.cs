using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Part2
{
    class Part2
    {
        const int LOOPS = 5;
        const int RANGE = 10;
        static Random rand = new Random();
        static void Main(string[] args)
        {
            Thread t = new Thread(LoopAndPrintRandom);
            Thread.CurrentThread.Name = "Thread 1";
            t.Name = "Thread 2";
            t.Start();
            LoopAndPrintRandom();
        }

        static void LoopAndPrintRandom()
        {
            int temp;
            for (int i = 0; i < LOOPS; i++)
            {
                temp = rand.Next(RANGE);
                Console.WriteLine("{0}: {1}", Thread.CurrentThread.Name, temp);
            }
        }
    }
}
