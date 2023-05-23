using Domain;
using FluentAssertions;
using GameServices;

namespace GameServicesTests;

public class FleetBuilderTests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {
        //Arrange
        string admiral = "Lord Nelson";
        string shipName = "Carrier";
        var sut = new FleetBuilder()
            .WithOwnerName(admiral)
            .WithShip(new Ship
            {
                Name = "Carrier", Segments = new[]
                {
                    new ShipSegment(new Coordinate(0, 0)),
                    new ShipSegment(new Coordinate(1, 0)),
                    new ShipSegment(new Coordinate(2, 0)),
                    new ShipSegment(new Coordinate(3, 0)),
                    new ShipSegment(new Coordinate(4, 0))
                }
            });
        
        //Act
        var fleet = sut.Build();

        //Assert
        fleet.Should().NotBeNull();
        fleet.Owner.Should().Be(admiral);
        fleet.Ships.Count().Should().Be(1);
        fleet.Ships.First().Name.Should().Be(shipName);
    }
}