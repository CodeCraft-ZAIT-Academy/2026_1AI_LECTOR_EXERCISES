// Úloha 11: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex papa
//   dycha pluckami

Dog rex = new Dog();
rex.Name = "Rex";
rex.Eat();
rex.Breathe();

public class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine(Name + " papa");
    }
}

public class Mammal
{
    public void Breathe()
    {
        Console.WriteLine("dycha pluckami");
    }
}

public class Dog : Animal, Mammal
{
}
