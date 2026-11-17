// Úloha 8: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex

public class Dog
{
    public string Name { get; set; }
}

Dog myDog = new Dog();
myDog.Name = "Rex";
Console.WriteLine(myDog.Name);
