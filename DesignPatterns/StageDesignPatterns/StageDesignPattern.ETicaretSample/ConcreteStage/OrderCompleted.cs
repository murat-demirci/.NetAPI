using StageDesignPattern.ETicaretSample.Stage;
using StageDesignPattern.ETicaretSample.StageContext;

namespace StageDesignPattern.ETicaretSample.ConcreteStage
{
    public class OrderCompleted : OrderState
    {
        private readonly OrderMachine _context;

        public OrderCompleted(OrderMachine context)
        {
            _context = context;
        }
        public override void CreateOrder()
        {
            _context.SetNoOrder();
            Console.WriteLine("Siparis Basariyla Tamamlandi");
        }

        public override void Payment(int totalPrice) => Console.WriteLine("Lütfen siparis olusturun");

        public override void StockReserve(int quantit) => Console.WriteLine("Lütfen siparis olusturun");
    }
}
