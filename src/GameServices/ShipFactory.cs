using Domain;
using GameServices.Exceptions;

namespace GameServices;

public class ShipFactory : IShipFactory
{
    private readonly Coordinate _maxAreaSize;

    public ShipFactory() : this(new Coordinate(10,10))
    {   
    }
    
    public ShipFactory(Coordinate maxAreaSize)
    {
        _maxAreaSize = maxAreaSize;
    }
    
    public Ship Create(string name, Coordinate topLeft, Coordinate dimensions)
    {
        if (!IsInBoundary(topLeft,dimensions))
        {
            throw new ShipFactoryException("Ship does not fit in the battle boundaries.");
        }
        
        var segments = new List<ShipSegment>();
        segments.Add(new ShipSegment(new Coordinate(topLeft.Row, topLeft.Column)));
        
        for (int i = 1; i < dimensions.Column; i++)
        {
            segments.Add(new ShipSegment(new Coordinate(topLeft.Row, topLeft.Column + i)));
        }
        for (int i = 1; i < dimensions.Row; i++)
        {
            segments.Add(new ShipSegment(new Coordinate(topLeft.Row + i, topLeft.Column)));
        }
        
        return new Ship { Name = name, Segments = segments};
    }

    public bool IsInBoundary(Coordinate topLeft, Coordinate dimensions)
    {
        Coordinate added = topLeft + dimensions;
        if (added.Row < 0) return false;
        if (added.Row > _maxAreaSize.Row) return false;
        if (added.Column < 0) return false;
        if (added.Column > _maxAreaSize.Column) return false;
        
        return true;
    }
}