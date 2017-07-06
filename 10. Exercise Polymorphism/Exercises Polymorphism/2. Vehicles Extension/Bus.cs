namespace _2.Vehicles_Extension
{
    internal class Bus : Vehicle
    {
        public Bus(double fuelQuantity, double litersPerKilometer, double tankCapacity) : base(fuelQuantity,
            litersPerKilometer, tankCapacity)
        {
        }

        public override string TryTravel(double kilometers)
        {
            double requiredFuel = 0.0;

            if (base.IsLoaded)
            {
                requiredFuel = kilometers * this.LitersPerKilometer + kilometers * BusFuelIncreaseIfLoaded;
            }
            else
            {
                requiredFuel = kilometers * this.LitersPerKilometer;
            }

            if (this.FuelQuantity - requiredFuel > 0)
            {
                // Bus has enough fuel
                this.FuelQuantity -= requiredFuel; // Reduce bus fuel
                return $"Bus travelled {kilometers} km";
            }

            return $"Bus needs refueling";
        }
    }
}