// Úloha 20: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   A
//   B
//   B
//   C
//   Invalid

// 90 % a viac = A, 80 – 89,99 % = B, 70 – 79,99 % = C, inak F. Mimo 0 – 100 = Invalid.
Console.WriteLine(GetGrade(95));
Console.WriteLine(GetGrade(85));
Console.WriteLine(GetGrade(89.5));
Console.WriteLine(GetGrade(70));
Console.WriteLine(GetGrade(120));

static string GetGrade(double percent)
{
    if (percent < 0 || percent > 100)
    {
        return "Invalid";
    }
    else if (percent >= 90)
    {
        return "A";
    }
    else if (percent >= 80 && percent <= 89)
    {
        return "B";
    }
    else if (percent >= 70 && percent <= 79)
    {
        return "C";
    }
    else
    {
        return "F";
    }
}
