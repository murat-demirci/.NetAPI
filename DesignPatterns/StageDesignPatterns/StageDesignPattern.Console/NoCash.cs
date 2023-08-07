namespace StageDesignPattern
{
    public class NoCash : ATMState
    {
        public override void EnterPin(int pin, ATMMachine context) => Console.WriteLine("Giris Zaten Yapildi");

        public override void InsertCard(ATMMachine context) => Console.WriteLine("Ayni Anda Birden Fazla Kart Takilamaz");

        public override void RejectCard(ATMMachine context)
        {
            Console.WriteLine("Kartiniz Cikarilmistir");
            context.State = new NoCard();
        }

        public override void RequestCard(int cashToWithdraw, ATMMachine context)
        {
            Console.WriteLine("Isleminizi Suan Gerceklestiremiyorur");
            Console.WriteLine("Kartiniz Cikarilmistir");
            context.State = new NoCard();
        }
    }
}
