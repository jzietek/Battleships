namespace Domain;

public class Fleet
{
    public string Owner { get; init; }

    public bool IsSunk { get; set; } = false;

    public IEnumerable<Ship> Ships { get; init; } = Enumerable.Empty<Ship>();

    public IList<Coordinate> ShotsMade { get; } = new List<Coordinate>();
}