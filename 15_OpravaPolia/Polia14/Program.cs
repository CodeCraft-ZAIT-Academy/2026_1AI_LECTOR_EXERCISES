// Úloha 14: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   10
//   0

// Pre prázdne pole má metóda vrátiť 0.
Console.WriteLine(GetFirstElement(new int[] { 10, 20 }));
Console.WriteLine(GetFirstElement(new int[0]));

static int GetFirstElement(int[] array)
{
    return array[0];
}
