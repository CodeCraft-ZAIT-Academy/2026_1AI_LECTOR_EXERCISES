// Úloha 17: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Merlin nesie veci: 2

Wizard merlin = new Wizard { Name = "Merlin" };
merlin.Items.Add("Palica");
merlin.Items.Add("Kniha kuziel");
Console.WriteLine(merlin.Name + " nesie veci: " + merlin.Items.Count);

public class Character
{
    public string Name { get; set; }
    public List<string> Items { get; set; }
}

public class Wizard : Character
{
    public int Mana { get; set; } = 50;
}
