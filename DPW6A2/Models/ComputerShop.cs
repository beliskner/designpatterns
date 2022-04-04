using DPW6A1.Models;
using DPW6A2.Models.Enum;

namespace DPW6A2.Models
{
    public class ComputerShop : IComputerShop
    {
        private IComputerPartFactory _factory;

        public ComputerShop(Quality quality)
        {
            _factory = quality == Quality.Poor ? new LowBudgetFactory() : new HighBudgetFactory();
        }
        
        public Computer AssembleComputer()
        {
            return new Computer(_factory.CreateProcessor(), _factory.CreateDisplay(), _factory.CreateHardDisk());
        }
    }
}