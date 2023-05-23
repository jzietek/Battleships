namespace Domain;

public record Coordinate(int Row, int Column)
{
    public static Coordinate operator + (Coordinate a, Coordinate b) => new(a.Row + b.Row, a.Column + b.Column);
}