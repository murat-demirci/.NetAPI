using StageDesignPattern.ETicaretSample.Stage;
using StageDesignPattern.ETicaretSample.StageContext;

namespace StageDesignPattern.ETicaretSample.ConcreteStage
{
    public class Suspended : OrderState
    {
        private readonly OrderMachine _context;

        public Suspended(OrderMachine context)
        {
            _context = context;
        }
        public override void CreateOrder() => Console.WriteLine("Siparis zaten olsuturuldu");

        public override void Payment(int totalPrice) => Console.WriteLine("Stok guncellenmeden önce ödeme yapilamaz");

        public override void StockReserve(int quantit)
        {
            if (quantit < _context.Stock)
            {
                _context.Stock -= quantit;
                Console.WriteLine("Stok bilgisi güncellendi");
                _context.SetStockReserved();
            }
            else
            {
                Console.WriteLine("Stok Sayisi Yetersiz");
                Console.WriteLine("Siparis iptal ediliyor");
                _context.SetOrderCanceled();
            }
        }
    }
}
