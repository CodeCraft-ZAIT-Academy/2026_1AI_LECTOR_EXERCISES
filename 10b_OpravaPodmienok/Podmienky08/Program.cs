// Úloha 8: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   passed
//   failed

Console.WriteLine(GetResult(70));
Console.WriteLine(GetResult(30));

static string GetResult(int points)
{
    if (points >= 50)
    {
        return "passed";
    }
    else if (points < 50)
    {
        return "failed";
    }
}
