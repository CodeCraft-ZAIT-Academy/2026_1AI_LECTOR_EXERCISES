// Úloha 24: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   9, 6, 4, 2

List<int> numbers = new List<int> { 4, 2, 9, 6 };
numbers.Sort();
Console.WriteLine(string.Join(", ", numbers));
