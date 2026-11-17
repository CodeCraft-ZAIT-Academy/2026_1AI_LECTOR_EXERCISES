// Úloha 18: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   1, 3, 5

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        numbers.Remove(number);
    }
}
Console.WriteLine(string.Join(", ", numbers));
