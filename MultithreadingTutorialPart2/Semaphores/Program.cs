using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Semaphores
{
    class Program
    {
        const int ONE_SECOND = 1000;
        // Only 3 threads can enter the semaphor at once
        static SemaphoreSlim _sem = new SemaphoreSlim(3);

        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                int id = i;
                new Thread(Enter).Start(id);
            }
        }

        static void Enter(object id)
        {
            Console.WriteLine(id + " waiting to enter...");
            _sem.Wait();
            Console.WriteLine(id + " has entered...");
            Thread.Sleep(ONE_SECOND * (int) id);
            Console.WriteLine(id + " is exiting...");
            _sem.Release();
        }
    }
}
