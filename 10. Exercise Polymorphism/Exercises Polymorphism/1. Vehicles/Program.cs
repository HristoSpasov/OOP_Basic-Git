using System;

namespace _1.Vehicles
{
    public class Program
    {
        public static void Main()
        {
            string[] carTokens = Console.ReadLine().Split();
            string[] truckTokens = Console.ReadLine().Split();

            Vehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]));
            Vehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]));

            ReadCommands(ref car, ref truck);
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
        }

        private static void ReadCommands(ref Vehicle car, ref Vehicle truck)
        {
            int lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                string[] lineTokens = Console.ReadLine().Split();

                if (lineTokens[0] == "Drive")
                {
                    // Try drive one of the vehicles
                    if (lineTokens[1] == "Car")
                    {
                        Console.WriteLine(car.TryTravel(double.Parse(lineTokens[2])));
                    }
                    else
                    {
                        Console.WriteLine(truck.TryTravel(double.Parse(lineTokens[2])));
                    }
                }
                else
                {
                    // Vehicle is back at the fuel station
                    if (lineTokens[1] == "Car")
                    {
                        car.FuelQuantity += double.Parse(lineTokens[2]);
                    }
                    else
                    {
                        truck.FuelQuantity += double.Parse(lineTokens[2]) * 0.95;
                    }
                }
            }
        }
    }
}