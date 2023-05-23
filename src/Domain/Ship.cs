namespace Domain;

public class Ship
{
    public string Name { get; init; }
    public IEnumerable<ShipSegment> Segments { get; init; } = new List<ShipSegment>();

    public override string ToString()
    {
        return $"{Name} ({Segments.Count()})";
    }
}
