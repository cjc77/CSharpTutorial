using System;
using System.Threading;

namespace UnsynchronizedBuffer
{
    class Program
    {
        static void Main(string[] args)
        {
            // create shared buffer
            UnsynchronizedIntBuffer shared = new UnsynchronizedIntBuffer();

            // initialize Random object for each thread
            Random random = new Random();

            // create producer/consumer threads & start them
            Producer producer = new Producer(shared, random);
            Consumer consumer = new Consumer(shared, random);
            Thread producerThread = new Thread(new ThreadStart(producer.Produce));
            Thread consumerThread = new Thread(new ThreadStart(consumer.Consume));
            producerThread.Name = "Producer";
            consumerThread.Name = "Consumer";
            producerThread.Start();
            consumerThread.Start();

            Console.ReadLine();
        }
    }
}
