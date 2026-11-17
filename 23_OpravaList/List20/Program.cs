// Úloha 20: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   5, 10, 15, 20

List<int> numbers = new List<int> { 5, 10, 15 };
numbers.Insert(5, 20);
Console.WriteLine(string.Join(", ", numbers));
