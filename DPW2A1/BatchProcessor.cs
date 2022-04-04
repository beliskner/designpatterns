using System;
using System.Collections.Generic;
using System.Text;

namespace DPW2A1
{
    public class BatchProcessor
    {
        private List<BigDataLoader> loaders = new List<BigDataLoader>();

        public void AddBatch(BigDataLoader batch)
        {
            loaders.Add(batch);
        }

        public void ProcessBatches()
        {
            foreach (BigDataLoader loader in loaders)
            {
                ShowStep("started");
                loader.ExtractData();
                loader.TransformData();
                loader.LoadData();
                ShowStep("finished");
            }
        }

        private void ShowStep(string step)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine($"[ETL-process {step}]");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
