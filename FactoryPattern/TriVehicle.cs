namespace FactoryPattern;

public class TriVehicle : IVehicle
{
    public void Drive()
    {
        Console.WriteLine("Interesting, building a three wheel vehicle!");
    }
}