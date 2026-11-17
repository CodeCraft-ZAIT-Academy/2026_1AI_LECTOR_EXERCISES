// Úloha 26: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   5, 20, 10, 15

List<int> numbers = new List<int> { 5, 10, 15 };
numbers.Insert(0, 20);
Console.WriteLine(string.Join(", ", numbers));
