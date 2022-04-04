using System;

namespace DPW5A2.States
{
    public class CorrectPinState : IAtmState
    {
        private AtmMachine machine;

        public CorrectPinState(AtmMachine atmMachine) => machine = atmMachine;
        
        public void InsertCard()
        {
            Console.WriteLine("Card has already been inserted");
        }

        public void RejectCard()
        {
            Console.WriteLine("Your card has been rejected");
            machine.SetMachineState(machine.GetNoCardState());
        }

        public void EnterPincode()
        {
            Console.WriteLine("You have already entered your pin");
        }

        public void WithdrawCash()
        {
            if(machine.AmountInMachine <= 0)
                machine.SetMachineState(machine.GetNoCashState());
            else
            {
                var amount = machine.AttemptToConvertNumber("Please enter amount of cash: ");
                if (amount > machine.AmountInMachine)
                {
                    Console.WriteLine("Not enough cash available in machine");
                    RejectCard();
                }
                else
                {
                    machine.SetAmountInMachine(machine.AmountInMachine - amount);
                    Console.WriteLine($"{amount} withdrawn from machine");
                    RejectCard();
                }
            }
        }
    }
}