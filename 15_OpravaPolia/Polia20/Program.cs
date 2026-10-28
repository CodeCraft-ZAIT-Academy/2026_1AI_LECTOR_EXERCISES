// Úloha 20: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   20, 10, 30

// Vymeň prvý a druhý prvok poľa.
int[] numbers = { 10, 20, 30 };
numbers[0] = numbers[1];
numbers[1] = numbers[0];
Console.WriteLine(string.Join(", ", numbers));
