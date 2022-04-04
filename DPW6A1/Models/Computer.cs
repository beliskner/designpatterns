using System;

namespace DPW6A1.Models
{
    public class Computer
    {
        public IProcessor Processor { get; set; }
        public IMonitor Monitor { get; set; }
        public IHardDisk HardDisk { get; set; }

        public Computer(IProcessor processor, IMonitor monitor, IHardDisk hardDisk)
        {
            Processor = processor;
            Monitor = monitor;
            HardDisk = hardDisk;
        }

        public void Test()
        {
            Processor.PerformOperation();
            HardDisk.StoreData();
            Monitor.Display();
        }
    }
}