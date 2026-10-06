// ===== 06 – Pravdivostné tabuľky =====
// Ukáž:       tabuľky všetkých kombinácií. Žiaci si ich môžu prepísať do zošita.
// Skús:       pozri, v ktorých riadkoch sa AND a OR líšia.

Console.WriteLine("x     | y     | x AND y | x OR y");
Console.WriteLine("------+-------+---------+-------");
PrintRow(true, true);
PrintRow(true, false);
PrintRow(false, true);
PrintRow(false, false);

Console.WriteLine();
Console.WriteLine("x     | NOT x");
Console.WriteLine("------+------");
Console.WriteLine(true.ToString().PadRight(5) + " | " + !true);
Console.WriteLine(false.ToString().PadRight(5) + " | " + !false);

static void PrintRow(bool x, bool y)
{
    Console.WriteLine(x.ToString().PadRight(5) + " | " + y.ToString().PadRight(5) + " | " + (x && y).ToString().PadRight(7) + " | " + (x || y));
}
