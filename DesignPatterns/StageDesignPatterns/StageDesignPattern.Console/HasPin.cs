namespace StageDesignPattern
{
    public class HasPin : ATMState
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
            if (cashToWithdraw > context.CashInMachine)
            {
                Console.WriteLine("Isleminizi Suan Gerceklestiremiyoruz");
                Console.WriteLine("Kart Cikarilmistir");
                context.State = new NoCard();
            }
            else
            {
                context.CashInMachine -= cashToWithdraw;
                Console.WriteLine($"Hesabinizdan {cashToWithdraw} Tutarinda Para Cekilmistir");
                Console.WriteLine("Kartiniz Cikarilmistir");
                context.State = new NoCard();

                Console.WriteLine($"Kalan Tutar : {context.CashInMachine}");
                if (context.CashInMachine <= 0)
                    context.State = new NoCash();
            }
        }
    }
}
