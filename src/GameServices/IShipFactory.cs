using Domain;

namespace GameServices;

public interface IShipFactory
{
    Ship Create(string name, Coordinate topLeft, Coordinate dimensions);

    bool IsInBoundary(Coordinate topLeft, Coordinate dimensions);
}