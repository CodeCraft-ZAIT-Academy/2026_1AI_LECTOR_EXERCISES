// ===== 16 – Bonusové cvičenia z lekcie (vyžadujú cykly) =====
// Pozor: riešenia používajú cyklus for, ktorý sa preberá až v AppsLab-016.
// Použi ich pre rýchlejších žiakov alebo po lekcii Cykly. Postup: najprv skús vlastné riešenie.

int[] numbers = { 3, 8, 15, 4, 42, 7, 10 };

// 1. Párne a nepárne čísla
(int[] even, int[] odd) = SplitEvenOdd(numbers);
Console.WriteLine("Párne:   " + string.Join(", ", even));
Console.WriteLine("Nepárne: " + string.Join(", ", odd));

// 2. Hľadanie prvku
Console.WriteLine("Contains(15): " + ContainsNumber(numbers, 15));
Console.WriteLine("Contains(99): " + ContainsNumber(numbers, 99));

// 3. Súčet čísel v poli
Console.WriteLine("Súčet: " + Sum(numbers));

// 4. Najväčší prvok
Console.WriteLine("Najväčší: " + Max(numbers));

// 5. Konkatenácia reťazcov
string[] words = { "Ahoj", " ", "svet", "!" };
Console.WriteLine("Spojené: " + Concatenate(words));

static (int[] even, int[] odd) SplitEvenOdd(int[] numbers)
{
    // najprv spočítame párne čísla, aby sme vedeli veľkosti polí
    int evenCount = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            evenCount++;
        }
    }

    int[] even = new int[evenCount];
    int[] odd = new int[numbers.Length - evenCount];
    int evenIndex = 0;
    int oddIndex = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] % 2 == 0)
        {
            even[evenIndex] = numbers[i];
            evenIndex++;
        }
        else
        {
            odd[oddIndex] = numbers[i];
            oddIndex++;
        }
    }

    return (even, odd);
}

static bool ContainsNumber(int[] numbers, int value)
{
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] == value)
        {
            return true;
        }
    }

    return false;
}

static int Sum(int[] numbers)
{
    int sum = 0;
    for (int i = 0; i < numbers.Length; i++)
    {
        sum = sum + numbers[i];
    }

    return sum;
}

static int Max(int[] numbers)
{
    int max = numbers[0];
    for (int i = 1; i < numbers.Length; i++)
    {
        if (numbers[i] > max)
        {
            max = numbers[i];
        }
    }

    return max;
}

static string Concatenate(string[] words)
{
    string result = "";
    for (int i = 0; i < words.Length; i++)
    {
        result = result + words[i];
    }

    return result;
}
