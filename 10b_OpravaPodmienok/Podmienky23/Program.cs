// Úloha 23: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   3
//   5
//   9

// Do 1 kg vrátane: 3 €, do 5 kg vrátane: 5 €, nad 5 kg: 9 €.
Console.WriteLine(GetPostage(0.5));
Console.WriteLine(GetPostage(3));
Console.WriteLine(GetPostage(10));

static double GetPostage(double weight)
{
    if (weight > 0)
    {
        return 3;
    }
    else if (weight > 1)
    {
        return 5;
    }
    else
    {
        return 9;
    }
}
