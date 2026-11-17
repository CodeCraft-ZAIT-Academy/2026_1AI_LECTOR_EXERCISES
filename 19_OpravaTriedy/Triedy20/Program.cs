// Úloha 20: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex
//   Max

Dog a = new Dog();
a.Name = "Rex";

Dog b = a;
b.Name = "Max";

Console.WriteLine(a.Name);
Console.WriteLine(b.Name);

public class Dog
{
    public string Name { get; set; }
}
