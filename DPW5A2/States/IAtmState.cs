namespace DPW5A2.States
{
    public interface IAtmState
    {
        void InsertCard();
        void RejectCard();
        void EnterPincode();
        void WithdrawCash();
    }
}