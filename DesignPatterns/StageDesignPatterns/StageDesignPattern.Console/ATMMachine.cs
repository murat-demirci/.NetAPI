namespace StageDesignPattern
{
    //Context Sinifi 
    public class ATMMachine
    {
        ATMState state = new NoCard();
        public ATMState State { set => state = value; }
        public int CashInMachine { get; set; } = 5000;
        public bool CorrectPinEntered { get; set; } = false;
        public void InsertCard() => state.InsertCard(this);
        public void RejcetCard() => state.RejectCard(this);
        public void EnterPin(int pin) => state.EnterPin(pin, this);
        public void RequestCard(int cashToWithdraw) => state.RequestCard(cashToWithdraw, this);
    }
}
