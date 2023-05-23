using Domain;
using FluentAssertions;
using GameServices;
using GameServices.Exceptions;

namespace GameServicesTests;

public class ShipFactoryTests
{
    [Test]
    public void IsInBoundary_ThrowsExceptionWhenCoordinatesOutOfRange()
    {
        //Arrange
        var sut = new ShipFactory(new Coordinate(10, 10));

        //Act and assert
        var action = () => sut.Create("N/A", new Coordinate(10, 10), new Coordinate(100, 100));
        action.Should().Throw<ShipFactoryException>();
    }
    
    [Test]
    public void Create_ThrowsExceptionWhenCoordinatesOutOfRange()
    {
        //Arrange
        var sut = new ShipFactory(new Coordinate(10, 10));

        //Act and assert
        var action = () => sut.Create("N/A", new Coordinate(10, 10), new Coordinate(100, 100));
        action.Should().Throw<ShipFactoryException>();
    }

    [TestCase(0,5)]
    [TestCase(4,0)]
    public void Create_BuildsExpectedShip(int shipWidth, int shipHeight)
    {
        //Arrange
        string shipName = "Queen Marry";
        Coordinate topLeft = new Coordinate(1, 3);
        Coordinate dimensions = new Coordinate(shipHeight, shipWidth);
        var shipFactory = new ShipFactory(new Coordinate(10,10));
        
        //Act
        var ship = shipFactory.Create(shipName, topLeft, dimensions);
        
        //Assert
        ship.Should().NotBeNull();
        ship.Name.Should().Be(shipName);
        ship.Segments.Count().Should().Be(Math.Max(dimensions.Column, dimensions.Row));
        ship.Segments.All(segment => segment.Coordinate.Row >= topLeft.Row).Should().BeTrue();
        ship.Segments.All(segment => segment.Coordinate.Row <= topLeft.Row + dimensions.Row).Should().BeTrue();
        ship.Segments.All(segment => segment.Coordinate.Column >= topLeft.Column).Should().BeTrue();
        ship.Segments.All(segment => segment.Coordinate.Column <= topLeft.Column + dimensions.Column).Should().BeTrue();
    }
}