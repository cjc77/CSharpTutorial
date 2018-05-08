using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadSafeListManipulation
{
    class Program
    {
        static List<int> list = new List<int>();
        static readonly object _listLocker = new object();
        static Random rand = new Random();
        static Thread[] threads = new Thread[10];

        static void Main(string[] args)
        {
            for(int i = 0; i < 10; i++)
            {
                int idx = i;
                threads[i] = new Thread(() => AddItems(idx));
                threads[i].Name = "Thread " + i;
                threads[i].Start();
            }
        }

        static void AddItems(int thread_id)
        {
            int loops = rand.Next(10);
            for (int i = 0; i < loops; i++)
            {
                int arg = rand.Next(10);
                Insert(thread_id, arg);
                Thread.Sleep(arg * 100);
            }
        }

        static void Insert(int thread_id, int toAdd)
        {
            int[] items;
            lock (_listLocker)
            {
                Console.WriteLine("{0} inserting {1}", threads[thread_id].Name, toAdd);
                list.Add(toAdd);
                // copy items so can release the lock
                items = list.ToArray();
            }
            foreach (int item in items)
            {
                Console.Write("{0} ", item);
            }
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}
