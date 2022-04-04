using System;

namespace DPW4A3.Models
{
    public class Robot
    {
        public string Person { get; set; }

        public void MoveByPerson(string personName)
        {
            Person = personName;
            Console.WriteLine($"Robot is moved by {Person}");
        }

        public static void BashWithHands()
        {
            Console.WriteLine("Robot causes damage with hands");
        }

        public static void WalkForward()
        {
            Console.WriteLine("Robot walks forward");
        }
    }
}