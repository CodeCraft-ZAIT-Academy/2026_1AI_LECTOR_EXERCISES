// Úloha 23: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Mzdy spolu: 8900 EUR

Employee[] staff = new Employee[3];
staff[0] = new Manager { Name = "Jana", Salary = 3500 };
staff[1] = new Developer { Name = "Peter", Salary = 2800 };
staff[2] = new Developer { Name = "Eva", Salary = 2600 };

int sum = 0;
for (int i = 1; i < staff.Length; i++)
{
    sum = sum + staff[i].Salary;
}
Console.WriteLine("Mzdy spolu: " + sum + " EUR");

public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}

public class Manager : Employee
{
}

public class Developer : Employee
{
}
