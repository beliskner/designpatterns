using System;

namespace DPW5A2.States
{
    public class CardPresentState : IAtmState
    {
        private AtmMachine machine;

        public CardPresentState(AtmMachine atmMachine) => machine = atmMachine;

        public void InsertCard()
        {
            Console.WriteLine("Card already inserted");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void EnterPincode()
        {
            var code = machine.AttemptToConvertNumber("Please enter your pincode: ");
            if (code == 1234)
            {
                Console.WriteLine("You have entered the correct pincode");
                machine.SetMachineState(machine.GetCorrectPinState());
            }
            else
                Console.WriteLine("Pin code incorrect");
        }

        public void WithdrawCash()
        {
            Console.WriteLine("You must first enter a pin code before you can withdraw cash");
        }
    }
}