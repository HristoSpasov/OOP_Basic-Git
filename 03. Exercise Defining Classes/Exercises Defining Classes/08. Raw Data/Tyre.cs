namespace _08.Raw_Data
{
    internal class Tyre
    {
        public Tyre(double tp1, int ta1, double tp2, int ta2, double tp3, int ta3, double tp4, int ta4)
        {
            this.Pressure1 = tp1;
            this.Pressure2 = tp2;
            this.Pressure3 = tp3;
            this.Pressure4 = tp4;
            this.Age1 = ta1;
            this.Age2 = ta2;
            this.Age3 = ta3;
            this.Age4 = ta4;
        }

        public double Pressure1 { get; set; }

        public int Age1 { get; set; }

        public double Pressure2 { get; set; }

        public int Age2 { get; set; }

        public double Pressure3 { get; set; }

        public int Age3 { get; set; }

        public double Pressure4 { get; set; }

        public int Age4 { get; set; }
    }
}