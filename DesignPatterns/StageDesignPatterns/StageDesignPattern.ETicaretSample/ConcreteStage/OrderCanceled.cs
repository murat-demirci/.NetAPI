using StageDesignPattern.ETicaretSample.Stage;
using StageDesignPattern.ETicaretSample.StageContext;

namespace StageDesignPattern.ETicaretSample.ConcreteStage
{
    public class OrderCanceled : OrderState
    {
        private readonly OrderMachine _context;

        public OrderCanceled(OrderMachine context)
        {
            _context = context;
        }

        public override void CreateOrder() => Console.WriteLine("Lütfen gecerli bir stok miktari giriniz");

        public override void Payment(int totalPrice) => Console.WriteLine("Stok bilgisi güncellenmeden ödeme yapilamaz");

        public override void StockReserve(int quantit)
        {
            if (quantit < _context.Stock)
            {
                _context.Stock -= quantit;
                Console.WriteLine("Stok miktari güncellendi");
                _context.SetStockReserved();
            }
            else
            {
                _context.SetNoOrder();
                Console.WriteLine("Siparis listeden kaldirildi");
                Console.WriteLine("Lütfen daha sonra tekrar deneyiniz");
            }
        }
    }
}
