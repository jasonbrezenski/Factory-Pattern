namespace FactoryPattern;

public class CarTruckSuv : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Building a new car, truck or SUV!");
    }
}