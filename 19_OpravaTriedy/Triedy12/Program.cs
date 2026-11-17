// Úloha 12: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Anna ma 30 rokov

Person anna = new Person(30, "Anna");
Console.WriteLine(anna.Name + " ma " + anna.Age + " rokov");

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public Person(string name, int age)
    {
        Name = name;
        Age = age;
    }
}
