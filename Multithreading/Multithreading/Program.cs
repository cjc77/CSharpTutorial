using System;
using System.Threading;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadTester tester = new ThreadTester();
            Console.WriteLine("Running Test");
            tester.Run();
            Console.ReadLine();
        }
    }
}
