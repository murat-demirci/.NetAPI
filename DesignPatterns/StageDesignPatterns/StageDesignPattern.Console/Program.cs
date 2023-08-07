using StageDesignPattern;

ATMMachine atm = new();

atm.InsertCard();
atm.RejcetCard();

Console.WriteLine("--------------");

atm.InsertCard();
atm.EnterPin(123);
atm.InsertCard();
atm.RequestCard(100);

Console.WriteLine("--------------");

atm.EnterPin(245);
atm.RequestCard(200);
atm.RejcetCard();

Console.WriteLine("--------------");

atm.InsertCard();
atm.EnterPin(235);

Console.WriteLine("--------------");

atm.InsertCard();
atm.EnterPin(123);
atm.RequestCard(500);

Console.WriteLine("--------------");