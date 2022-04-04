using DPW6A1.Models;

namespace DPW6A2.Models
{
    public interface IComputerPartFactory
    {
        IMonitor CreateDisplay();
        IHardDisk CreateHardDisk();
        IProcessor CreateProcessor();
    }
}