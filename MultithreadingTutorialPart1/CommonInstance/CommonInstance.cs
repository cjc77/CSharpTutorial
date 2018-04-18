using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Part3
{
    class CommonInstance
    {
        bool done;
        static void Main(string[] args)
        {
            // common instance
            CommonInstance p3 = new CommonInstance();
            new Thread(p3.Go).Start();
            p3.Go();
        }

        void Go()
        {
            if (!done)
            {
                done = true;
                Console.WriteLine("Done");
            }
        }
    }
}
