using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultithreadingTutorial
{
    class Part1
    {
        static int loops = 1000;
        static void Main(string[] args)
        {
            Thread t = new Thread(WriteY);
            t.Name = "T Prime";
            Console.WriteLine("{0}{1}", '\n', t.IsAlive);
            t.Start();
            Console.WriteLine("{0}{1}", '\n', t.IsAlive);
            WriteX();
            t.Join();
            Console.WriteLine("{0}{1}", '\n', t.IsAlive);
        }

        static void WriteX()
        {
            for (int i = 0; i < loops; i++)
                Console.Write("X");
        }

        static void WriteY()
        {
            Thread tPrime = Thread.CurrentThread;
            Console.WriteLine("{0}{1}", '\n', tPrime.Name);
            for (int i = 0; i < loops; i++)
                Console.Write("Y");
        }
    }
}
