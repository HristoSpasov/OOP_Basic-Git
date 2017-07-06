using _03.Wild_farm.Exceptions;

namespace _03.Wild_farm
{
    public abstract class Animal
    {
        protected string animalType;
        protected string animalName;
        protected double animalWeight;
        protected string livingRegion;
        protected int foodEaten;

        protected Animal(string animalType, string animalName, double animalWeight, string livingRegion)
        {
            this.animalType = animalType;
            this.animalName = animalName;
            this.animalWeight = animalWeight;
            this.livingRegion = livingRegion;
            this.foodEaten = 0;
        }

        public abstract string MakeSound();

        public void EatFood(Food.Food food)
        {
            if (!Static.FoodByAnimals.foodByAnimals[this.animalType.ToLower()].Contains(food.GetType().Name.ToLower()))
            {
                throw new AnimalDoesNotEatFoodException(this.GetType().Name);
            }

            this.foodEaten = food.Quantity;
        }

        public override string ToString()
        {
            return $"{this.animalType}[{this.animalName}, {this.animalWeight}, {this.livingRegion}, {this.foodEaten}]";
        }
    }
}