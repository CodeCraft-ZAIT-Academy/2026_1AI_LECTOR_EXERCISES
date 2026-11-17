// ===== TRIEDY 16 – RPG bitka (úloha z lekcie AppsLab-020) =====
// Pojmy: tri triedy spolu, trieda Battle riadi priebeh, while cyklus s objektmi
// Skús zmeniť:
//   1. Zmeň silu útoku nepriateľa. Prežije hrdina?
//   2. Zmeň, ako často sa hrdina lieči (round % 3).
//   3. Všimni si, že Character a Enemy majú takmer rovnaký kód. Čo by sa dalo zjednodušiť? (Dedičnosť – ďalšia téma.)

Character hero = new Character { Name = "Aragorn", Health = 100, AttackPower = 20 };
Enemy enemy = new Enemy { Name = "Ork", Health = 80, AttackPower = 15 };

Battle battle = new Battle();
battle.Fight(hero, enemy);

public class Character
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public void Attack(Enemy enemy)
    {
        enemy.Health = enemy.Health - AttackPower;
        Console.WriteLine(Name + " zautocil, " + enemy.Name + " ma " + enemy.Health + " zdravia");
    }

    public void Heal()
    {
        Health = Health + 10;
        Console.WriteLine(Name + " sa vylieci, ma " + Health + " zdravia");
    }
}

public class Enemy
{
    public string Name { get; set; }
    public int Health { get; set; }
    public int AttackPower { get; set; }

    public void Attack(Character character)
    {
        character.Health = character.Health - AttackPower;
        Console.WriteLine(Name + " zautocil, " + character.Name + " ma " + character.Health + " zdravia");
    }
}

public class Battle
{
    public void Fight(Character hero, Enemy enemy)
    {
        int round = 1;
        while (hero.Health > 0 && enemy.Health > 0)
        {
            Console.WriteLine("--- Kolo " + round + " ---");
            hero.Attack(enemy);

            if (enemy.Health > 0)
            {
                enemy.Attack(hero);
            }

            if (round % 3 == 0)
            {
                hero.Heal();
            }
            round++;
        }

        if (hero.Health > 0)
        {
            Console.WriteLine("Vyhral " + hero.Name + "!");
        }
        else
        {
            Console.WriteLine("Vyhral " + enemy.Name + "!");
        }
    }
}
