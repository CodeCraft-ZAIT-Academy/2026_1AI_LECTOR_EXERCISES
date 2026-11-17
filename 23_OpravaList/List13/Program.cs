// Úloha 13: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   2, 4, 6, 9

List<int> numbers = new List<int> { 4, 2, 9, 6 };
List<int> sorted = numbers.Sort();
Console.WriteLine(string.Join(", ", sorted));
