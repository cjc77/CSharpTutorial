using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace UnsynchronizedBuffer
{
    public class UnsynchronizedIntBuffer : IIntBuffer
    {
        // buffer to be shared by producer & consumer threads
        private int buffer = -1;

        // Buffer property
        public int Buffer
        {
            get
            {
                Console.WriteLine("{0} reads {1}", Thread.CurrentThread.Name, buffer);
                return buffer;
            }
            set
            {
                Console.WriteLine("{0} writes {1}", Thread.CurrentThread.Name, value);
                buffer = value;
            }
        }
    }
}
