// Úloha 27: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   2, 3

List<int> numbers = new List<int> { 1, 2, 1, 3, 1 };
numbers.Remove(1);
Console.WriteLine(string.Join(", ", numbers));
