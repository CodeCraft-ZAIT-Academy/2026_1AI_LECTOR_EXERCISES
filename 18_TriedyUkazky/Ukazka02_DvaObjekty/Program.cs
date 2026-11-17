// ===== TRIEDY 02 – Viac objektov z jednej triedy =====
// Pojmy: každý objekt má vlastné dáta, predvolené hodnoty (0, null)
// Skús zmeniť:
//   1. Vytvor tretieho psa a vypíš ho.
//   2. Zmeň vek prvého psa. Zmenil sa aj druhý?
//   3. Čo sa vypíše pre psa, ktorému nenastavíme nič?

Dog rex = new Dog();
rex.Name = "Rex";
rex.Age = 3;

Dog max = new Dog();
max.Name = "Max";
max.Age = 1;

rex.Age = 4;

Console.WriteLine(rex.Name + " ma " + rex.Age + " rokov");
Console.WriteLine(max.Name + " ma " + max.Age + " rokov");

Dog nobody = new Dog();
Console.WriteLine("Nenastaveny pes: meno [" + nobody.Name + "], vek " + nobody.Age);

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}
