// ===== 08 – Referenčné riešenie cvičenia: ArrayProcessor =====
// V lekcii sú metódy v triede ArrayProcessor. Tu sú zapísané ako obyčajné metódy v Program.cs.
// Ukáž:       pole môžeme poslať do metódy ako parameter (int[] array). Prázdne pole musíme ošetriť.
// Skús zmeniť: pole, pozície a prázdne pole. Čo vráti GetElementAtPosition pre neplatnú pozíciu?

int[] numbers = { 10, 20, 30, 40, 50 };
int[] empty = new int[0];

Console.WriteLine("GetFirstElement(numbers):          " + GetFirstElement(numbers));
Console.WriteLine("GetLastElement(numbers):           " + GetLastElement(numbers));
Console.WriteLine("GetElementAtPosition(numbers, 2):  " + GetElementAtPosition(numbers, 2));
Console.WriteLine("GetElementAtPosition(numbers, 9):  " + GetElementAtPosition(numbers, 9));
Console.WriteLine("GetLength(numbers):                " + GetLength(numbers));
Console.WriteLine();
Console.WriteLine("GetFirstElement(empty):            " + GetFirstElement(empty));
Console.WriteLine("GetLastElement(empty):             " + GetLastElement(empty));
Console.WriteLine("GetLength(empty):                  " + GetLength(empty));

static int GetFirstElement(int[] array)
{
    if (array.Length == 0)
    {
        return 0;
    }

    return array[0];
}

static int GetLastElement(int[] array)
{
    if (array.Length == 0)
    {
        return 0;
    }

    return array[array.Length - 1];
}

static int GetElementAtPosition(int[] array, int position)
{
    // Neplatná pozícia (mimo poľa) alebo prázdne pole: vrátime 0
    if (position < 0 || position >= array.Length)
    {
        return 0;
    }

    return array[position];
}

static int GetLength(int[] array)
{
    return array.Length;
}
