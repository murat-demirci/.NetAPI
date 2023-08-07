namespace StageDesignPattern
{
    public class HasCard : ATMState
    {
        public override void EnterPin(int pin, ATMMachine context)
        {
            if (pin == 123)
            {
                Console.WriteLine("Sifre Dogru");
                context.CorrectPinEntered = true;
                context.State = new HasPin();
            }
            else
            {
                Console.WriteLine("Sifre Yanlis");
                context.CorrectPinEntered = false;
                Console.WriteLine("Kartiniz Cikarilmistir");
                context.State = new NoCard();
            }
        }

        public override void InsertCard(ATMMachine context) => Console.WriteLine("Ayni Anda Birden Fazla Kart Takamazsinit");

        public override void RejectCard(ATMMachine context)
        {
            Console.WriteLine("Kartiniz Cikarilmistir");
            context.State = new NoCard();
        }

        public override void RequestCard(int cashToWithdraw, ATMMachine context) => Console.WriteLine("Lutfen Kart Sifrenizi Giriniz");
    }
}
