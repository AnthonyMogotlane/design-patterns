// Base decorator
class BurgerDecorator : IBurger
{
    private IBurger _bugger;

    public BurgerDecorator(IBurger bugger)
    {
        _bugger = bugger;
    }
    public virtual string GetBurgerType()
    {
        return _bugger.GetBurgerType();
    }
}

