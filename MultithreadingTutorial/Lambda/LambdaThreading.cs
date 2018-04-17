using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Lambda
{
    class LambdaThreading
    {
        static void Main(string[] args)
        {
            int x = 10;
            Thread t = new Thread(() => Console.WriteLine(x * 10));
            t.Start();
        }
    }
}
