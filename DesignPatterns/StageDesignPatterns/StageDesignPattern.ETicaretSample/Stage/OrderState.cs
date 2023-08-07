namespace StageDesignPattern.ETicaretSample.Stage
{
    public abstract class OrderState
    {
        /// <summary>
        /// Siparis Olustur
        /// </summary>
        public abstract void CreateOrder();
        /// <summary>
        /// Stok Guncelle
        /// </summary>
        public abstract void StockReserve(int quantit);
        /// <summary>
        /// Ödeme yap
        /// </summary>
        public abstract void Payment(int totalPrice);
    }
}
