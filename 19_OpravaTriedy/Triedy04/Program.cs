// Úloha 4: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex ma 3 roky

Dog myDog = new Dog();
myDog.Name = "Rex";
myDog.Age = "3";
Console.WriteLine(myDog.Name + " ma " + myDog.Age + " roky");

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }
}
