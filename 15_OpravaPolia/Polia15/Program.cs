// Úloha 15: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   20
//   0
//   0

// Pre neplatnú pozíciu (mimo poľa) má metóda vrátiť 0.
int[] numbers = { 10, 20, 30 };
Console.WriteLine(GetElementAtPosition(numbers, 1));
Console.WriteLine(GetElementAtPosition(numbers, -1));
Console.WriteLine(GetElementAtPosition(numbers, 5));

static int GetElementAtPosition(int[] array, int position)
{
    if (position >= array.Length)
    {
        return 0;
    }

    return array[position];
}
