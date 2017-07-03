namespace _09.Rectangle_Intersection
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        private static List<Rectangle> rectangles = new List<Rectangle>();

        private static StringBuilder output = new StringBuilder();

        private static void Main()
        {
            int[] rectangleCount = Console.ReadLine()
               .Split()
               .Select(int.Parse)
               .ToArray();

            ReadRectangles(rectangleCount[0]); // Read rectangles and add to rectangle list

            CheckForIntersections(rectangleCount[1]); // Check pairs of rectangles for intersections

            Console.WriteLine(output.ToString().Trim());
        }

        private static void CheckForIntersections(int pairs)
        {
            for (int i = 0; i < pairs; i++)
            {
                string[] rectanglePair = Console.ReadLine().Split();

                Rectangle first = rectangles.FirstOrDefault(r => r.Id == rectanglePair[0].Trim());
                Rectangle second = rectangles.FirstOrDefault(r => r.Id == rectanglePair[1].Trim());

                if (first.Intersects(second))
                {
                    output.AppendLine("true");
                }
                else
                {
                    output.AppendLine("false");
                }
            }
        }

        private static void ReadRectangles(int rectanglesCount)
        {
            for (int i = 0; i < rectanglesCount; i++)
            {
                string[] rectTokens = Console.ReadLine().Split();

                string id = rectTokens[0].Trim();
                double width = double.Parse(rectTokens[1]);
                double heigth = double.Parse(rectTokens[2]);
                double topLeftX = double.Parse(rectTokens[3]);
                double topLeftY = double.Parse(rectTokens[4]);

                rectangles.Add(new Rectangle(id, width, heigth, topLeftX, topLeftY));
            }
        }
    }
}