namespace _05.Mordor_s_Cruelty_Plan
{
    internal class MoodFactory : Factory
    {
        public MoodFactory() : base()
        {
        }

        public string GetMood(int happiness)
        {
            if (happiness < -5)
            {
                return "Angry";
            }

            if (happiness >= -5 && happiness <= 0)
            {
                return "Sad";
            }

            if (happiness >= 1 && happiness <= 15)
            {
                return "Happy";
            }

            return "JavaScript";
        }
    }
}