// ===== TRIEDY 13 – Dve triedy spolu (hrdina a príšera) =====
// Pojmy: metóda s parametrom typu inej triedy, objekty sa „rozprávajú“ navzájom
// Skús zmeniť:
//   1. Zmeň silu útoku hrdinu a predpovedz zdravie príšery.
//   2. Pridaj ďalší útok hrdinu a príšery.
//   3. Pridaj druhú príšeru (vlk) a napadni ju.

Hero hero = new Hero { Name = "Aragorn" };
Monster ork = new Monster { Name = "Ork" };

hero.Attack(ork);
ork.Attack(hero);
hero.Attack(ork);
ork.Attack(hero);

Console.WriteLine("Zdravie hrdinu: " + hero.Health);
Console.WriteLine("Zdravie prisery: " + ork.Health);

public class Hero
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;
    public int AttackPower { get; set; } = 15;

    public void Attack(Monster target)
    {
        target.Health = target.Health - AttackPower;
        Console.WriteLine(Name + " zautocil na " + target.Name + " (-" + AttackPower + ")");
    }
}

public class Monster
{
    public string Name { get; set; }
    public int Health { get; set; } = 50;
    public int AttackPower { get; set; } = 8;

    public void Attack(Hero target)
    {
        target.Health = target.Health - AttackPower;
        Console.WriteLine(Name + " zautocil na " + target.Name + " (-" + AttackPower + ")");
    }
}
