using System.Collections.Generic;

namespace _03.Wild_farm.Animals.CatFamily
{
    public class Cat : CatFamily
    {
        private static readonly IEnumerable<string> foodEating = new List<string>() { "vegetable", "meat" };
        private string breed;

        public Cat(string animalType, string animalName, double animalWeight, string livingRegion, string breed) : base(animalType, animalName, animalWeight, livingRegion)
        {
            this.breed = breed;
        }

        public override string MakeSound()
        {
            return "Meowwww";
        }

        public override string ToString()
        {
            return $"{this.animalType}[{this.animalName}, {this.breed}, {this.animalWeight}, {this.livingRegion}, {this.foodEaten}]";
        }
    }
}