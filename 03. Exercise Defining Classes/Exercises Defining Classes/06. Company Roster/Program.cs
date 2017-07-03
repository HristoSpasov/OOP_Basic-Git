namespace _06.Company_Roster
{
    using System;
    using System.Linq;

    internal class Program
    {
        private static void Main()
        {
            ReadEmplyeeInput(); // Read data from console

            string departmentWithHighestAverageSalary = Employee.GetDepartmentWithHighestAverage(); // Get department with highest average salary

            string emplyeeDepartmentReport = Employee.GetEmplyeesInDepartment(departmentWithHighestAverageSalary); // Get department report

            Console.WriteLine($"Highest Average Salary: {departmentWithHighestAverageSalary}");
            Console.WriteLine(emplyeeDepartmentReport.Trim());
        }

        private static void ReadEmplyeeInput()
        {
            int lines = int.Parse(Console.ReadLine());

            for (int i = 0; i < lines; i++)
            {
                string[] lineTokens = Console.ReadLine().Split();

                if (lineTokens.Length == 6)
                {
                    // All fields are present
                    new Employee(lineTokens[0], double.Parse(lineTokens[1]), lineTokens[2], lineTokens[3], lineTokens[4], int.Parse(lineTokens[5])).AddEmplyee();
                }
                else if (lineTokens.Length == 5)
                {
                    if (int.TryParse(lineTokens.Last(), out int parseAge))
                    {
                        new Employee(lineTokens[0], double.Parse(lineTokens[1]), lineTokens[2], lineTokens[3], int.Parse(lineTokens[4])).AddEmplyee(); // No email
                    }
                    else
                    {
                        new Employee(lineTokens[0], double.Parse(lineTokens[1]), lineTokens[2], lineTokens[3], lineTokens[4]).AddEmplyee(); // No age
                    }
                }
                else
                {
                    new Employee(lineTokens[0], double.Parse(lineTokens[1]), lineTokens[2], lineTokens[3]).AddEmplyee(); // No age, no email
                }
            }
        }
    }
}