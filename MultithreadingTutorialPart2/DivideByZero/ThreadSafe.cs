using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DivideByZero
{
    class ThreadSafe
    {
        static readonly object _locker = new object();
        static int _val2;

        static public void Go(int val1)
        {
            lock (_locker)
            {
            Console.WriteLine("Before dividing, val1 = {0}", val1);
                if (_val2 != 0)
                {
                    try
                    {
                        Console.WriteLine("{0} / {1} = {2}", val1, _val2, val1 / _val2);
                        _val2 = 0;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Divide by zero exception.");
                    }
                }
                else
                {
                    _val2 = 1;
                }
            }
        }
    }
}
