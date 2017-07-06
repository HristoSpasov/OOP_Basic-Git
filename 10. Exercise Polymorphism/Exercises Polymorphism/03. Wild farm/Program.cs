using _03.Wild_farm.Animals;
using _03.Wild_farm.Animals.CatFamily;
using _03.Wild_farm.Animals.Herbivores;
using _03.Wild_farm.Exceptions;
using _03.Wild_farm.Food;
using System;

namespace _03.Wild_farm
{
    public class Program
    {
        private static void Main()
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "End")
                {
                    break;
                }

                string[] animalTokens = line.Split();
                string[] foodTokens = Console.ReadLine().Split();

                switch (animalTokens[0].ToLower())
                {
                    case "cat":
                        {
                            Cat newCat = new Cat(animalTokens[0], animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3], animalTokens[4]);
                            Console.WriteLine(newCat.MakeSound());
                            SwitchFood(newCat, foodTokens);
                            Console.WriteLine(newCat.ToString());
                        }
                        break;

                    case "tiger":
                        {
                            Tiger newTiger = new Tiger(animalTokens[0], animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3]);
                            Console.WriteLine(newTiger.MakeSound());
                            SwitchFood(newTiger, foodTokens);
                            Console.WriteLine(newTiger.ToString());
                        }
                        break;

                    case "mouse":
                        {
                            Mouse newMouse = new Mouse(animalTokens[0], animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3]);
                            Console.WriteLine(newMouse.MakeSound());
                            SwitchFood(newMouse, foodTokens);
                            Console.WriteLine(newMouse.ToString());
                        }
                        break;

                    case "zebra":
                        {
                            Zebra newZebra = new Zebra(animalTokens[0], animalTokens[1], double.Parse(animalTokens[2]), animalTokens[3]);
                            Console.WriteLine(newZebra.MakeSound());
                            SwitchFood(newZebra, foodTokens);
                            Console.WriteLine(newZebra.ToString());
                        }
                        break;
                }
            }
        }

        private static void SwitchFood(Animal animal, string[] foodTokens)
        {
            try
            {
                switch (foodTokens[0].ToLower())
                {
                    case "vegetable":
                        {
                            Vegetable newVegetable = new Vegetable(int.Parse(foodTokens[1]));
                            animal.EatFood(newVegetable);
                        }
                        break;

                    case "meat":
                        {
                            Meat newMeat = new Meat(int.Parse(foodTokens[1]));
                            animal.EatFood(newMeat);
                        }
                        break;
                        //default:
                        //    throw new AnimalDoesNotEatFoodException(animal.GetType().Name);
                }
            }
            catch (AnimalDoesNotEatFoodException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}