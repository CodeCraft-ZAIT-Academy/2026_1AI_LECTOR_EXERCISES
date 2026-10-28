// Úloha 25: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   True
//   True
//   False

// ContainsNumber vráti true, ak sa číslo v poli nachádza.
int[] numbers = { 10, 20, 30, 40, 50 };
Console.WriteLine(ContainsNumber(numbers, 10));
Console.WriteLine(ContainsNumber(numbers, 30));
Console.WriteLine(ContainsNumber(numbers, 99));

static bool ContainsNumber(int[] array, int value)
{
    return Array.IndexOf(array, value) > 0;
}
