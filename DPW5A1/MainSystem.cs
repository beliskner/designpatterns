using DPW5A1.Models;

namespace DPW5A1
{
    public class MainSystem
    {
        public MainSystem()
        {
            DoSomeMainWork();
            var subsytem = new SubSystem();
            var logger = Logger.GetInstance();
            logger.Log("main", "finishing");
        }

        public void DoSomeMainWork()
        {
            var logger = Logger.GetInstance();
            logger.Log("MainSystem", "doing some main work");
        }
    }
}