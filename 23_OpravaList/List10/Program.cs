// Úloha 10: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   5, 20, 10

List<int> numbers = new List<int> { 5, 10 };
numbers.Insert(20);
Console.WriteLine(string.Join(", ", numbers));
