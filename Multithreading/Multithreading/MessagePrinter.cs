using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Multithreading
{
    class MessagePrinter
    {
        private int sleepTime;
        private static Random random = new Random();

        public MessagePrinter()
        {
            // pick random sleep time between 0 & 5 seconds
            sleepTime = random.Next(5001);
        }

        public void Print()
        {
            // get reference to currently executing thread
            Thread current = Thread.CurrentThread;

            // put thread to sleep for sleepTime milliseconds
            Console.WriteLine("{0} sleeping for {1} milliseconds", current.Name, sleepTime);
            Thread.Sleep(sleepTime);

            // print thread name
            Console.WriteLine("{0} done sleeping", current.Name);
        }
    }
}
