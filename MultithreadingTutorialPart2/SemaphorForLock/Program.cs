using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SemaphorForLock
{
    class Program
    {
        static readonly object _locker = new object();
        static SemaphoreSlim _sem = new SemaphoreSlim(3);
        static Random rand = new Random();
        static int counter;
        const int SLEEP = 1000;

        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                int id = i;
                Thread t = new Thread(() => SemaphoreEntry(id));
                t.Start();
                t.Join();
            }
            Console.WriteLine(counter);
        }

        static void SemaphoreEntry(int id)
        {
            //Console.WriteLine(id + " is waiting to enter semaphore...");
            _sem.Wait();
            int inc = rand.Next(1000);
            Console.WriteLine("Thread {0}: {1}", id, inc);
            //Console.WriteLine(id + " has entered semaphore...");
            //Thread.Sleep(SLEEP);
            LockEntry(id, inc);
            //Console.WriteLine(id + " is leaving the semaphore...");
            _sem.Release();
        }

        static void LockEntry(int id, int inc)
        {
            //Console.WriteLine(id + " is waiting for the locker...");
            lock (_locker)
            {
                //Console.WriteLine(id + " has entered the locker...");
                //Thread.Sleep(SLEEP);
                for (int i = 0; i < inc; i++)
                {
                    counter++;
                }
                //Console.WriteLine(id + " is leaving the locker...");
            }
        }
    }
}
