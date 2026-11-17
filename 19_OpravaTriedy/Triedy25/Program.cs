// Úloha 25: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Aragorn, zdravie: 100
//   Zije? True

Hero hero = new Hero { Name = "Aragorn" };
Console.WriteLine(hero.Name + ", zdravie: " + hero.Health);
Console.WriteLine("Zije? " + hero.IsAlive());

public class Hero
{
    public string Name { get; set; }
    public int Health { get; set; }

    public bool IsAlive()
    {
        return Health > 0;
    }
}
