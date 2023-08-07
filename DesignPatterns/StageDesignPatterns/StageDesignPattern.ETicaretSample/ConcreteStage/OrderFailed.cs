using StageDesignPattern.ETicaretSample.Stage;
using StageDesignPattern.ETicaretSample.StageContext;

namespace StageDesignPattern.ETicaretSample.ConcreteStage
{
    public class OrderFailed : OrderState
    {
        private readonly OrderMachine _context;

        public OrderFailed(OrderMachine context)
        {
            _context = context;
        }
        public override void CreateOrder() => Console.WriteLine("Lütfen bakiyenizi kontrol edip tekrar deneyiniz");

        public override void Payment(int totalPrice)
        {
            if (totalPrice < 1000)
            {
                _context.SetOrderComleted();
                Console.WriteLine("Siparis tamamlandi");
            }
            else
            {
                _context.SetNoOrder();
                Console.WriteLine("Yetersiz Bakiye");
                Console.WriteLine("Siparis listeden kaldirildi");
            }
        }

        public override void StockReserve(int quantit) => Console.WriteLine("Stok bilgisi zaten güncel");
    }
}
