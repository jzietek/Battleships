using System;
namespace Domain;

public class ShipSegment
{
    public ShipSegment(Coordinate coordinate)
    {
        Coordinate = coordinate;
        Status = ShipSegmentStatus.Normal;
    }

    public ShipSegmentStatus Status { get; set; }
    public Coordinate Coordinate { get; init; }
}