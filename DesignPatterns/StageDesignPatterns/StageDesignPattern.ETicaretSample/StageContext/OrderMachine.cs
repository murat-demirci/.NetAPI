using StageDesignPattern.ETicaretSample.ConcreteStage;
using StageDesignPattern.ETicaretSample.Stage;

namespace StageDesignPattern.ETicaretSample.StageContext
{
    public class OrderMachine
    {
        OrderState noOrder;
        OrderState suspended;
        OrderState stockReserved;
        OrderState orderCompleted;
        OrderState orderFailed;
        OrderState orderCanceled;

        OrderState state;

        public OrderMachine()
        {
            noOrder = new NoOrder(this);
            suspended = new Suspended(this);
            stockReserved = new StockReserved(this);
            orderCompleted = new OrderCompleted(this);
            orderFailed = new OrderFailed(this);
            orderCanceled = new OrderCanceled(this);

            state = noOrder;
        }

        public int Stock { get; set; } = 500;
        /// <summary>
        /// Siparis yok
        /// </summary>
        public void SetNoOrder() => state = noOrder;
        /// <summary>
        /// Olusturulmus siparis durumu
        /// </summary>
        public void SetSuspended() => state = suspended;
        /// <summary>
        /// StoK durumu guncellendi
        /// </summary>
        public void SetStockReserved() => state = stockReserved;
        public void SetOrderComleted() => state = orderCompleted;
        public void SetOrderFailed() => state = orderFailed;
        public void SetOrderCanceled() => state = orderCanceled;

        public void OrderCreate() => state.CreateOrder();
        public void StockReserve(int quantit) => state.StockReserve(quantit);
        public void Payment(int totalPrice) => state.Payment(totalPrice);
    }
}
