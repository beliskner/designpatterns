using System;
using System.Collections.Generic;
using System.Text;

namespace DPW1A2
{
    class Pencil : IPencil
    {
        private int maxToWrite;
        private int nrOfCharsWritten;
        public bool CanWrite {
            get
            {
                return nrOfCharsWritten < maxToWrite;
            }
        }

        public void AfterSharpening()
        {
            nrOfCharsWritten = 0;
        }

        public void Write(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            if (CanWrite)
            {
                int length = message.Length;
                if ((nrOfCharsWritten + length) < maxToWrite)
                {
                    Console.WriteLine($"{message}");
                    nrOfCharsWritten += length;
                } else
                {
                    int censor = (nrOfCharsWritten + length) - maxToWrite;
                    string subString = message.Substring(0, censor);
                    string censored = new string('#', length - censor);
                    Console.WriteLine($"{subString}{censored}");
                    nrOfCharsWritten += length;
                }
            } else
            {
                Console.WriteLine("pls sharpen your pencil");
            }
        }

        public Pencil(int maxToWrite)
        {
            this.maxToWrite = maxToWrite;
            this.nrOfCharsWritten = 0;
        }
    }
}
