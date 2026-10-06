// Úloha 23: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   False
//   True
//   False

// Cvičenie z lekcie: And = a && b, Or = a || b, Not = !a.
Console.WriteLine(And(true, false));
Console.WriteLine(Or(true, false));
Console.WriteLine(Not(true));

static bool And(bool a, bool b)
{
    return a || b;
}

static bool Or(bool a, bool b)
{
    return a && b;
}

static bool Not(bool a)
{
    return a;
}
