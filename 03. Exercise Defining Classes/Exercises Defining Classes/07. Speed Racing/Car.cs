namespace _07.Speed_Racing
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class Car
    {
        private static List<Car> cars = new List<Car>();

        public Car(string model, double fuel, double consumptionPerKm)
        {
            this.Model = model;
            this.Fuel = fuel;
            this.ConsumptionPerKm = consumptionPerKm;
            this.DistanceTravelled = 0;
        }

        public string Model { get; set; }

        public double Fuel { get; set; }

        public double ConsumptionPerKm { get; set; }

        public double DistanceTravelled { get; set; }

        public static void TryDrive(string model, double kilometersToDrive)
        {
            Car carToDrive = GetCar(model);

            if (kilometersToDrive * carToDrive.ConsumptionPerKm <= carToDrive.Fuel)
            {
                carToDrive.DistanceTravelled += kilometersToDrive;
                carToDrive.Fuel -= kilometersToDrive * carToDrive.ConsumptionPerKm;
            }
            else
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }

            int carIndex = cars.FindIndex(n => n.Model == model); // Get car index

            cars.RemoveAll(n => n.Model == carToDrive.Model); // Remove old car

            cars.Insert(carIndex, carToDrive); // Add update
        }

        public static Car GetCar(string model)
        {
            return cars.Where(m => m.Model == model).First();
        }

        public static string GetCarsReport()
        {
            StringBuilder report = new StringBuilder();

            foreach (var car in cars)
            {
                report.AppendLine(car.ToString());
            }

            return report.ToString().Trim();
        }

        public void Add()
        {
            cars.Add(this);
        }

        public override string ToString()
        {
            return $"{this.Model} {this.Fuel:F2} {this.DistanceTravelled}";
        }
    }
}