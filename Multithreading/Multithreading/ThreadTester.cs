using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Multithreading
{
    class ThreadTester
    {
        public void Run()
        {
            // create & name each thread
            // use Print() as ThreadStart delegate
            MessagePrinter printer1 = new MessagePrinter();
            Thread thread1 = new Thread(new ThreadStart(printer1.Print));
            thread1.Name = "Thread 1";

            MessagePrinter printer2 = new MessagePrinter();
            Thread thread2 = new Thread(new ThreadStart(printer2.Print));
            thread2.Name = "Thread 2";

            MessagePrinter printer3 = new MessagePrinter();
            Thread thread3 = new Thread(new ThreadStart(printer3.Print));
            thread3.Name = "Thread 3";

            Console.WriteLine("Starting Threads");

            // place each thread in running state
            thread1.Start();
            thread2.Start();
            thread3.Start();
        }
    }
}
