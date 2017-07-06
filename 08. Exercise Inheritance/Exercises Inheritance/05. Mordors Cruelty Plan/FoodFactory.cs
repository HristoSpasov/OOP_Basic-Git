using System.Collections.Generic;

namespace _05.Mordor_s_Cruelty_Plan
{
    internal class FoodFactory : Factory
    {
        private static Dictionary<string, int> foods;

        static FoodFactory()
        {
            foods = new Dictionary<string, int>()
            {
                { "cram", 2 },
                { "lembas", 3 },
                { "apple", 1 },
                { "melon", 1 },
                { "honeycake", 5 },
                { "mushrooms", -10 }
            };
        }

        public FoodFactory() : base()
        {
        }

        public int GetHappiness(string food)
        {
            if (foods.ContainsKey(food.ToLower()))
            {
                return foods[food.ToLower()];
            }

            return -1;
        }
    }
}