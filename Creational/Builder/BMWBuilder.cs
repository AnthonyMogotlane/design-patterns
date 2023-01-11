namespace BuilderPattern;
public class BMWBuilder : CarBuilder
{
    // Inveke base class constructor
    public BMWBuilder() : base ("BMW") {}
   
    public override void BuildEngine()
    {
        Car.AddParts("'A V8 engine'");
    }

    public override void BuildFrame()
    {
        Car.AddParts("'4 doors black'");
    }
}