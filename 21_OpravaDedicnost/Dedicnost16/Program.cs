// Úloha 16: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Micka

Animal pet = new Cat { Name = "Micka" };
Dog dog = (Dog)pet;
Console.WriteLine(dog.Name);

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
