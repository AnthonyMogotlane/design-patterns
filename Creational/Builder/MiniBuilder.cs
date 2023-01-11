namespace BuilderPattern;
public class MiniBuilder : CarBuilder
{
    // Inveke base class constructor
    public MiniBuilder() : base ("Mini") {}
   
    public override void BuildEngine()
    {
        Car.AddParts("'Not a V'");
    }

    public override void BuildFrame()
    {
        Car.AddParts("'2 door with stripes'");
    }
}