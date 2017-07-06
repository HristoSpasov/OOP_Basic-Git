using System.Collections.Generic;

namespace _03.Wild_farm.Static
{
    public class FoodByAnimals
    {
        public static Dictionary<string, List<string>> foodByAnimals = new Dictionary<string, List<string>>()
        {
            { "tiger", new List<string>(){"meat"}},
            { "cat", new List<string>(){"meat", "vegetable"}},
            { "zebra", new List<string>(){"vegetable"}},
            { "mouse", new List<string>(){"vegetable"}}
        };
    }
}