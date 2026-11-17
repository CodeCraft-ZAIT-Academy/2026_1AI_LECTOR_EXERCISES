// Úloha 8: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex papa
//   Rex: Haf haf!

Animal pet = new Dog { Name = "Rex" };
pet.Eat();
pet.Bark();

public class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine(Name + " papa");
    }
}

public class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine(Name + ": Haf haf!");
    }
}
