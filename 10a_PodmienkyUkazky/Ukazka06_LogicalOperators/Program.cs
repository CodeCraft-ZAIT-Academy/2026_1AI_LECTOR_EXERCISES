// ===== 06 – Logické operátory && || ! =====
// Ukáž:       && = obe pravdivé, || = aspoň jedna pravdivá, ! = obráti hodnotu.
// Skús zmeniť: hodnoty a, b; potom age a hasParentConsent v druhej časti.

bool a = true;
bool b = false;

Console.WriteLine("a && b = " + (a && b));
Console.WriteLine("a || b = " + (a || b));
Console.WriteLine("!a     = " + !a);
Console.WriteLine("!b     = " + !b);

// Pravdivostná tabuľka – všetky 4 kombinácie
Console.WriteLine();
Console.WriteLine("x     | y     | x AND y | x OR y");
PrintRow(true, true);
PrintRow(true, false);
PrintRow(false, true);
PrintRow(false, false);

// Praktický príklad
Console.WriteLine();
int age = 17;
bool hasParentConsent = true;

if (age >= 18 || hasParentConsent)
{
    Console.WriteLine("You can enter.");
}
else
{
    Console.WriteLine("You cannot enter.");
}

static void PrintRow(bool x, bool y)
{
    Console.WriteLine(x.ToString().PadRight(5) + " | " + y.ToString().PadRight(5) + " | " + (x && y).ToString().PadRight(7) + " | " + (x || y));
}
