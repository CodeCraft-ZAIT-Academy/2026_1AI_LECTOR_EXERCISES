// Úloha 17: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Vo vrecku je poloziek: 2

Backpack backpack = new Backpack();
backpack.Items.Add("Jablko");
backpack.Items.Add("Voda");
Console.WriteLine("Vo vrecku je poloziek: " + backpack.Items.Count);

public class Backpack
{
    public List<string> Items { get; set; }
}
