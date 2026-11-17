// Úloha 23: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Zdravie hrdinu: 100
//   Zdravie prisery: 35

Hero hero = new Hero { Name = "Aragorn" };
Monster ork = new Monster { Name = "Ork" };

hero.Attack(ork);
Console.WriteLine("Zdravie hrdinu: " + hero.Health);
Console.WriteLine("Zdravie prisery: " + ork.Health);

public class Hero
{
    public string Name { get; set; }
    public int Health { get; set; } = 100;
    public int AttackPower { get; set; } = 15;

    public void Attack(Monster target)
    {
        Health = Health - AttackPower;
    }
}

public class Monster
{
    public string Name { get; set; }
    public int Health { get; set; } = 50;
}
