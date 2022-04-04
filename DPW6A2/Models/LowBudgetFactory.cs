using DPW6A1.Models;

namespace DPW6A2.Models
{
    public class LowBudgetFactory : IComputerPartFactory
    {
        public IMonitor CreateDisplay()
        {
            return new CheapMonitor();
        }

        public IHardDisk CreateHardDisk()
        {
            return new CheapHardDisk();
        }

        public IProcessor CreateProcessor()
        {
            return new CheapProcessor();
        }
    }
}