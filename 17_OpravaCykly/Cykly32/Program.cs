// Úloha 32: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   2, 4, 6

// Zdvojnásob všetky prvky poľa: 2, 4, 6.
int[] numbers = { 1, 2, 3 };
foreach (int number in numbers)
{
    int doubled = number * 2;
}
Console.WriteLine(string.Join(", ", numbers));
