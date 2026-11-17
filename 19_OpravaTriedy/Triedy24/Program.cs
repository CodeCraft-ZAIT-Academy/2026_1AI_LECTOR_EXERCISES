// Úloha 24: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Pes 1
//   Pes 2
//   Pes 3

List<Dog> dogs = new List<Dog>();
Dog dog = new Dog();

for (int i = 1; i <= 3; i++)
{
    dog.Name = "Pes " + i;
    dogs.Add(dog);
}

foreach (Dog d in dogs)
{
    Console.WriteLine(d.Name);
}

public class Dog
{
    public string Name { get; set; }
}
