class Order : ICommand
{
    private Chef? _chef;
    private string? _food;

    public Order(Chef chef, string food)
    {
        _chef = chef;
        _food = food;
    }

    public string Execute()
    {
        if(_food!.Equals("Pap"))
        {
            return _chef!.CookPap();
        } 
        else 
        {
            return _chef!.BraaiMeat();
        }
    }
}