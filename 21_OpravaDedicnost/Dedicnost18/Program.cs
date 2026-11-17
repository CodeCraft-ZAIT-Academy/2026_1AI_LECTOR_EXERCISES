// Úloha 18: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Zviera: Rex

Dog rex = new Dog { Name = "Rex" };
Console.WriteLine(rex.Describe());

public class Animal
{
    public string Name { get; set; }

    public string Describe()
    {
        return "Zviera: " + Name;
    }
}

public class Dog : Animal
{
    public string Name { get; set; }
}
