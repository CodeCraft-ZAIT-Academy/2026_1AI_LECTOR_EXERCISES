// ===== 09 – Referenčné riešenie cvičenia: And, Or, Not =====
// V lekcii sú metódy v triede BooleanLogic. Tu sú rovnaké metódy zapísané ako metódy v Program.cs.
// Ukáž:       metóda vracia bool, výsledok je priamo hodnota výrazu (return a && b;).
// Skús zmeniť: argumenty pri volaní.

Console.WriteLine("And(true, true)   = " + And(true, true));
Console.WriteLine("And(true, false)  = " + And(true, false));
Console.WriteLine("And(false, true)  = " + And(false, true));
Console.WriteLine("And(false, false) = " + And(false, false));

Console.WriteLine();
Console.WriteLine("Or(true, true)    = " + Or(true, true));
Console.WriteLine("Or(true, false)   = " + Or(true, false));
Console.WriteLine("Or(false, true)   = " + Or(false, true));
Console.WriteLine("Or(false, false)  = " + Or(false, false));

Console.WriteLine();
Console.WriteLine("Not(true)         = " + Not(true));
Console.WriteLine("Not(false)        = " + Not(false));

static bool And(bool a, bool b)
{
    return a && b;
}

static bool Or(bool a, bool b)
{
    return a || b;
}

static bool Not(bool a)
{
    return !a;
}
