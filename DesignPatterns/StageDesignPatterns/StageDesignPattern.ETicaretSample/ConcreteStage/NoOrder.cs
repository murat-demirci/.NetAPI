using StageDesignPattern.ETicaretSample.Stage;
using StageDesignPattern.ETicaretSample.StageContext;

namespace StageDesignPattern.ETicaretSample.ConcreteStage
{
    public class NoOrder : OrderState
    {
        private readonly OrderMachine _context;

        public NoOrder(OrderMachine context)
        {
            _context = context;
        }
        public override void CreateOrder()
        {
            Console.WriteLine("Siparis Basariyla Olusturuldu");
            _context.SetSuspended();
        }

        public override void Payment(int totalPrice) => Console.WriteLine("Siparis olmadan ödeme yapilamaz");

        public override void StockReserve(int quantit) => Console.WriteLine("Siparis olmadan stok güncellenemez");
    }
}
