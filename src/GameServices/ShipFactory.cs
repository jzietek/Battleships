using Domain;

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
        throw new NotImplementedException();
    }
}