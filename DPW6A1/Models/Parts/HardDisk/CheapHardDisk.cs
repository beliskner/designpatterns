using System;

namespace DPW6A1.Models
{
    public class CheapHardDisk : IHardDisk
    {
        public void StoreData()
        {
            Console.WriteLine("storing data not so quickly...");
        }
    }
}