// Úloha 14: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   2, 4, 6

List<int> numbers = new List<int> { 1, 2, 3 };
foreach (int number in numbers)
{
    number = number * 2;
}
Console.WriteLine(string.Join(", ", numbers));
