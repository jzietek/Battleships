namespace Domain;

public record ShipSegment(Coordinate Coordinate)
{
    public ShipSegmentStatus Status { get; set; } = ShipSegmentStatus.Normal;
}