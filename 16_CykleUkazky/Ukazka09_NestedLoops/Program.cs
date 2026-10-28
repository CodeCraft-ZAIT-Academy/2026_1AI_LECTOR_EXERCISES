// ===== 09 – Odpočítavanie a vnorené cykly =====
// Ukáž:       cyklus môže byť aj vnútri iného cyklu. Vonkajší cyklus = riadky, vnútorný = stĺpce.
//             (Mimo lekcie – pre rýchlejších žiakov.)
// Skús zmeniť: počet riadkov trojuholníka; veľkosť násobilky.

// Odpočítavanie (bonus z lekcie)
for (int i = 5; i >= 1; i--)
{
    Console.Write(i + " ");
}
Console.WriteLine("Štart!");

// Trojuholník z hviezdičiek
Console.WriteLine();
for (int row = 1; row <= 4; row++)
{
    string line = "";
    for (int column = 1; column <= row; column++)
    {
        line += "*";
    }
    Console.WriteLine(line);
}

// Malá násobilka 4 x 4
Console.WriteLine();
for (int a = 1; a <= 4; a++)
{
    string line = "";
    for (int b = 1; b <= 4; b++)
    {
        line += (a * b).ToString().PadLeft(4);
    }
    Console.WriteLine(line);
}
