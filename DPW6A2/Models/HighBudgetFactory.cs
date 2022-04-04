using DPW6A1.Models;
using DPW6A1.Models.Parts.Processor;

namespace DPW6A2.Models
{
    public class HighBudgetFactory : IComputerPartFactory
    {
        public IMonitor CreateDisplay()
        {
            return new ExpensiveMonitor();
        }

        public IHardDisk CreateHardDisk()
        {
            return new ExpensiveHardDisk();
        }

        public IProcessor CreateProcessor()
        {
            return new ExpensiveProcessor();
        }
    }
}