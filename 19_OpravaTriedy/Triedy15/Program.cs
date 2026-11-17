// Úloha 15: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Rex
//   Max
//   Bela

Dog[] dogs = new Dog[3];
dogs[0].Name = "Rex";
dogs[1].Name = "Max";
dogs[2].Name = "Bela";

foreach (Dog d in dogs)
{
    Console.WriteLine(d.Name);
}

public class Dog
{
    public string Name { get; set; }
}
