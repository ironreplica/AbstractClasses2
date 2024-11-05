Main();
void Main()
{
    Employee[] employees = { new FullTimeEmployee("Houston"), new PartTimeEmployee("Jonathan") };
    foreach(Employee employee in employees)
    {
        employee.DisplayEmployeeInfo();
    }
}
public abstract class Employee
{
    public string? Name { get; set; }
    public abstract void CalculateMonthlySalary();
    public void DisplayEmployeeInfo()
    {
        Console.WriteLine(Name);
        CalculateMonthlySalary();
    }
}
public class FullTimeEmployee : Employee
{
    public int AnnualSalary = 60000;
    
    public FullTimeEmployee(string name)
    {
        Name = name;
    }
    public override void CalculateMonthlySalary()
    {
        Console.WriteLine(AnnualSalary / 12);
    }
}
public class PartTimeEmployee : Employee
{
    public int HourlyRate = 12;
    public int HoursWorked = 30;
    public PartTimeEmployee(string name)
    {
        Name = name;
    }
    public override void CalculateMonthlySalary()
    {
        Console.WriteLine(HourlyRate * HoursWorked);
    }
}