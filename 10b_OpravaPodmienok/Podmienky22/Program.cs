// Úloha 22: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   False
//   True
//   True

Console.WriteLine(IsWeekend("Monday"));
Console.WriteLine(IsWeekend("Saturday"));
Console.WriteLine(IsWeekend("Sunday"));

static bool IsWeekend(string day)
{
    if (day == "Saturday" && day == "Sunday")
    {
        return true;
    }
    return false;
}
