using System;
using System.Collections.Generic;
using System.Text;

namespace DPW2A1
{
    public class SensorDataLoader : BigDataLoader
    {
        private string subject = "sensor";
        private string finalString = "data...";
        public override void ExtractData()
        {
            Console.WriteLine($"extracting {subject} {finalString}");
        }

        public override void LoadData()
        {
            Console.WriteLine($"transforming {subject} {finalString}");
        }

        public override void TransformData()
        {
            Console.WriteLine($"loading transformed {finalString}");
        }
    }
}
