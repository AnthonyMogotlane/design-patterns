using System.Text;

namespace BuilderPattern;
// Product
public class Car
{
    private readonly List<string> _parts = new();
    private readonly string? _carType;

    public Car(string carType)
    {
        _carType = carType;
    }

    public void AddParts(string part)
    {
        _parts.Add(part);
    }

    // Making it easy to test - Convert string method
    public override string ToString()
    {
        var stringBuilder = new StringBuilder();
        foreach (var part in _parts)
        {
            stringBuilder.Append($"Car of type {_carType} has part {part}");
        }
        return stringBuilder.ToString();
    }
}