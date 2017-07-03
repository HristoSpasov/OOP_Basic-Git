namespace _12.Google
{
    internal class Car
    {
        private string model;
        private string speed;

        public Car()
        {
        }

        public Car(string model, string speed)
        {
            this.Model = model;
            this.Speed = speed;
        }

        public string Model
        {
            get { return this.model; }
            private set { this.model = value; }
        }

        public string Speed
        {
            get { return this.speed; }
            private set { this.speed = value; }
        }

        public override string ToString()
        {
            return !string.IsNullOrWhiteSpace(this.Model) ? $"{this.Model} {this.Speed}\n" : $"{string.Empty}";
        }
    }
}