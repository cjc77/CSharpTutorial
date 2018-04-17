using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace CapturedVariables
{
    class CapturedVariables
    {
        static int loops = 10;
        static int sleepTime = 2000;
        static void Main(string[] args)
        {
            Mistake();
            Thread.Sleep(sleepTime);
            Console.WriteLine("\n********");
            Fixed();
            Thread.Sleep(sleepTime);
            Console.WriteLine("\n********");
        }

        static void Mistake()
        {
            for (int i = 0; i < loops; i++)
                new Thread(() => Console.Write(i)).Start();
        }

        static void Fixed()
        {
            int temp;
            for (int i = 0; i < loops; i++)
            {
                temp = i;
                new Thread(() => Console.Write(temp)).Start();
            }
        }
    }
}
