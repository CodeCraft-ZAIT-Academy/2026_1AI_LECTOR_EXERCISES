// Úloha 26: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex (3)

Dog myDog = new Dog { Name = "Rex", Age = 3 };
Console.WriteLine(myDog);

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}
