namespace _1.Vehicles
{
    public abstract class Vehicle
    {
        protected const double CarFuelIncreaseInSummer = 0.9;
        protected const double TruckFuelIncreaseInSummer = 1.6;

        private double fuelQuantity;
        private double litersPerKilometer;

        protected Vehicle(double fuelQuantity, double litersPerKilometer)
        {
            this.FuelQuantity = fuelQuantity;
            this.LitersPerKilometer = litersPerKilometer;
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }
            set { this.fuelQuantity = value; }
        }

        public double LitersPerKilometer
        {
            get { return this.litersPerKilometer; }
            set { this.litersPerKilometer = value; }
        }

        public abstract string TryTravel(double kilometers);
    }
}