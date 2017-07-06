using _2.Vehicles_Extension.Exceptions;

namespace _2.Vehicles_Extension
{
    public class Truck : Vehicle
    {
        public Truck(double fuelQuantity, double litersPerKilometer, double tankCapacity) : base(fuelQuantity, litersPerKilometer, tankCapacity)
        {
        }

        public override void AddFuel(double fuelToAdd)
        {
            if (fuelToAdd <= 0)
            {
                throw new NegativeFuelException();
            }

            base.FuelQuantity = base.FuelQuantity + fuelToAdd * 0.95;
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