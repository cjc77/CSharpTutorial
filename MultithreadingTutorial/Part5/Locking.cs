using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Part5
{
    class Locking
    {
        static int count1;
        static int count2;
        static readonly object locker = new object();
        const int LOOPS = 10000000;

        static void Main(string[] args)
        {
            Thread t = new Thread(Go);
            t.Start();
            Go();
            t.Join();
            Console.WriteLine("Safe: {0}\r\nUnsafe: {1}", count1, count2);
        }

        static void Go()
        {
            for (int i = 0; i < LOOPS; i++) { SafeIncrement(); }
            for (int i = 0; i < LOOPS; i++) { UnsafeIncrement(); }
        }

        static void SafeIncrement()
        {
            // lock to prevent a race condition
            lock (locker)
            {
                count1++;
            }
        }

        static void UnsafeIncrement()
        {
            count2++;
        }

    }
}
