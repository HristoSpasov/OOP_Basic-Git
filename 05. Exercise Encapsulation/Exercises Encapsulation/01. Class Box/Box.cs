namespace _01.Class_Box
{
    internal class Box
    {
        private double length;
        private double width;
        private double heigth;

        public Box(double length, double width, double heigth)
        {
            this.length = length;
            this.heigth = heigth;
            this.width = width;
        }

        public double Volume()
        {
            return this.heigth * this.width * this.length;
        }

        public double LateralSurface()
        {
            return (2 * this.length * this.heigth) + (2 * this.width * this.heigth);
        }

        public double SurfaceArea()
        {
            return (2 * this.length * this.width) + (2 * this.length * this.heigth) + (2 * this.width * this.heigth);
        }
    }
}