// ===== DEDIČNOSŤ 01 – Prvá dedičnosť =====
// Pojmy: základná trieda (base, parent), odvodená trieda (derived, child), dvojbodka `:`
// Skús zmeniť:
//   1. Pridaj do Animal metódu Sleep() a zavolaj ju na psovi (Dog ju nemusí obsahovať).
//   2. Pridaj do Dog vlastnosť Breed (plemeno).
//   3. Skús zavolať rex.Bark() na objekte typu Animal. Čo napíše kompilátor?

Dog rex = new Dog();
rex.Name = "Rex";       // vlastnosť zdedená z Animal
rex.Age = 3;            // vlastnosť zdedená z Animal

rex.Eat();              // metóda zdedená z Animal
rex.Bark();             // vlastná metóda triedy Dog

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Eat()
    {
        Console.WriteLine(Name + " papa");
    }
}

// Dog dedí z Animal: "Dog JE Animal"
public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine(Name + ": Haf haf!");
    }
}
