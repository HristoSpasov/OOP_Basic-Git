namespace _06.Company_Roster
{
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    internal class Employee
    {
        private static List<Employee> emplyeeList = new List<Employee>();

        public Employee(string name, double salary, string position, string department, string email, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = age;
        }

        public Employee(string name, double salary, string position, string department, string email)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = email;
            this.Age = -1;
        }

        public Employee(string name, double salary, string position, string department, int age)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = "n/a";
            this.Age = age;
        }

        public Employee(string name, double salary, string position, string department)
        {
            this.Name = name;
            this.Salary = salary;
            this.Position = position;
            this.Department = department;
            this.Email = "n/a";
            this.Age = -1;
        }

        public string Name { get; set; }

        public double Salary { get; set; }

        public string Position { get; set; }

        public string Department { get; set; }

        public string Email { get; set; }

        public int Age { get; set; }

        public static string GetDepartmentWithHighestAverage()
        {
            return emplyeeList
                .GroupBy(d => d.Department)
                .Select(e => new
                {
                    Department = e.Key,
                    AveragaSalary = e.Select(s => s.Salary).Sum() / e.Select(s => s.Salary).ToArray().Length
                })
                .OrderByDescending(s => s.AveragaSalary)
                .ToArray()[0].Department;
        }

        public static string GetEmplyeesInDepartment(string department)
        {
            StringBuilder report = new StringBuilder();

            foreach (var employee in emplyeeList.Where(d => d.Department == department).OrderByDescending(s => s.Salary))
            {
                report.AppendLine(employee.ToString());
            }

            return report.ToString();
        }

        public override string ToString()
        {
            return $"{this.Name} {this.Salary:F2} {this.Email} {this.Age}";
        }

        public void AddEmplyee()
        {
            emplyeeList.Add(this);
        }
    }
}