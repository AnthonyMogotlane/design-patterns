class Passenger
{
    public string? FirstName { get; set; }
    public ITransportation? Transportation { get; set; }

    public Passenger(string firstName)
    {
        FirstName = firstName;
    }
    public string Transport()
    {
        return Transportation!.Transport(this);
    }
}