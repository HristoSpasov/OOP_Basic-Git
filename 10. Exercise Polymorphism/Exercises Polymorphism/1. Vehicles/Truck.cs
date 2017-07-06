namespace _1.Vehicles
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKilometer) : base(fuelQuantity, litersPerKilometer)
        {
        }

        public override string TryTravel(double kilometers)
        {
            double requiredFuel = kilometers * this.LitersPerKilometer + kilometers * TruckFuelIncreaseInSummer;

            if (this.FuelQuantity - requiredFuel > 0)
            {
                // Truck has enough fuel
                this.FuelQuantity -= requiredFuel; // Reduce car fuel
                return $"Truck travelled {kilometers} km";
            }

            return $"Truck needs refueling";
        }
    }
}