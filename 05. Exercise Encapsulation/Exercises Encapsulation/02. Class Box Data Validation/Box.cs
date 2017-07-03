namespace _02.Class_Box_Data_Validation
{
    using System;

    internal class Box
    {
        private double length;
        private double width;
        private double heigth;

        public Box(double length, double width, double heigth)
        {
            this.Length = length;
            this.Heigth = heigth;
            this.Width = width;
        }

        public double Length
        {
            get
            {
                return this.length;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Heigth
        {
            get
            {
                return this.heigth;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }

                this.heigth = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Width cannot be zero or negative.");
                }

                this.width = value;
            }
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