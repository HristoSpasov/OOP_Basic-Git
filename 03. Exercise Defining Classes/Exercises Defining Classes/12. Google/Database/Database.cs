namespace _12.Google.Database
{
    using System.Collections.Generic;
    using System.Linq;

    internal static class Database
    {
        private static readonly HashSet<Person> PersonList;

        static Database()
        {
            // Static ctor
            PersonList = new HashSet<Person>();
        }

        public static Person GetPerson(string name)
        {
            return PersonList.FirstOrDefault(p => p.Name == name);
        }

        public static void RemovePerson(string name)
        {
            PersonList.RemoveWhere(n => n.Name == name);
        }

        public static void AddPerson(Person person)
        {
            PersonList.Add(person);
        }

        public static bool PersonExists(string name)
        {
            return PersonList.Any(n => n.Name == name);
        }
    }
}