using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UnsynchronizedBuffer
{
    class Producer
    {
        private IIntBuffer sharedLocation;
        private Random randomSleepTime;

        public Producer(IIntBuffer shared, Random random)
        {
            sharedLocation = shared;
            randomSleepTime = random;
        }

        public void Produce()
        {
            // sleep for 0 to 3000 milliseconds then set sharedLocation's Buffer property
            for (int count = 1; count <= 10; count++)
            {
                Thread.Sleep(randomSleepTime.Next(1, 3001));
                sharedLocation.Buffer = count;
            }

            Console.WriteLine("{0} done producing.\nTerminating {0}.", Thread.CurrentThread.Name);
        }
    }
}
