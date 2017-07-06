using _2.Vehicles_Extension.Exceptions;

namespace _2.Vehicles_Extension
{
    public abstract class Vehicle
    {
        protected const double CarFuelIncreaseInSummer = 0.9;
        protected const double TruckFuelIncreaseInSummer = 1.6;
        protected const double BusFuelIncreaseIfLoaded = 1.4;

        private double fuelQuantity;
        private double litersPerKilometer;
        private double tankCapacity;
        private bool isLoaded;

        protected Vehicle(double fuelQuantity, double litersPerKilometer, double tankCapacity)
        {
            this.LitersPerKilometer = litersPerKilometer;
            this.TankCapacity = tankCapacity;
            this.FuelQuantity = fuelQuantity;
            this.IsLoaded = false;
        }

        protected double TankCapacity
        {
            get { return this.tankCapacity; }

            set { this.tankCapacity = value; }
        }

        protected double LitersPerKilometer
        {
            get { return this.litersPerKilometer; }
            private set { this.litersPerKilometer = value; }
        }

        public bool IsLoaded
        {
            get { return this.isLoaded; }
            set { this.isLoaded = value; }
        }

        public double FuelQuantity
        {
            get { return this.fuelQuantity; }

            protected set { this.fuelQuantity = value; }
        }

        public virtual void AddFuel(double fuelToAdd)
        {
            if (fuelToAdd <= 0)
            {
                throw new NegativeFuelException();
            }

            if (fuelToAdd + this.FuelQuantity > this.TankCapacity)
            {
                throw new TankOverflowException();
            }

            this.FuelQuantity = this.fuelQuantity + fuelToAdd;
        }

        public abstract string TryTravel(double kilometers);
    }
}