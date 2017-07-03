namespace _08.Raw_Data
{
    internal class Car
    {
        public Car(string model, Engine engine, Cargo cargo, Tyre tyres)
        {
            this.Model = model;
            this.Engine = engine;
            this.Cargo = cargo;
            this.Tyres = tyres;
        }

        public string Model { get; set; }

        public Engine Engine { get; set; }

        public Cargo Cargo { get; set; }

        public Tyre Tyres { get; set; }
    }
}