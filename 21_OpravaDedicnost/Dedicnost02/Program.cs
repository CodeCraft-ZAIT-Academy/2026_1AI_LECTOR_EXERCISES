// Úloha 2: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Merlin, mana 50

Wizard merlin = new Wizard();
merlin.Name = "Merlin";
merlin.Mana = 50;
Console.WriteLine(merlin.Name + ", mana " + merlin.Mana);

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;
}

public class Wizard
{
    public int Mana { get; set; }
}
