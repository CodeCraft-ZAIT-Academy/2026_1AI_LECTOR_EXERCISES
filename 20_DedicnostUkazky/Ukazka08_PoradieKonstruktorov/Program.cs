// ===== DEDIČNOSŤ 08 – Poradie volania konštruktorov =====
// Pojmy: najprv konštruktor základnej triedy, potom odvodenej („dom sa stavia od základov“)
// Skús zmeniť:
//   1. Predpovedz výstup pred spustením.
//   2. Pridaj do Dog druhý konštruktor Dog(string name). Aké poradie vypíše?
//   3. Spusti s F11 (Step Into) a sleduj, kam skáče debugger.

Console.WriteLine("Vytvaram psa...");
Dog rex = new Dog();
Console.WriteLine("Pes je hotovy");

public class Animal
{
    public Animal()
    {
        Console.WriteLine("  konstruktor Animal");
    }
}

public class Mammal : Animal
{
    public Mammal()
    {
        Console.WriteLine("  konstruktor Mammal");
    }
}

public class Dog : Mammal
{
    public Dog()
    {
        Console.WriteLine("  konstruktor Dog");
    }
}
