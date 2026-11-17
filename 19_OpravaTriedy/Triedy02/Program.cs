// Úloha 2: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex 3

Dog myDog = Dog();
myDog.Name = "Rex";
myDog.Age = 3;
Console.WriteLine(myDog.Name + " " + myDog.Age);

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}
