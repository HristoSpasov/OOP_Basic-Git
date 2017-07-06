namespace _03.Wild_farm.Food
{
    public abstract class Food
    {
        private int quantity;

        protected Food(int quantity)
        {
            this.quantity = quantity;
        }

        public int Quantity
        {
            get { return this.quantity; }
            private set { this.quantity = value; }
        }
    }
}