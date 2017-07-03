namespace _10.Car_Salesman
{
    internal class Car
    {
        public Car(string model, Engine engine)
        {
            this.Model = model;
            this.Engine = engine;
            this.Color = "n/a";
            this.Weight = "n/a";
        }

        public Car(string model, Engine engine, string weight, string color)
            : this(model, engine)
        {
            this.Color = color;
            this.Weight = weight;
        }

        public string Model { get; }

        public Engine Engine { get; }

        public string Color { get; }

        public string Weight { get; }

        public override string ToString()
        {
            return $"{this.Model}:\n  {this.Engine.Model}:\n    Power: {this.Engine.Power}\n" +
                   $"    Displacement: {this.Engine.Displacement}\n    Efficiency: {this.Engine.Efficiency}\n" +
                   $"  Weight: {this.Weight}\n  Color: {this.Color}";
        }
    }
}