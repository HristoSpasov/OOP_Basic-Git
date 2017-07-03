internal class Person
{
    private string firstName;
    private string lastName;
    private int age;
    private double salary;

    public Person(string firstName, string lastName, int age, double salary)
    {
        this.firstName = firstName;
        this.lastName = lastName;
        this.age = age;
        this.salary = salary;
    }

    public string FirstName
    {
        get { return this.firstName; }
    }

    public string LastName
    {
        get { return this.lastName; }
    }

    public int Age
    {
        get { return this.age; }
    }

    public double Salary
    {
        get { return this.salary; }
    }

    public override string ToString()
    {
        return $"{this.FirstName} {this.LastName} get {this.Salary} leva.";
    }

    public void IncreaseSalary(double bonus)
    {
        this.salary += this.age > 30 ? this.salary * bonus / 100 : this.salary * bonus / 200;
    }
}