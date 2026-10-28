// Úloha 26: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   1
//   2
//   3
//   4
//   6
//   7
//   8
//   9
//   10

// Vypíš čísla 1 až 10, okrem čísla 5.
for (int i = 1; i <= 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}
