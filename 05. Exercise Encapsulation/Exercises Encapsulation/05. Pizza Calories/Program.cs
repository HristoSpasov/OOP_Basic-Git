namespace _05.Pizza_Calories
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            try
            {
                while (true)
                {
                    string line = Console.ReadLine();

                    if (line == "END")
                    {
                        break;
                    }

                    if (line.StartsWith("Pizza"))
                    {
                        string[] pizzaLine = line.Split();
                        string[] doughLine = Console.ReadLine().Split();
                        Pizza newPizza =
                            new Pizza(pizzaLine[1], int.Parse(pizzaLine[2]))
                            {
                                Dough = new Dough(doughLine[1], doughLine[2], int.Parse(doughLine[3]))
                            };

                        // Read all toppings
                        for (int i = 0; i < int.Parse(pizzaLine[2]); i++)
                        {
                            string[] toppingLine = Console.ReadLine().Split();

                            newPizza.AddTopping(new Topping(toppingLine[1], int.Parse(toppingLine[2])));
                        }

                        Console.WriteLine($"{newPizza.Name} - {newPizza.TotalCalories:f2} Calories.");

                        continue;
                    }

                    if (line.StartsWith("Dough"))
                    {
                        string[] doughLine = line.Split();

                        Dough newDough = new Dough(doughLine[1], doughLine[2], int.Parse(doughLine[3]));

                        Console.WriteLine($"{newDough.Calories:F2}");

                        continue;
                    }

                    if (line.StartsWith("Topping"))
                    {
                        string[] toppingLine = line.Split();

                        Topping newTopping = new Topping(toppingLine[1], int.Parse(toppingLine[2]));

                        Console.WriteLine($"{newTopping.Calories:F2}");
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}