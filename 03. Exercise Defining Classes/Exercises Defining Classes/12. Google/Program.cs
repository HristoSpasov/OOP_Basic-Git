namespace _12.Google
{
    using _12.Google.Database;
    using System;

    internal static class Program
    {
        private static void Main()
        {
            PersonDataReader.PersonReader(); // Start reading persons

            Person personToPrint = Database.Database.GetPerson(Console.ReadLine()); // Get person from db

            Console.WriteLine(personToPrint.ToString().Trim());
        }
    }
}