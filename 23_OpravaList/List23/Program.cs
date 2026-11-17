// Úloha 23: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   10, 30

List<int> numbers = new List<int> { 10, 20, 30 };
numbers.Remove(1);
Console.WriteLine(string.Join(", ", numbers));
