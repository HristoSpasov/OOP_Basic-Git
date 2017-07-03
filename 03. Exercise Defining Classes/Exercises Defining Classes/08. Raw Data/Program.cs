namespace _08.Raw_Data
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    internal class Program
    {
        private static List<Car> cars = new List<Car>();

        private static void Main()
        {
            ReadCars();

            SwitchComands();
        }

        private static void SwitchComands()
        {
            string command = Console.ReadLine();

            switch (command)
            {
                case "fragile":
                    cars.Where(c => c.Cargo.Type == "fragile" && (c.Tyres.Pressure1 < 1 || c.Tyres.Pressure2 < 1 || c.Tyres.Pressure3 < 1 || c.Tyres.Pressure4 < 1))
                        .ToList()
                        .ForEach(c => Console.WriteLine(c.Model));
                    break;

                case "flamable":
                    cars.Where(c => c.Cargo.Type == "flamable" && c.Engine.Power > 250)
                        .ToList()
                        .ForEach(c => Console.WriteLine(c.Model));
                    break;
            }
        }

        private static void ReadCars()
        {
            int carsCount = int.Parse(Console.ReadLine());

            for (int i = 0; i < carsCount; i++)
            {
                string[] car = Console.ReadLine().Split();

                string model = car[0];

                int engineSpeed = int.Parse(car[1]);
                int enginePower = int.Parse(car[2]);
                Engine carEngine = new Engine(engineSpeed, enginePower);

                int cargoWeigth = int.Parse(car[3]);
                string cargoType = car[4];
                Cargo carCargo = new Cargo(cargoWeigth, cargoType);

                double tp1 = double.Parse(car[5]);
                int ta1 = int.Parse(car[6]);
                double tp2 = double.Parse(car[7]);
                int ta2 = int.Parse(car[8]);
                double tp3 = double.Parse(car[9]);
                int ta3 = int.Parse(car[10]);
                double tp4 = double.Parse(car[11]);
                int ta4 = int.Parse(car[12]);
                Tyre carTyres = new Tyre(tp1, ta1, tp2, ta2, tp3, ta3, tp4, ta4);

                Car newCar = new Car(model, carEngine, carCargo, carTyres);

                cars.Add(newCar); // Add new car to list
            }
        }
    }
}