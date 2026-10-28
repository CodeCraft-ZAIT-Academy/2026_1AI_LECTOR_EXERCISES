// Úloha 10: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   6

int[] numbers = { 1, 2, 3 };
int sum;
for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}
Console.WriteLine(sum);
