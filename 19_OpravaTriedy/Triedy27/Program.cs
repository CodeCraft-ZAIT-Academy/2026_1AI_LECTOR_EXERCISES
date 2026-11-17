// Úloha 27: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rovnake psy

Dog a = new Dog { Name = "Rex", Age = 3 };
Dog b = new Dog { Name = "Rex", Age = 3 };

if (a == b)
{
    Console.WriteLine("Rovnake psy");
}
else
{
    Console.WriteLine("Rozne psy");
}

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}
