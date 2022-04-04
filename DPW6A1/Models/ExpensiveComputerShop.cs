using DPW6A1.Models.Parts.Processor;

namespace DPW6A1.Models
{
    public class ExpensiveComputerShop : IComputerShop
    {
        public Computer AssembleComputer()
        {
            return new Computer(new ExpensiveProcessor(), new ExpensiveMonitor(), new ExpensiveHardDisk());
        }
    }
}