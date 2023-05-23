using Domain;

namespace GameServices;

public interface IFleetBuilder
{
    IFleetBuilder WithOwnerName(string fleetOwnerName);
    IFleetBuilder WithShip(Ship ship);
    Fleet Build();
}