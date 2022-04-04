using System;

namespace DPW6A1.Models
{
    public class ExpensiveMonitor : IMonitor
    {
        public void Display()
        {
            Console.WriteLine("displaying stuff very nice...");
        }
    }
}