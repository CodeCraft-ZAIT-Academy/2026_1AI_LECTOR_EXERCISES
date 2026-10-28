// Úloha 13: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   1, 4, 9, 16, 25

// Naplň pole druhými mocninami čísel 1 až 5.
int[] squares = new int[5];
for (int i = 1; i <= 5; i++)
{
    squares[i] = i * i;
}
Console.WriteLine(string.Join(", ", squares));
