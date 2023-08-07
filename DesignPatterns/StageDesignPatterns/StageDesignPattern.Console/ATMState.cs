namespace StageDesignPattern
{
    //State
    public abstract class ATMState
    {
        public abstract void InsertCard(ATMMachine context);
        public abstract void RejectCard(ATMMachine context);
        public abstract void EnterPin(int pin, ATMMachine context);
        public abstract void RequestCard(int cashToWithdraw, ATMMachine context);
    }
}
