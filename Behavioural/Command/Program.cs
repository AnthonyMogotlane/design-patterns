Chef chef = new Chef();

Order order = new Order(chef, "Pap");
Waiter waiter = new Waiter(order);
Console.WriteLine(waiter.Execute());

order = new Order(chef, "braaiMeat");
waiter = new Waiter(order);
Console.WriteLine(waiter.Execute());
