using DPW5A1.Models;

namespace DPW5A1
{
    public class SubSystem
    {
        public SubSystem()
        {
            DoSomeWork();
            DoSomeMoreWork();
        }

        public void DoSomeWork()
        {
            var logger = Logger.GetInstance();
            logger.Log("SubSystem", "doing some work");
        }

        public void DoSomeMoreWork()
        {
            var logger = Logger.GetInstance();
            logger.Log("SubSystem", "doing some more work");
        }
    }
}