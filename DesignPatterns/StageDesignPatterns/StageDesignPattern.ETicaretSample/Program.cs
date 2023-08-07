using StageDesignPattern.ETicaretSample.StageContext;

OrderMachine order = new();

order.OrderCreate();
order.Payment(200);
order.Payment(200);

Console.WriteLine("--------------------");

order.StockReserve(1000);
order.StockReserve(1000);
order.OrderCreate();


Console.WriteLine("--------------------");

order.Payment(500);