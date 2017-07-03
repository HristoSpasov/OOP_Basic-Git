namespace _12.Google
{
    using System.Collections.Generic;
    using System.Linq;

    internal class Person
    {
        private string name;
        private Company company;
        private List<Parent> parents;
        private List<Pokemon> pokemons;
        private List<Child> children;
        private Car car;

        public Person(string name)
        {
            this.Name = name;
            this.Company = new Company();
            this.Parents = new List<Parent>();
            this.Pokemons = new List<Pokemon>();
            this.Children = new List<Child>();
            this.Car = new Car();
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public Company Company
        {
            get { return this.company; }
            set { this.company = value; }
        }

        public List<Parent> Parents
        {
            get { return this.parents; }
            set { this.parents = value; }
        }

        public List<Pokemon> Pokemons
        {
            get { return this.pokemons; }
            set { this.pokemons = value; }
        }

        public List<Child> Children
        {
            get { return this.children; }
            set { this.children = value; }
        }

        public Car Car
        {
            get { return this.car; }
            set { this.car = value; }
        }

        public override string ToString()
        {
            return $"{this.Name}\n" +
                   $"Company:\n{this.Company.ToString()}" +
                   $"Car:\n{this.Car.ToString()}" +
                   $"Pokemon:\n{string.Concat(this.Pokemons.SelectMany(pokemon => pokemon.ToString()))}" +
                   $"Parents:\n{string.Concat(this.Parents.Select(parent => parent.ToString()))}" +
                   $"Children:\n{string.Concat(this.Children)}";
        }
    }
}