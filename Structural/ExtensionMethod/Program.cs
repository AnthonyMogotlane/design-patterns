IBurger burger = new Burger();
BurgerDecorator burgerDecorator = new BurgerDecorator(burger);
Console.WriteLine(burgerDecorator.AddDecorator("Cheese", "Onion", "Tomato"));
