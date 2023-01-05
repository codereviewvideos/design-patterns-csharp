namespace DesignPatterns.Creational;

public enum VehicleType
{
    Car,
    Bike,
}

public interface IVehicle
{
    public string Move();
}

internal class Car : IVehicle
{
    public string Move()
    {
        return "Driving a car...";
    }
}

internal class Bike : IVehicle
{
    public string Move()
    {
        return "Riding a bike...";
    }
}

public static class SimpleFactory
{
    public static IVehicle CreateVehicle(VehicleType vehicleType)
    {
        return vehicleType switch
        {
            VehicleType.Car => new Car(),
            VehicleType.Bike => new Bike(),
            _ => throw new ArgumentException("Invalid vehicle type.")
        };
    }
}
