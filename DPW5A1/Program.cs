using DPW5A1.Models;

namespace DPW5A1
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        private static void Start()
        {
            var logger = Logger.GetInstance();
            logger.Log("main", "starting");
            var mainSystem = new MainSystem();
        }
    }
}