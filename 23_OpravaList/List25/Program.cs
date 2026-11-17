// Úloha 25: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Povodne: 4, 2, 9, 6
//   Zoradene: 2, 4, 6, 9

List<int> numbers = new List<int> { 4, 2, 9, 6 };
List<int> sorted = numbers;
sorted.Sort();

Console.WriteLine("Povodne: " + string.Join(", ", numbers));
Console.WriteLine("Zoradene: " + string.Join(", ", sorted));
