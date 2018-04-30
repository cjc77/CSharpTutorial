using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace Incrementer
{
    class Program
    {
        public static readonly object _locker = new object();
        static int counter1 = 0;
        static int counter2 = 0;

        static void Main(string[] args)
        {
            int threads = 25;
            int loops = 1000000;
            Safe(threads, loops);
            Unsafe(threads, loops);
            Console.WriteLine("Safe: {0}\nUnsafe: {1}", counter1, counter2);
        }
        static void Safe(int threads, int loops)
        {
            for (int i = 0; i < threads; i++)
            {
                new Thread(() => Loop(loops, ref counter1)).Start();
            }
        }

        static void Unsafe(int threads, int loops)
        {
            for (int i = 0; i < threads; i++)
            {
                new Thread(() => Loop(loops, ref counter2, false)).Start();
            }
        }

        static void Loop(int loops, ref int counter, bool safe=true)
        {
            for (int i = 0; i < loops; i++)
            {
                if (safe)
                {
                    lock (_locker)
                    {
                        counter++;
                    }
                }
                else
                {
                    counter++;
                }
            }
        }
    }
}
