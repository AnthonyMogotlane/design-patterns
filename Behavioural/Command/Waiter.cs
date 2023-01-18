class Waiter 
{
    private Order? _order;

    public Waiter(Order order)
    {
        _order = order;
    }

    public string Execute()
    {
        return _order!.Execute();
    }

}