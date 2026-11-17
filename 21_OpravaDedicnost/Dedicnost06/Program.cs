// Úloha 6: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex 3

Dog rex = new Dog("Rex", 3);
Console.WriteLine(rex.Name + " " + rex.Age);

public class Animal
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Animal(string name, int age)
    {
        Name = name;
        Age = age;
    }
}

public class Dog : Animal
{
    public Dog(string name, int age) : base(age, name)
    {
    }
}
