using System;
using DPW6A1.Models;

namespace DPW6A1
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
            var expensiveShop = new ExpensiveComputerShop();
            var expensiveComputer = expensiveShop.AssembleComputer();
            expensiveComputer.Test();
            
            Console.WriteLine();
            
            // create a shop where they assemble cheap computers
            Console.WriteLine("[shop creating cheap computers]");
            var cheapShop = new CheapComputerShop();
            var cheapComputer = cheapShop.AssembleComputer();
            cheapComputer.Test();
        }
    }
}