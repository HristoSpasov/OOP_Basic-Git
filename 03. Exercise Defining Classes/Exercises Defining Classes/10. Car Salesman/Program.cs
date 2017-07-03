namespace _10.Car_Salesman
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class Program
    {
        private static readonly List<Engine> Engines;
        private static readonly List<Car> Cars;
        private static readonly StringBuilder CarReport;

        static Program()
        {
            Engines = new List<Engine>();
            Cars = new List<Car>();
            CarReport = new StringBuilder();
        }

        private static void Main()
        {
            ReadEngineData(); // Read engine data

            ReadCarData(); // Read car data

            GetCarReport(); // Get car report

            Console.WriteLine(CarReport.ToString().Trim()); // Print car data
        }

        private static void GetCarReport()
        {
            foreach (var car in Cars)
            {
                CarReport.AppendLine(car.ToString());
            }
        }

        private static void ReadCarData()
        {
            int totalCars = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalCars; i++)
            {
                string[] car = Console.ReadLine()
                    .Trim()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                // All parameters are present
                if (car.Length == 4)
                {
                    Cars.Add(new Car(car[0], Engines.Find(e => e.Model == car[1]), car[2], car[3]));
                }

                // Only required parameters
                if (car.Length == 2)
                {
                    Cars.Add(new Car(car[0], Engines.Find(e => e.Model == car[1])));
                }

                // One of the optional is present
                if (car.Length == 3)
                {
                    Cars.Add(int.TryParse(car.Last(), out int weight)
                        ? new Car(car[0], Engines.Find(e => e.Model == car[1]), car[2], "n/a")
                        : new Car(car[0], Engines.Find(e => e.Model == car[1]), "n/a", car[2]));
                }
            }
        }

        private static void ReadEngineData()
        {
            int totalEngines = int.Parse(Console.ReadLine());

            for (int i = 0; i < totalEngines; i++)
            {
                string[] engine = Console.ReadLine()
                    .Trim()
                    .Split(" ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

                // All parameters are present
                if (engine.Length == 4)
                {
                    Engines.Add(new Engine(engine[0], engine[1], engine[2], engine[3]));
                }

                // Only required parameters
                if (engine.Length == 2)
                {
                    Engines.Add(new Engine(engine[0], engine[1]));
                }

                // One of the optional is present
                if (engine.Length == 3)
                {
                    Engines.Add(int.TryParse(engine.Last(), out int displacement)
                        ? new Engine(engine[0], engine[1], engine[2], "n/a")
                        : new Engine(engine[0], engine[1], "n/a", engine[2]));
                }
            }
        }
    }
}