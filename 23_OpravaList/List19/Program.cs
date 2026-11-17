// Úloha 19: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   5, 15

List<int> numbers = new List<int> { 5, 10, 15 };
numbers.RemoveAt(10);
Console.WriteLine(string.Join(", ", numbers));
