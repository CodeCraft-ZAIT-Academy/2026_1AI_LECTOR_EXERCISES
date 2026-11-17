// ===== DEDIČNOSŤ 07 – Konštruktor a base(...) =====
// Pojmy: konštruktor sa nededí, `: base(name)` odovzdá hodnotu základnému konštruktoru
// Skús zmeniť:
//   1. Zmeň new Dog("Rex", "Labrador") na new Dog("Rex"). Prečo to nejde?
//   2. Vymaž `: base(name)`. Čo hlási kompilátor?
//   3. Pridaj do Animal vek (age) a posielaj ho cez base(name, age).

Dog rex = new Dog("Rex", "Labrador");
Console.WriteLine(rex.Name + " (" + rex.Breed + ")");

Cat micka = new Cat("Micka");
Console.WriteLine(micka.Name);

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }
}

public class Dog : Animal
{
    public string Breed { get; set; }

    // name posielame základnému konštruktoru, breed si spracuje Dog sám
    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }
}
