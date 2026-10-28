// Úloha 17: Oprav program tak, aby fungoval správne.
// Pozor: program sa môže zaseknúť (nekonečný cyklus). Zastav ho: Shift+F5 (ladenie) alebo Ctrl+C (konzola).
// Očakávaný výstup:
//   6

// Ciferný súčet: 1 + 2 + 3 = 6.
Console.WriteLine(DigitSum(123));

static int DigitSum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        sum += number % 10;
    }

    return sum;
}
