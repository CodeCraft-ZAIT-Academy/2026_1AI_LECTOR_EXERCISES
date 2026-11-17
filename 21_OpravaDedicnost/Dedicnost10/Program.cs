// Úloha 10: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Micka

Cat micka = new Dog();
micka.Name = "Micka";
Console.WriteLine(micka.Name);

public class Animal
{
    public string Name { get; set; }
}

public class Dog : Animal
{
}

public class Cat : Animal
{
}
