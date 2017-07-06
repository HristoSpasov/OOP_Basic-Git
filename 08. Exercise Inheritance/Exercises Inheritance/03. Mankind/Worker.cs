using System;

namespace _03.Mankind
{
    internal class Worker : Human
    {
        private decimal salary;
        private double workingHours;

        public Worker(string firstName, string lastName, decimal salary, double workingHours)
            : base(firstName, lastName)
        {
            this.Salary = salary;
            this.WorkingHours = workingHours;
        }

        private double WorkingHours
        {
            get
            {
                return this.workingHours;
            }

            set
            {
                if (value < 1 || value > 12)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: workHoursPerDay");
                }

                this.workingHours = value;
            }
        }

        private decimal Salary
        {
            get
            {
                return this.salary;
            }

            set
            {
                if (value < 10)
                {
                    throw new ArgumentException("Expected value mismatch! Argument: weekSalary");
                }

                this.salary = value;
            }
        }

        public override string ToString()
        {
            return $"First Name: {base.FirstName}\n" +
                   $"Last Name: {base.LastName}\n" +
                   $"Week Salary: {this.Salary:f2}\n" +
                   $"Hours per day: {this.WorkingHours:f2}\n" +
                   $"Salary per hour: {(this.Salary / 5.0m / (decimal)(this.WorkingHours)):f2}";
        }
    }
}