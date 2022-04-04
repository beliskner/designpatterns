using System;
using System.Collections.Generic;
using System.Text;

namespace DPW1A2
{
    class PencilSharpener : IPencilSharpener
    {
        public void Sharpen(IPencil pencil)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("sharpening the pencil...");
            pencil.AfterSharpening();
        }
    }
}
