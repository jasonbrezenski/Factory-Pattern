namespace FactoryPattern;

public static class VehicleFactory
{
    public static IVehicle GetVehicle(int tiresNumber)
    {
        switch (tiresNumber)
        {
            case 2:
                return new Motorcycle();
            case 3:
                return new TriVehicle();
            case 4:
                return new CarTruckSuv();
            case 5: ;
                return new Xl();
            default:
                return new Xl();
        }
    }
}