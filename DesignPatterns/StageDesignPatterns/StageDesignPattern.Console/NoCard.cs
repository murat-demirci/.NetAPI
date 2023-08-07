namespace StageDesignPattern
{
    //Context State
    public class NoCard : ATMState
    {
        public override void EnterPin(int pin, ATMMachine context) => Console.WriteLine("Lütfen Önce Kartinizi Takiniz");

        public override void InsertCard(ATMMachine context)
        {
            Console.WriteLine("Lütfen Kart Sifrenizi Giriniz");
            context.State = new HasCard();
        }

        public override void RejectCard(ATMMachine context) => Console.WriteLine("Lütfen Önce Kartinizi Takiniz");

        public override void RequestCard(int cashToWithdraw, ATMMachine context) => Console.WriteLine("Lütfen Önce Kartinizi Takiniz");
    }
}
