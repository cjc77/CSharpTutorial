using System;
using System.Threading;

namespace Locks
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[10];
            Account account = new Account(1000);

            for(int i = 0; i < 10; i++)
            {
                // pass in delegate to ThreadStart()
                Thread t = new Thread(new ThreadStart(account.DoTransactions));
                threads[i] = t;
            }
            
            // start all threads
            foreach (var t in threads)
                t.Start();

            // block main thread until all others are completed
            foreach (var t in threads)
                t.Join();

            Console.WriteLine("Transactions Completed.");
            // hold the terminal so output remains visible
            Console.ReadLine();
        }
    }
}
