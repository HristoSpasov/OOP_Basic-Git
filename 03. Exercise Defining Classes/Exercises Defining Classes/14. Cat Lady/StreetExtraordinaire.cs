namespace _14.Cat_Lady
{
    internal class StreetExtraordinaire : Cat
    {
        private int meowDecibels;

        public StreetExtraordinaire(string name, string breed, int meowDecibels) : base(name, breed)
        {
            this.MeowDecibels = meowDecibels;
        }

        public int MeowDecibels
        {
            get { return this.meowDecibels; }
            private set { this.meowDecibels = value; }
        }

        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.MeowDecibels}";
        }
    }
}