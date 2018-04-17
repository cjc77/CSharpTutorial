using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ThreadFactorial
{
    class ThreadFactorial
    {
        static int number, result, acc;
        static Object locker = new Object();
        static void Main(string[] args)
        {
            number = result = acc = 10;
            Thread[] threads = new Thread[number];
            for (int i = 0; i < number; i++)
            {
                threads[i] = new Thread(() => Multiply(ref result, ref acc));
                threads[i].Name = i.ToString();
                threads[i].Start();
            }

            foreach (Thread t in threads)
            {
                t.Join();
            }
            Console.WriteLine(acc);
        }


        static void Multiply(ref int result, ref int acc)
        {
            lock (locker)
            {
                result -= 1;
                if (result == 0)
                    acc *= 1;
                else
                    acc *= result;
                Console.WriteLine("Thread {0}: {1}", Thread.CurrentThread.Name, acc);
            }
        }
    }
}
