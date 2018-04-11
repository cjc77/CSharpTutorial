using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UnsynchronizedBuffer
{
    class Consumer
    {
        private IIntBuffer sharedLocation;
        private Random randomSleepTime;

        public Consumer(IIntBuffer shared, Random random)
        {
            sharedLocation = shared;
            randomSleepTime = random;
        }

        public void Consume()
        {
            int sum = 0;
            // sleep for 0 to 3000 milliseconds then add sharedLocation's Buffer property
            // value to sum
            for(int i = 0; i < 10; i++)
            {
                Thread.Sleep(randomSleepTime.Next(1, 3001));
                sum += sharedLocation.Buffer;
            }

            Console.WriteLine(
                "{0} read values totaling : {1}.\nTermenating", Thread.CurrentThread.Name, sum);
        }
    }
}
