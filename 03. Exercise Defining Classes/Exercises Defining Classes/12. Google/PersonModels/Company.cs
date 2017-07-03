namespace _12.Google
{
    internal class Company
    {
        private string name;
        private string department;
        private double salary;

        public Company()
        {
        }

        public Company(string name, string department, double salary)
        {
            this.Name = name;
            this.Department = department;
            this.Salary = salary;
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public string Department
        {
            get { return this.department; }
            private set { this.department = value; }
        }

        public double Salary
        {
            get { return this.salary; }
            private set { this.salary = value; }
        }

        public override string ToString()
        {
            return (this.Salary != 0) ? $"{this.Name} {this.Department} {this.Salary:F2}\n" : $"{string.Empty}";
        }
    }
}