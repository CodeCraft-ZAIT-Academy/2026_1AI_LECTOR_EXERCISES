// Úloha 13: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   True
//   False
//   False

// Hráč smie vstúpiť, ak má aspoň 15 rokov A ZÁROVEŇ neprázdne meno.
Console.WriteLine(CanEnter("Anna", 20));
Console.WriteLine(CanEnter("Anna", 14));
Console.WriteLine(CanEnter("", 20));

static bool CanEnter(string name, int age)
{
    return age >= 15 || name != "";
}
