// Úloha 1: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex papa

Dog rex = new Dog();
rex.Name = "Rex";
rex.Eat();

public class Animal
{
    public string Name { get; set; }

    public void Eat()
    {
        Console.WriteLine(Name + " papa");
    }
}

public class Dog extends Animal
{
}
