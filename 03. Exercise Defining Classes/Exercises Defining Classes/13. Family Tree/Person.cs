namespace _13.Family_Tree
{
    using System.Collections.Generic;

    internal class Person
    {
        private string name;
        private string birthday;
        private HashSet<Person> parents;
        private HashSet<Person> children;

        public Person(string name, string birthday)
        {
            this.Name = name;
            this.birthday = birthday;
            this.Parents = new HashSet<Person>();
            this.Children = new HashSet<Person>();
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

        public HashSet<Person> Parents
        {
            get { return this.parents; }
            private set { this.parents = value; }
        }

        public HashSet<Person> Children
        {
            get { return this.children; }
            private set { this.children = value; }
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Birthday}\n";
        }
    }
}