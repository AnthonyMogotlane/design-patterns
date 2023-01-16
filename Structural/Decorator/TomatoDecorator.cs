class TomatoDecorator : BurgerDecorator
{
    public TomatoDecorator(IBurger bugger) : base(bugger) { }
    public override string GetBurgerType()
    {
        string burgerType = base.GetBurgerType();
        burgerType += "\n with Tomato";
        return burgerType;   
    }
}