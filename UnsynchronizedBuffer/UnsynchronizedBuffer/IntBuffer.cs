using System;
using System.Collections.Generic;
using System.Text;

namespace UnsynchronizedBuffer
{
    public interface IIntBuffer
    {
        int Buffer
        {
            get;
            set;
        }
    }
}
