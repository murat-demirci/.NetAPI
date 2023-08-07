using StageDesignPattern.ETicaretSample.Stage;
using StageDesignPattern.ETicaretSample.StageContext;

namespace StageDesignPattern.ETicaretSample.ConcreteStage
{
    public class StockReserved : OrderState
    {
        private readonly OrderMachine _context;

        public StockReserved(OrderMachine context)
        {
            _context = context;
        }
        public override void CreateOrder() => Console.WriteLine("Siparis zaten olusturuldu...");

        public override void Payment(int totalPrice)
        {
            if (totalPrice < 1000)
            {
                _context.SetOrderComleted();
                Console.WriteLine("Ödeme bsariyla gerceklesti");
            }
            else
            {
                _context.SetOrderFailed();
                Console.WriteLine("Yetersiz Bakiye");
            }
        }

        public override void StockReserve(int quantit) => Console.WriteLine("Stok zaten güncellendi...");
    }
}
