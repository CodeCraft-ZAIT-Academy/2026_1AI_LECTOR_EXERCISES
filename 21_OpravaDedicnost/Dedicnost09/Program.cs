// Úloha 9: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex

Dog rex = new Animal();
rex.Name = "Rex";
Console.WriteLine(rex.Name);

public class Animal
{
    public string Name { get; set; }
}

public class Dog : Animal
{
}
