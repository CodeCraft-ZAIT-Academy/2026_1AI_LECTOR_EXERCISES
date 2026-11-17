// Úloha 29: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Anna je dospela: True

Person anna = new Person { Name = "Anna", Age = 18 };
Console.WriteLine(anna.Name + " je dospela: " + anna.IsAdult());

public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public bool IsAdult()
    {
        return Age > 18;
    }
}
