using System;

namespace DPW5A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();
        }
        private static void Start()
        {
            var currCommand = string.Empty;
            var atmMachine = new AtmMachine(2000);
            while (currCommand != "stop")
            {
                Console.Write("Please enter your command: ");
                currCommand = Console.ReadLine();
                switch (currCommand)
                {
                    case "insert card":
                        atmMachine.InsertCard();
                        break;
                    case "reject card":
                        atmMachine.RejectCard();
                        break;
                    case "enter pincode":
                        atmMachine.EnterPincode();
                        break;
                    case "withdraw cash":
                        atmMachine.WithdrawCash();
                        break;
                }
            }
        }
    }
}