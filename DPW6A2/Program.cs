using System;
using DPW6A2.Models;
using DPW6A2.Models.Enum;

namespace DPW6A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }

        private static void Start()
        {
            // create a shop where they assemble expensive computers
            Console.WriteLine("[shop creating expensive computers]");
            var expensiveShop = new ComputerShop(Quality.Expensive);
            var expensiveComputer = expensiveShop.AssembleComputer();
            expensiveComputer.Test();
            
            Console.WriteLine();
            
            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            var cheapShop = new ComputerShop(Quality.Poor);
            var cheapComputer = cheapShop.AssembleComputer();
            cheapComputer.Test();
        }
    }
}