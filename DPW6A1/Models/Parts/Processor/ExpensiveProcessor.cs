using System;

namespace DPW6A1.Models.Parts.Processor
{
    public class ExpensiveProcessor : IProcessor
    {
        public void PerformOperation()
        {
            Console.WriteLine("performing operation very quickly...");
        }
    }
}