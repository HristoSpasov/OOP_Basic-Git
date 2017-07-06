namespace _1.Vehicles
{
    internal class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKilometer) : base(fuelQuantity, litersPerKilometer)
        {
        }

        public override string TryTravel(double kilometers)
        {
            double requiredFuel = kilometers * this.LitersPerKilometer + kilometers * CarFuelIncreaseInSummer;

            if (this.FuelQuantity - requiredFuel > 0)
            {
                // Car has enough fuel
                this.FuelQuantity -= requiredFuel; // Reduce car fuel
                return $"Car travelled {kilometers} km";
            }

            return $"Car needs refueling";
        }
    }
}