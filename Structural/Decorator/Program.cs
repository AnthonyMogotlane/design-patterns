IBurger burger = new Burger();
TomatoDecorator burgerWithTomato = new TomatoDecorator(burger);
CheeseDecorator burgerWithCheese = new CheeseDecorator(burgerWithTomato);

Console.WriteLine(burgerWithCheese.GetBurgerType());
