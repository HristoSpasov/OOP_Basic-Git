using System;

namespace _05.Mordor_s_Cruelty_Plan
{
    internal class Program
    {
        private static void Main()
        {
            MoodFactory moodFactory = new MoodFactory();
            FoodFactory foodFactory = new FoodFactory();

            int happinessPoints = 0;

            string[] line = Console.ReadLine()
                .Trim()
                .Split("\n\t ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);

            foreach (var food in line)
            {
                happinessPoints += foodFactory.GetHappiness(food);
            }

            Console.WriteLine(happinessPoints);
            Console.WriteLine(moodFactory.GetMood(happinessPoints));
        }
    }
}