// Úloha 19: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   5
//   0

// GetLength má vrátiť počet prvkov poľa.
Console.WriteLine(GetLength(new int[] { 10, 20, 30, 40, 50 }));
Console.WriteLine(GetLength(new int[0]));

static int GetLength(int[] array)
{
    return array.Length - 1;
}
