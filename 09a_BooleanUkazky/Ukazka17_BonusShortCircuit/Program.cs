// ===== 17 – Bonus: skrátené vyhodnocovanie (short-circuit) =====
// Ukáž:       && a || nevyhodnotia pravú stranu, ak je výsledok jasný už z ľavej.
//             Metóda Check vypíše správu, takže vidíme, či bola zavolaná.
//             Operátory & a | vyhodnotia vždy obe strany.

bool yes = true;
bool no = false;

Console.WriteLine("no && Check(A):");
bool r1 = no && Check("A");          // ľavá je false, výsledok je jasný, Check sa NEZAVOLÁ
Console.WriteLine("  -> " + r1);

Console.WriteLine("yes && Check(B):");
bool r2 = yes && Check("B");         // ľavá je true, treba pozrieť aj pravú
Console.WriteLine("  -> " + r2);

Console.WriteLine("yes || Check(C):");
bool r3 = yes || Check("C");         // ľavá je true, výsledok je jasný, Check sa NEZAVOLÁ
Console.WriteLine("  -> " + r3);

Console.WriteLine("no || Check(D):");
bool r4 = no || Check("D");          // ľavá je false, treba pozrieť aj pravú
Console.WriteLine("  -> " + r4);

Console.WriteLine("no & Check(E):");
bool r5 = no & Check("E");           // & vyhodnotí vždy obe strany
Console.WriteLine("  -> " + r5);

static bool Check(string name)
{
    Console.WriteLine("  Check " + name + " was called");
    return true;
}
