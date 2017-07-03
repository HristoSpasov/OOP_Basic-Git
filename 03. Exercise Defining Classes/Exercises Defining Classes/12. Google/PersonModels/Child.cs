namespace _12.Google
{
    internal class Child
    {
        private string name;
        private string birthday;

        public Child(string name, string birthday)
        {
            this.Name = name;
            this.Birthday = birthday;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Birthday
        {
            get { return this.birthday; }
            private set { this.birthday = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Birthday}\n";
        }
    }
}