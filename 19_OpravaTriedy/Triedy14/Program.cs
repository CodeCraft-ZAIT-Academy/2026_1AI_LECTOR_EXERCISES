// Úloha 14: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex

Dog myDog = new Dog();
myDog.Name = "Rex";
Console.WriteLine(myDog.Name);

public class Dog
{
    public string Name { get; set }
}
