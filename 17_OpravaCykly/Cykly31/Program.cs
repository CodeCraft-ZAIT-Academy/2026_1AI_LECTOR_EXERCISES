// Úloha 31: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   6

// Ciferný súčet: 1 + 2 + 3 = 6.
Console.WriteLine(DigitSum(123));

static int DigitSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number / 10;
        number /= 10;
    }

    return sum;
}
