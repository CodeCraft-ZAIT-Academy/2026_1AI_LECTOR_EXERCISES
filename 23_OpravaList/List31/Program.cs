// Úloha 31: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Maximum: -2

List<int> numbers = new List<int> { -5, -2, -9 };
int max = 0;
foreach (int number in numbers)
{
    if (number > max)
    {
        max = number;
    }
}
Console.WriteLine("Maximum: " + max);
