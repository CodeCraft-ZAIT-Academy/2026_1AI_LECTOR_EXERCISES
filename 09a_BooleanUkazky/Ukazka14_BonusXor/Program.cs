// ===== 14 – Bonus 3: XOR (vylučovacie alebo) =====
// Ukáž:       XOR je true, len ak je PRÁVE JEDNA hodnota true. V C# sa zapisuje ^, ale zvládneme ho aj bez neho.
//             Tri zápisy, ktoré dávajú rovnaké výsledky.

Console.WriteLine("a     | b     | a != b | a ^ b | (a || b) && !(a && b)");
Console.WriteLine("------+-------+--------+-------+----------------------");
Show(true, true);
Show(true, false);
Show(false, true);
Show(false, false);

static void Show(bool a, bool b)
{
    bool xor1 = a != b;
    bool xor2 = a ^ b;
    bool xor3 = (a || b) && !(a && b);

    Console.WriteLine(a.ToString().PadRight(5) + " | " + b.ToString().PadRight(5) + " | " +
                      xor1.ToString().PadRight(6) + " | " + xor2.ToString().PadRight(5) + " | " + xor3);
}
