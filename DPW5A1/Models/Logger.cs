using System;

namespace DPW5A1.Models
{
    public class Logger
    {
        private static Logger uniqueInstance;
        private static int numberOfLines;

        private Logger()
        {
            numberOfLines = 0;
        }

        public static Logger GetInstance()
        {
            return uniqueInstance ??= new Logger();
        }

        public void Log(string system, string logMessage)
        {
            numberOfLines++;
            Console.WriteLine($"{numberOfLines} - [{system}] {logMessage}");
        }
    }
}