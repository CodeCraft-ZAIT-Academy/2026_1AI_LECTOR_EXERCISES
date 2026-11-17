// Úloha 9: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex: Haf haf!

Dog myDog = new Dog();
myDog.Name = "Rex";
Dog.Speak();

public class Dog
{
    public string Name { get; set; }

    public void Speak()
    {
        Console.WriteLine(Name + ": Haf haf!");
    }
}
