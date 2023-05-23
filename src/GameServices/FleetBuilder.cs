using Domain;

namespace GameServices;

public class FleetBuilder : IFleetBuilder
{
    private string _fleetOwnerName = "Admiral";
    private IList<Ship> _ships = new List<Ship>();

    public IFleetBuilder WithOwnerName(string fleetOwnerName)
    {
        _fleetOwnerName = fleetOwnerName;
        return this;
    }

    public IFleetBuilder WithShip(Ship ship)
    {
        _ships.Add(ship);
        return this;
    }

    public Fleet Build()
    {
        return new Fleet { Owner = _fleetOwnerName, Ships = _ships };
    }
}