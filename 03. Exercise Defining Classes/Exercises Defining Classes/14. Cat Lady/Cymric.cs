namespace _14.Cat_Lady
{
    internal class Cymric : Cat
    {
        private double furLength;

        public Cymric(string name, string breed, double furLength) : base(name, breed)
        {
            this.FurLength = furLength;
        }

        public double FurLength
        {
            get { return this.furLength; }
            private set { this.furLength = value; }
        }

        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.FurLength:F2}";
        }
    }
}