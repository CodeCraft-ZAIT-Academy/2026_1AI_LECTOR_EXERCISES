// ===== DEDIČNOSŤ 09 – RPG postavy =====
// Pojmy: základná trieda Character, odvodené Wizard a Orc, každá s vlastnými členmi
// Skús zmeniť:
//   1. Zmeň silu útoku čarodeja a predpovedz zdravie orka.
//   2. Pridaj triedu Elf : Character s vlastnosťou Arrows a metódou Shoot().
//   3. Všimni si, že parameter Attack je typu Character. Prečo tam môžeme dať aj Orc?

Wizard merlin = new Wizard { Name = "Merlin", AttackPower = 8 };
Orc grok = new Orc { Name = "Grok", AttackPower = 15, Health = 120 };

merlin.Attack(grok);
merlin.CastSpell(grok);
grok.Attack(merlin);
grok.Shout();
merlin.Heal();

Console.WriteLine("Merlin: zdravie " + merlin.Health + ", mana " + merlin.Mana);
Console.WriteLine("Grok: zdravie " + grok.Health + ", zurivost " + grok.Rage);

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;
    public int AttackPower { get; set; } = 10;

    public void Attack(Character target)
    {
        target.Health = target.Health - AttackPower;
        Console.WriteLine(Name + " zautocil na " + target.Name + " (-" + AttackPower + ")");
    }

    public void Heal()
    {
        Health = Health + 10;
        Console.WriteLine(Name + " sa vylieci (+10)");
    }
}

public class Wizard : Character
{
    public int Mana { get; set; } = 50;

    public void CastSpell(Character target)
    {
        Mana = Mana - 10;
        target.Health = target.Health - 25;
        Console.WriteLine(Name + " caruje na " + target.Name + " (-25)");
    }
}

public class Orc : Character
{
    public int Rage { get; set; }

    public void Shout()
    {
        Rage = Rage + 5;
        Console.WriteLine(Name + " reve: GRAAAH!");
    }
}
