using System;

namespace DPW5A2.States
{
    public class NoCashState : IAtmState
    {
        private AtmMachine machine;

        public NoCashState(AtmMachine atmMachine) => machine = atmMachine;
        
        public void InsertCard()
        {
            NoCashFeedback();
        }

        public void RejectCard()
        {
            NoCashFeedback();
        }

        public void EnterPincode()
        {
            NoCashFeedback();
        }

        public void WithdrawCash()
        {
            NoCashFeedback();
        }

        private void NoCashFeedback()
        {
            Console.WriteLine("This machine is out of cash");
        }
    }
}