using System;

namespace _2.Vehicles_Extension
{
    public class Program
    {
        public static void Main()
        {
            string[] carTokens = Console.ReadLine().Split();
            string[] truckTokens = Console.ReadLine().Split();
            string[] busTokens = Console.ReadLine().Split();

            Vehicle car = new Car(double.Parse(carTokens[1]), double.Parse(carTokens[2]), double.Parse(carTokens[3]));
            Vehicle truck = new Truck(double.Parse(truckTokens[1]), double.Parse(truckTokens[2]), double.Parse(truckTokens[3]));
            Vehicle bus = new Bus(double.Parse(busTokens[1]), double.Parse(busTokens[2]), double.Parse(busTokens[3]));

            ReadCommands(ref car, ref truck, ref bus);
            Console.WriteLine($"Car: {car.FuelQuantity:F2}");
            Console.WriteLine($"Truck: {truck.FuelQuantity:F2}");
            Console.WriteLine($"Bus: {bus.FuelQuantity:F2}");
        }

        private static void ReadCommands(ref Vehicle car, ref Vehicle truck, ref Vehicle bus)
        {
            int lineCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < lineCount; i++)
            {
                try
                {
                    string[] lineTokens = Console.ReadLine().Split();

                    if (lineTokens[0] == "Drive")
                    {
                        // Try drive one of the vehicles
                        if (lineTokens[1] == "Car")
                        {
                            Console.WriteLine(car.TryTravel(double.Parse(lineTokens[2])));
                        }
                        else if (lineTokens[1] == "Truck")
                        {
                            Console.WriteLine(truck.TryTravel(double.Parse(lineTokens[2])));
                        }
                        else
                        {
                            // Bust travels loaded
                            bus.IsLoaded = true;
                            Console.WriteLine(bus.TryTravel(double.Parse(lineTokens[2])));
                        }
                    }
                    else if (lineTokens[0] == "DriveEmpty")
                    {
                        // Bus is empty
                        bus.IsLoaded = false;
                        Console.WriteLine(bus.TryTravel(double.Parse(lineTokens[2])));
                    }
                    else
                    {
                        // Vehicle is back at the fuel station
                        if (lineTokens[1] == "Car")
                        {
                            car.AddFuel(double.Parse(lineTokens[2]));
                        }
                        else if (lineTokens[1] == "Truck")
                        {
                            truck.AddFuel(double.Parse(lineTokens[2]));
                        }
                        else
                        {
                            bus.AddFuel(double.Parse(lineTokens[2]));
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}