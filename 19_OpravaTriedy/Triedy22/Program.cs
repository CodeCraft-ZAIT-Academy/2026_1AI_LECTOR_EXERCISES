// Úloha 22: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex ma 4 roky

Dog myDog = new Dog { Name = "Rex", Age = 3 };
myDog.Birthday();
Console.WriteLine(myDog.Name + " ma " + myDog.Age + " roky");

public class Dog
{
    public string Name { get; set; }
    public int Age { get; set; }

    public void Birthday()
    {
        int newAge = Age + 1;
    }
}
