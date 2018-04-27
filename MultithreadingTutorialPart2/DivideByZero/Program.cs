using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DivideByZero
{
    class Program
    {
        static int size = 20;
        static void Main(string[] args)
        {
            Thread[] threads = new Thread[size];
            for (int i = 0; i < size; i++)
            {
                int temp = i;
                threads[i] = new Thread(() => ThreadSafe.Go(temp));
                threads[i].Start();
            }

            for (int i = 0; i < size; i++)
            {
                int temp = i;
                threads[i] = new Thread(() => ThreadUnsafe.Go(temp));
                threads[i].Start();
            }
        }
    }
}
