// Úloha 14: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   5
//   4
//   3
//   2
//   1

// Vypíš pole odzadu.
int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = numbers.Length; i > 0; i--)
{
    Console.WriteLine(numbers[i]);
}
