// ===== DEDIČNOSŤ 11 – Pole objektov odvodených tried =====
// Pojmy: Employee[] drží Manager aj Developer, cyklus cez spoločné vlastnosti
// Skús zmeniť:
//   1. Pridaj ďalšieho zamestnanca (zväčši pole).
//   2. Vypíš len zamestnancov s platom nad 2000.
//   3. Pridaj triedu Tester : Employee a pridaj jedného do poľa.

Employee[] staff = new Employee[3];
staff[0] = new Manager { Name = "Jana", Salary = 3500, Bonus = 500 };
staff[1] = new Developer { Name = "Peter", Salary = 2800, Language = "C#" };
staff[2] = new Developer { Name = "Eva", Salary = 2600, Language = "Java" };

int sum = 0;
foreach (Employee employee in staff)
{
    Console.WriteLine(employee.Name + ": " + employee.Salary + " EUR");
    sum = sum + employee.Salary;
}
Console.WriteLine("Mzdy spolu: " + sum + " EUR");

Employee best = staff[0];
foreach (Employee employee in staff)
{
    if (employee.Salary > best.Salary)
    {
        best = employee;
    }
}
Console.WriteLine("Najviac zarabana: " + best.Name);

// Manager ma navyse Bonus: vidíme ho len cez premennú typu Manager
Manager boss = new Manager { Name = "Jana", Salary = 3500, Bonus = 500 };
Console.WriteLine("Manazer " + boss.Name + " ma s bonusom " + (boss.Salary + boss.Bonus) + " EUR");

public class Employee
{
    public string Name { get; set; }
    public int Salary { get; set; }
}

public class Manager : Employee
{
    public int Bonus { get; set; }
}

public class Developer : Employee
{
    public string Language { get; set; }
}
