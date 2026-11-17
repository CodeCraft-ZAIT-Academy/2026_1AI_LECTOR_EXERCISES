// Úloha 7: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex 3

Dog myDog = new Dog("Rex");
Console.WriteLine(myDog.Name + " " + myDog.Age);

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Dog(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
