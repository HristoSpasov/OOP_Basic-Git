namespace _15.Drawing_tool
{
    using System;

    internal class Square : CorDraw
    {
        public Square(int a) : base(a)
        {
        }

        public void Draw()
        {
            string topAndBottomLine = string.Empty;
            for (int i = 0; i < this.Width; i++)
            {
                topAndBottomLine += "-";
            }

            string insideEmptySpaces = new string(' ', this.Width);

            // Start printing
            Console.WriteLine($"|{topAndBottomLine.Trim()}|");

            for (int i = 0; i < this.Height - 2; i++)
            {
                Console.Write("|");
                Console.Write(insideEmptySpaces);
                Console.WriteLine("|");
            }

            Console.WriteLine($"|{topAndBottomLine.Trim()}|");
        }
    }
}