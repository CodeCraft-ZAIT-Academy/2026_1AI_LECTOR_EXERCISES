// Úloha 28: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Bez mena (0)

Dog rex = new Dog { Name = "Rex", Age = 3 };
Reset(rex);
Console.WriteLine(rex.Name + " (" + rex.Age + ")");

static void Reset(Dog dog)
{
    dog = new Dog();
    dog.Name = "Bez mena";
    dog.Age = 0;
}

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}
