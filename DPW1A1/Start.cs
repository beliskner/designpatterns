using System;
using System.Collections.Generic;
using System.Text;

namespace DPW1A1
{
    public static class Startup
    {
        public static void Start()
        {
            IStack myStack = new ArrayStack(50);
            AddValues(myStack);
            CheckValues(myStack);
            ProcessValues(myStack);
        }
        static void AddValues(IStack stack)
        {
            Random rnd = new Random();
            for (int i = 0; i < 5; i++)
            {
                int value = rnd.Next(1, 100);
                stack.Push(value);
                Console.WriteLine($"pushed {value,2}, new count: { stack.Count}");
            }
        }
        static void CheckValues(IStack stack)
        {
            int toCheck = 1;

            while (toCheck != 0)
            {
                Console.Write("doe nummer: ");
                toCheck = int.Parse(Console.ReadLine());
                if (stack.Contains(toCheck))
                {
                    Console.WriteLine($"stack contains value {toCheck}");
                }
                else
                {
                    Console.WriteLine("lol nice try");
                }
            }
        }
        static void ProcessValues(IStack stack)
        {
            while (!stack.IsEmpty)
            {
                int value = stack.Pop();
                Console.WriteLine($"popped {value}, new count: {stack.Count}");
            }
        }
    }
}
