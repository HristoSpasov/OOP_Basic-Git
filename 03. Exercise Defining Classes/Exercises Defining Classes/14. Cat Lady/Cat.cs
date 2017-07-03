namespace _14.Cat_Lady
{
    public class Cat
    {
        private string name;
        private string breed;

        public Cat(string name, string breed)
        {
            this.Name = name;
            this.Breed = breed;
        }

        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }

        public string Breed
        {
            get { return this.breed; }
            set { this.breed = value; }
        }
    }
}