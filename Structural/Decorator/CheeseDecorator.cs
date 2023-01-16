class CheeseDecorator : BurgerDecorator
{
    public CheeseDecorator(IBurger bugger) : base(bugger) { }
    public override string GetBurgerType()
    {
        string burgerType = base.GetBurgerType();
        burgerType += "\n with Cheese";
        return burgerType;   
    }
}