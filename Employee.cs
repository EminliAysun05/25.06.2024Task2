namespace _25._06._2024Task2;

public class Employee : IPerson
{
    private static int _id;
    public int Id { get; set; }
    public string Name { get; set; }
    public byte Age { get; set; }
    public double Salary { get; set; }
    public Employee(string name, byte age, double salary)
    {
        Id = ++_id; 
        Age = age;
        Name = name;
        Salary = salary;
    }
    public string ShowInfo()
    {
        return $"Name - {Name}, Age - {Age}";
    }
    public override string ToString()
    {
        return base.ToString();
    }
}
