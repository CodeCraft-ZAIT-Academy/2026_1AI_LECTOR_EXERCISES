// ===== DEDIČNOSŤ 16 – Ladenie dedičnosti =====
// Postup: dvojklik vľavo pri čísle riadku (breakpoint) pri každom // STOP, spusti F5, krokuj F10 / F11.
// Úlohy:
//   STOP 1: Stlač F11. Do ktorého konštruktora si vstúpil najprv? Ktorý ďalší nasleduje? (Pozri aj Call Stack.)
//   STOP 2: Rozbaľ rex v okne Locals. Kde nájdeš Name (priamo pod rex alebo pod uzlom „Animal“ / „base“)? A Breed?
//   STOP 3: Si v metóde Describe() triedy Dog. Čo je „this“? Odkiaľ pochádza Name?

Dog rex = new Dog("Rex", "Labrador");        // STOP 1 (F11 = vstúp dnu)
rex.Eat();                                    // STOP 2
Console.WriteLine(rex.Describe());            // STOP 3 (F11 do Describe)

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }

    public void Eat()
    {
        Console.WriteLine(Name + " papa");
    }
}

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
    }

    public string Describe()
    {
        return Name + " je " + Breed;
    }
}
