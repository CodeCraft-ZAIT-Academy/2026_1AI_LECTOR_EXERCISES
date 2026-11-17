// ===== TRIEDY 06 – Predvolené hodnoty a inicializátor =====
// Pojmy: predvolená hodnota vlastnosti, inicializátor objektu { ... }
// Skús zmeniť:
//   1. Zmeň predvolené zdravie hrdinu na 200.
//   2. Vytvor hrdinu s inou silou útoku v inicializátore.
//   3. Pridaj vlastnosť Mana s predvolenou hodnotou 50.

Dog a = new Dog { Name = "Rex", Age = 3 };
Console.WriteLine(a.Name + " " + a.Age);

Hero h1 = new Hero { Name = "Aragorn" };
Hero h2 = new Hero { Name = "Gimli", Health = 150, AttackPower = 20 };

Console.WriteLine(h1.Name + ": zdravie " + h1.Health + ", sila " + h1.AttackPower);
Console.WriteLine(h2.Name + ": zdravie " + h2.Health + ", sila " + h2.AttackPower);

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}

public class Hero
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;        // predvolená hodnota
    public int AttackPower { get; set; } = 10;
}
