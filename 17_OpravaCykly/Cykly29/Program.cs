// Úloha 29: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   5, 4, 3, 2, 1

// Obráť poradie prvkov poľa: 5, 4, 3, 2, 1.
int[] items = { 1, 2, 3, 4, 5 };
for (int i = 0; i < items.Length; i++)
{
    int temp = items[i];
    items[i] = items[items.Length - 1 - i];
    items[items.Length - 1 - i] = temp;
}
Console.WriteLine(string.Join(", ", items));
