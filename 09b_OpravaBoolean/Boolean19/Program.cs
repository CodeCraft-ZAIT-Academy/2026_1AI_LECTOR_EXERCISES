// Úloha 19: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   True
//   True
//   True
//   False

// Odpoveď "yes" môže byť zapísaná aj ako "Yes" alebo "YES".
Console.WriteLine(IsYes("Yes"));
Console.WriteLine(IsYes("yes"));
Console.WriteLine(IsYes("YES"));
Console.WriteLine(IsYes("no"));

static bool IsYes(string answer)
{
    return answer == "yes";
}
