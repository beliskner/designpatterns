using System;

namespace DPW6A1.Models
{
    public class ExpensiveHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("storing data very quickly...");
        }
    }
}