using System;

namespace _03.Wild_farm.Exceptions
{
    public class AnimalDoesNotEatFoodException : Exception
    {
        public AnimalDoesNotEatFoodException(string animalType)
            : base($"{animalType}s are not eating that type of food!")
        {
        }
    }
}