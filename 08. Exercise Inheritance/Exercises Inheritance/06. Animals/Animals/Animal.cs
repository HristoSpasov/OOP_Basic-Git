using _05.Mordor_s_Cruelty_Plan.Exceptions;

namespace _05.Mordor_s_Cruelty_Plan.Animals
{
    public abstract class Animal
    {
        private string name;
        private string age;
        private string gender;

        protected Animal(string name, string age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        protected string Gender
        {
            get
            {
                return this.gender;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidInput();
                }

                this.gender = value;
            }
        }

        protected string Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || int.Parse(value) < 0)
                {
                    throw new InvalidInput();
                }

                this.age = value;
            }
        }

        protected string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new InvalidInput();
                }

                this.name = value;
            }
        }

        protected virtual string ProduceSound()
        {
            return "";
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Age} {this.Gender}\n";
        }
    }
}