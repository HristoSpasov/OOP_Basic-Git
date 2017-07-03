namespace _15.Drawing_tool
{
    internal abstract class CorDraw
    {
        private int heigth;
        private int width;

        protected CorDraw(int a)
        {
            this.width = a;
            this.heigth = a;
        }

        protected CorDraw(int width, int heigth)
        {
            this.heigth = heigth;
            this.width = width;
        }

        protected int Height
        {
            get { return this.heigth; }
            set { this.heigth = value; }
        }

        protected int Width
        {
            get { return this.width; }
            set { this.width = value; }
        }
    }
}