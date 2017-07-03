namespace _14.Cat_Lady
{
    public class Siamese : Cat
    {
        private int earSize;

        public Siamese(string name, string breed, int earSIze) : base(name, breed)
        {
            this.EarSize = earSIze;
        }

        public int EarSize
        {
            get { return this.earSize; }
            private set { this.earSize = value; }
        }

        public override string ToString()
        {
            return $"{this.Breed} {this.Name} {this.EarSize}";
        }
    }
}