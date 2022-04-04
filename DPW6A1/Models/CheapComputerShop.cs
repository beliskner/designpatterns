namespace DPW6A1.Models
{
    public class CheapComputerShop : IComputerShop
    {
        public Computer AssembleComputer()
        {
            return new Computer(new CheapProcessor(), new CheapMonitor(), new CheapHardDisk());
        }
    }
}