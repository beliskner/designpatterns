using System;
using System.Collections.Generic;
using System.Text;

namespace DPW1A2
{
    public interface IPencil
    {
        bool CanWrite { get; }
        void Write(string message);
        void AfterSharpening();
    }
}
