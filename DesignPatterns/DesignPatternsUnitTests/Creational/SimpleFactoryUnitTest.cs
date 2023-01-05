using System;
using DesignPatterns.Creational;
using NUnit.Framework;

namespace DesignPatternsUnitTests.Creational;

public class Tests
{
    [Test]
    public void ShouldCreateACar()
    {
        var vehicle = SimpleFactory.CreateVehicle(VehicleType.Car);

        Assert.AreEqual(vehicle.Move(), "Driving a car...");
    }

    [Test]
    public void ShouldCreateABike()
    {
        var vehicle = SimpleFactory.CreateVehicle(VehicleType.Bike);

        Assert.AreEqual(vehicle.Move(), "Riding a bike...");
    }

    [Test]
    public void ShouldThrowForAnInvalidVehicleType()
    {
        Assert.Throws<ArgumentException>(() =>
            SimpleFactory.CreateVehicle((VehicleType) 999), "Invalid vehicle type");
    }
}
