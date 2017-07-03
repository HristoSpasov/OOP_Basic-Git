namespace _15.Drawing_tool
{
    using System;

    internal class Program
    {
        private static void Main()
        {
            switch (Console.ReadLine())
            {
                case "Square":
                    {
                        Square square = new Square(int.Parse(Console.ReadLine()));
                        square.Draw();
                    }

                    break;

                case "Rectangle":
                    {
                        Rectangle rectangle = new Rectangle(int.Parse(Console.ReadLine()), int.Parse(Console.ReadLine()));
                        rectangle.Draw();
                    }

                    break;
            }
        }
    }
}