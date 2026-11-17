// ===== DEDIČNOSŤ 06 – Viac úrovní dedičnosti =====
// Pojmy: reťaz dedičnosti, pes dostane členy od rodiča aj starého rodiča
// Skús zmeniť:
//   1. Pridaj do Animal metódu Sleep() a zavolaj ju na psovi.
//   2. Pridaj triedu Bird : Animal (nie Mammal). Má Breathe()?
//   3. Skús napísať class Dog : Mammal, Animal. Čo hlási kompilátor? (Dedí sa len z jednej triedy.)

Dog rex = new Dog { Name = "Rex" };

rex.Eat();          // z Animal (starý rodič)
rex.Breathe();      // z Mammal (rodič)
rex.Bark();         // vlastné

public class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine(Name + " papa");
    }
}

public class Mammal : Animal
{
    public void Breathe()
    {
        Console.WriteLine(Name + " dycha pluckami");
    }
}

public class Dog : Mammal
{
    public void Bark()
    {
        Console.WriteLine(Name + ": Haf haf!");
    }
}
