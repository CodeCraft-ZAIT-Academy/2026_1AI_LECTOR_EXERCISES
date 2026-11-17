// Úloha 22: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Jana zarobi 4000 EUR

Manager boss = new Manager { Name = "Jana", Salary = 3500, Bonus = 500 };
Console.WriteLine(boss.Name + " zarobi " + boss.TotalPay() + " EUR");

public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}

public class Manager : Employee
{
    public int Bonus { get; set; }

    public int TotalPay()
    {
        return Salary;
    }
}
