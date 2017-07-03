namespace _03.Oldest_Family_Member
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;

    internal class Program
    {
        private static void Main()
        {
            MethodInfo oldestMemberMethod = typeof(Family).GetMethod("GetOldestMember");
            MethodInfo addMemberMethod = typeof(Family).GetMethod("AddMember");
            if (oldestMemberMethod == null || addMemberMethod == null)
            {
                throw new Exception();
            }

            // Read family members
            List<Person> familyPersons = new List<Person>();
            ReadFamilyMembers(familyPersons);

            Family newFamily = new Family(familyPersons); // Make new family to store members

            Console.WriteLine(newFamily.GetOldestMember().ToString()); // Print oldest member
        }

        private static void ReadFamilyMembers(List<Person> familyPersons)
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] lineTokens = Console.ReadLine().Split();

                Person newPerson = new Person(lineTokens[0], int.Parse(lineTokens[1]));

                familyPersons.Add(newPerson); // Add person to family list
            }
        }
    }
}