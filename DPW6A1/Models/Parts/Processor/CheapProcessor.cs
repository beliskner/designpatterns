using System;

namespace DPW6A1.Models
{
    public class CheapProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("performing operation not so quickly...");
        }
    }
}