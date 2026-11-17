// Úloha 16: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Aragorn drzi Mec (12)

Hero hero = new Hero();
hero.Name = "Aragorn";
hero.Weapon.Name = "Mec";
hero.Weapon.Damage = 12;
Console.WriteLine(hero.Name + " drzi " + hero.Weapon.Name + " (" + hero.Weapon.Damage + ")");

public class Weapon
{
    public string Name { get; set; }
    public int Damage { get; set; }
}

public class Hero
{
    public string Name { get; set; }
    public Weapon Weapon { get; set; }
}
