static class MethodClass
{
    public static string AddDecorator(this BurgerDecorator burgerDecorator, params string [] args)
    {
        string type = burgerDecorator.GetBurgerType();

        foreach (var extra in args)
        {   
            type += "\n\tWith " + extra;
        }

        return type;
    }
}
