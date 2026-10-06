// Úloha 12: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   kid
//   teenager
//   teenager
//   adult

Console.WriteLine(Describe(12));
Console.WriteLine(Describe(13));
Console.WriteLine(Describe(17));
Console.WriteLine(Describe(18));

static string Describe(int age)
{
    if (age > 18)
    {
        return "adult";
    }
    else if (age > 13)
    {
        return "teenager";
    }
    else
    {
        return "kid";
    }
}
