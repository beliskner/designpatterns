namespace DPW2A1
{
    class Program
    {
        static void Main(string[] args)
        {
            BatchProcessor processor = new BatchProcessor();
            processor.AddBatch(new CallDataLoader());
            processor.AddBatch(new TwitterDataLoader());
            processor.AddBatch(new SensorDataLoader());
            processor.ProcessBatches();
        }
    }
}
