// ===== 13 – Bonus 2: aspoň dve z troch hodnôt sú true =====
// Ukáž:       skladanie viacerých boolov. Existujú tri páry (a,b), (a,c), (b,c) – stačí, aby bol pravdivý aspoň jeden.
// Skús:       skontroluj všetkých osem kombinácií (2 x 2 x 2).

Console.WriteLine("t t t -> " + AtLeastTwo(true, true, true));
Console.WriteLine("t t f -> " + AtLeastTwo(true, true, false));
Console.WriteLine("t f t -> " + AtLeastTwo(true, false, true));
Console.WriteLine("t f f -> " + AtLeastTwo(true, false, false));
Console.WriteLine("f t t -> " + AtLeastTwo(false, true, true));
Console.WriteLine("f t f -> " + AtLeastTwo(false, true, false));
Console.WriteLine("f f t -> " + AtLeastTwo(false, false, true));
Console.WriteLine("f f f -> " + AtLeastTwo(false, false, false));

static bool AtLeastTwo(bool a, bool b, bool c)
{
    return (a && b) || (a && c) || (b && c);
}
