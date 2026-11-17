// Úloha 12: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex

Dog rex = new Dog();
rex.Name = "Rex";
Console.WriteLine(rex.Name);

class Animal
{
    public string Name { get; set; }
}

public class Dog : Animal
{
}
