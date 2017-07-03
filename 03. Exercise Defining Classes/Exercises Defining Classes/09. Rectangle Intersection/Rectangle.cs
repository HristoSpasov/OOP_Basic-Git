namespace _09.Rectangle_Intersection
{
    internal class Rectangle
    {
        public Rectangle(string id, double width, double heigth, double topLeftX, double topLeftY)
        {
            this.Id = id;
            this.Width = width;
            this.Heigth = heigth;
            this.TopLeftX = topLeftX;
            this.TopLeftY = topLeftY;
        }

        public string Id { get; set; }

        public double Width { get; set; }

        public double Heigth { get; set; }

        public double TopLeftX { get; set; }

        public double TopLeftY { get; set; }

        public bool Intersects(Rectangle other)
        {
            if ((other.TopLeftY >= this.TopLeftY && other.TopLeftY - other.Heigth <= this.TopLeftY && other.TopLeftX <= this.TopLeftX && other.TopLeftX + other.Width >= this.TopLeftX) ||
                (other.TopLeftY >= this.TopLeftY && other.TopLeftY - other.Heigth <= this.TopLeftY && other.TopLeftX >= this.TopLeftX && other.TopLeftX <= this.TopLeftX + this.Width) ||
                (other.TopLeftY <= this.TopLeftY && other.TopLeftY >= this.TopLeftY - this.Heigth && other.TopLeftX <= this.TopLeftX && other.TopLeftX + other.Width >= this.TopLeftX) ||
                (other.TopLeftY <= this.TopLeftY && other.TopLeftY >= this.TopLeftY - this.Heigth && other.TopLeftX >= this.TopLeftX && other.TopLeftX <= this.TopLeftX + this.Width))
            {
                return true;
            }

            return false;
        }
    }
}