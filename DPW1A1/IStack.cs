using System;
using System.Collections.Generic;
using System.Text;

namespace DPW1A1
{
    public interface IStack
    {
        void Push(int value);
        int Pop();
        bool Contains(int value);
        int Count { get; }
        bool IsEmpty { get; }
    }
}
