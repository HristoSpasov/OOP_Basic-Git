namespace _08.Raw_Data
{
    internal class Cargo
    {
        public Cargo(int weigth, string type)
        {
            this.Weight = weigth;
            this.Type = type;
        }

        public int Weight { get; set; }

        public string Type { get; set; }
    }
}