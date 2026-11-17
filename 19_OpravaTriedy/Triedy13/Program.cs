// Úloha 13: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex
//   Max

Dog dog = new Dog();
dog.Name = "Rex";
Console.WriteLine(dog.Name);

Dog dog = new Dog();
dog.Name = "Max";
Console.WriteLine(dog.Name);

public class Dog
{
    public string Name { get; set; }
}
