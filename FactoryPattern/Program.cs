namespace FactoryPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many tires are on your vehicle - 2, 3, 4, 5+?");
            var userInput = int.Parse(Console.ReadLine());

            var ride = VehicleFactory.GetVehicle(userInput);
            
            ride.Drive();
        }
    }
}
