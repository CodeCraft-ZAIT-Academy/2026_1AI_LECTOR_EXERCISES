// Úloha 15: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   4
//   0

// Priemer prázdneho poľa má byť 0.
Console.WriteLine(Average(new int[] { 2, 4, 6 }));
Console.WriteLine(Average(new int[0]));

static int Average(int[] array)
{
    int sum = 0;
    foreach (int number in array)
    {
        sum += number;
    }

    return sum / array.Length;
}
