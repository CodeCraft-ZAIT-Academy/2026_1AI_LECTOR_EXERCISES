// Úloha 21: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Grok: zdravie 50
//   Merlin: mana 30

Wizard merlin = new Wizard { Name = "Merlin" };
Orc grok = new Orc { Name = "Grok", Health = 100 };

merlin.CastSpell(grok);
merlin.CastSpell(grok);

Console.WriteLine("Grok: zdravie " + grok.Health);
Console.WriteLine("Merlin: mana " + merlin.Mana);

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;
}

public class Wizard : Character
{
    public int Mana { get; set; } = 50;

    public void CastSpell(Character target)
    {
        int cost = 10;
        target.Health = target.Health - 25;
    }
}

public class Orc : Character
{
}
