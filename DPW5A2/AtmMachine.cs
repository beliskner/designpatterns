using System;
using DPW5A2.States;

namespace DPW5A2
{
    public class AtmMachine
    {
        private int amountInMachine;
        private IAtmState cardPresent;
        private IAtmState correctPinCode;
        private IAtmState noCard;
        private IAtmState noCash;
        
        public int AmountInMachine { get; set; }

        private IAtmState machineState;

        public AtmMachine(int machineAmount)
        {
            SetAmountInMachine(machineAmount);
            
            cardPresent = new CardPresentState(this);
            correctPinCode = new CorrectPinState(this);
            noCard = new NoCardState(this);
            noCash = new NoCashState(this);

            machineState = machineAmount > 0 ? GetNoCardState() : GetNoCashState();
        }

        public void InsertCard()
        {
            machineState.InsertCard();
        }

        public void SetAmountInMachine(int machineAmount)
        {
            amountInMachine = machineAmount;
            AmountInMachine = amountInMachine;
            if (amountInMachine <= 0)
                SetMachineState(GetNoCashState());
        }

        public void RejectCard()
        {
            machineState.RejectCard();
        }

        public void EnterPincode()
        {
            machineState.EnterPincode();
        }

        public void WithdrawCash()
        {
            machineState.WithdrawCash();
        }

        public void SetMachineState(IAtmState newState)
        {
            machineState = newState;
        }

        public IAtmState GetCardPresentState()
        {
            return cardPresent;
        }

        public IAtmState GetNoCardState()
        {
            return noCard;
        }

        public IAtmState GetNoCashState()
        {
            return noCash;
        }

        public IAtmState GetCorrectPinState()
        {
            return correctPinCode;
        }
        
        public int AttemptToConvertNumber(string message)
        {
            Console.Write(message);
            var code = Console.ReadLine();
            var success = int.TryParse(code, out var number);
            if (!success)
                AttemptToConvertNumber(message);
            return number;
        }
    }
}