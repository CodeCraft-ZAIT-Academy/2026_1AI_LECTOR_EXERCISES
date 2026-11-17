// Úloha 28: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   1

List<int> numbers = new List<int> { 2, 4, 6, 1 };
for (int i = 0; i < numbers.Count; i++)
{
    if (numbers[i] % 2 == 0)
    {
        numbers.RemoveAt(i);
    }
}
Console.WriteLine(string.Join(", ", numbers));
