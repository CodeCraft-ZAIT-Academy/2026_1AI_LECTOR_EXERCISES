// ===== TRIEDY 05 – Konštruktor =====
// Pojmy: konštruktor, preťaženie konštruktora, new s argumentmi
// Skús zmeniť:
//   1. Vymaž prvý konštruktor (bez parametrov). Čo napíše kompilátor pri new Dog()?
//   2. Pridaj tretí konštruktor, ktorý berie len meno (vek bude 1).
//   3. Zmeň argumenty pri new Dog("Rex", 3).

Dog unknown = new Dog();
Dog rex = new Dog("Rex", 3);
Dog max = new Dog("Max", 1);

Console.WriteLine(unknown.Describe());
Console.WriteLine(rex.Describe());
Console.WriteLine(max.Describe());

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }

    // Konštruktor: názov = názov triedy, žiadny návratový typ
    public Dog()
    {
        Name = "Bez mena";
        Age = 0;
    }

    // Preťaženie: konštruktor s parametrami (parametre píšeme malým písmenom)
    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }

    public string Describe()
    {
        return Name + " (" + Age + ")";
    }
}
