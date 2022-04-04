using System;

namespace DPW5A2.States
{
    public class NoCardState : IAtmState
    {
        private AtmMachine machine;

        public NoCardState(AtmMachine atmMachine) => machine = atmMachine;
        
        public void InsertCard()
        {
            Console.WriteLine("Card has been inserted");
            machine.SetMachineState(machine.GetCardPresentState());
        }

        public void RejectCard()
        {
            Console.WriteLine("No card present");
        }

        public void EnterPincode()
        {
            Console.WriteLine("No card present");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("No card present");
        }
    }
}