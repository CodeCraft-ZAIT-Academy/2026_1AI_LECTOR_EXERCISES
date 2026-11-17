// ===== DEDIČNOSŤ 10 – RPG bitka =====
// Pojmy: parameter základného typu prijme aj odvodené objekty, Battle sa nemusí meniť
// Skús zmeniť:
//   1. Zmeň silu útoku orka. Vyhrá čarodej?
//   2. Pridaj triedu Elf : Character a nechaj ju bojovať s orkom. Musíš zmeniť Battle?
//   3. V lekcii bola bitka Character vs Enemy. Prečo už Enemy nepotrebujeme?

Wizard merlin = new Wizard { Name = "Merlin", Health = 80, AttackPower = 25 };
Orc grok = new Orc { Name = "Grok", Health = 100, AttackPower = 20 };

Battle battle = new Battle();
battle.Fight(merlin, grok);

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;
    public int AttackPower { get; set; } = 10;

    public void Attack(Character target)
    {
        target.Health = target.Health - AttackPower;
        Console.WriteLine(Name + " zautocil, " + target.Name + " ma " + target.Health + " zdravia");
    }
}

public class Wizard : Character
{
    public int Mana { get; set; } = 50;
}

public class Orc : Character
{
    public int Rage { get; set; }
}

public class Battle
{
    // Pracuje s typom Character, takže zvládne akékoľvek dve postavy
    public void Fight(Character first, Character second)
    {
        int round = 1;
        while (first.Health > 0 && second.Health > 0)
        {
            Console.WriteLine("--- Kolo " + round + " ---");
            first.Attack(second);
            if (second.Health > 0)
            {
                second.Attack(first);
            }
            round++;
        }

        if (first.Health > 0)
        {
            Console.WriteLine("Vyhral " + first.Name + "!");
        }
        else
        {
            Console.WriteLine("Vyhral " + second.Name + "!");
        }
    }
}
