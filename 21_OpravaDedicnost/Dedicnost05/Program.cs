// Úloha 5: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex (Labrador)

Dog rex = new Dog("Rex");
Console.WriteLine(rex.Name + " (" + rex.Breed + ")");

public class Animal
{
    public string Name { get; set; }

    public Animal(string name)
    {
        Name = name;
    }
}

public class Dog : Animal
{
    public string Breed { get; set; }

    public Dog(string name, string breed) : base(name)
    {
        Breed = breed;
    }
}
