namespace _2.Vehicles_Extension
{
    internal class Car : Vehicle
    {
        public Car(double fuelQuantity, double litersPerKilometer, double tankCapacity) : base(fuelQuantity, litersPerKilometer, tankCapacity)
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