// Úloha 34: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Pocet: 3
//   10, 20, 30

List<int> numbers = new List<int>();
for (int i = 1; i <= 3; i++)
{
    numbers = new List<int>();
    numbers.Add(i * 10);
}
Console.WriteLine("Pocet: " + numbers.Count);
Console.WriteLine(string.Join(", ", numbers));
