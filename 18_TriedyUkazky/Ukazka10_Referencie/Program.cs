// ===== TRIEDY 10 – Premenná drží odkaz na objekt =====
// Pojmy: referencia (odkaz), dve premenné na jeden objekt, == porovnáva odkazy
// Skús zmeniť:
//   1. Predpovedz výpisy PRED spustením.
//   2. Zmeň b = a na b = new Dog { ... }. Čo sa zmení?
//   3. Zmeň vek v c tak, aby bol iný. Je a == c?

Dog a = new Dog { Name = "Rex", Age = 3 };
Dog b = a;                      // nový pes sa NEVYTVORIL, b ukazuje na toho istého psa
b.Name = "Max";

Console.WriteLine("a.Name = " + a.Name);
Console.WriteLine("b.Name = " + b.Name);

Dog c = new Dog { Name = "Max", Age = 3 };   // iný objekt, hoci rovnaké hodnoty

Console.WriteLine("a == b: " + (a == b));
Console.WriteLine("a == c: " + (a == c));
Console.WriteLine("Rovnake meno aj vek: " + (a.Name == c.Name && a.Age == c.Age));

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}
