// ===== 10 – Polia a cykly spolu =====
// Ukáž:       cykly a polia patria k sebe: for s indexom vie pole PLNIŤ aj MENIŤ, foreach len čítať.
// Skús zmeniť: veľkosť poľa squares; hodnoty v numbers.

// Naplnenie poľa druhými mocninami
int[] squares = new int[6];
for (int i = 0; i < squares.Length; i++)
{
    squares[i] = i * i;
}
Console.WriteLine("Druhé mocniny: " + string.Join(", ", squares));

// Zdvojnásobenie prvkov: musíme použiť for (foreach prvky meniť nevie)
int[] numbers = { 1, 2, 3, 4, 5 };
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i] * 2;
}
Console.WriteLine("Zdvojnásobené: " + string.Join(", ", numbers));

// Obrátenie poradia (bonus z lekcie): vymieňame prvý s posledným, druhý s predposledným...
int[] items = { 1, 2, 3, 4, 5 };
for (int i = 0; i < items.Length / 2; i++)
{
    int temp = items[i];
    items[i] = items[items.Length - 1 - i];
    items[items.Length - 1 - i] = temp;
}
Console.WriteLine("Obrátené: " + string.Join(", ", items));

// Súčet párnych a nepárnych (bonus z lekcie)
int[] mixed = { 3, 8, 15, 4, 42, 7, 10 };
int evenSum = 0;
int oddSum = 0;
foreach (int number in mixed)
{
    if (number % 2 == 0)
    {
        evenSum += number;
    }
    else
    {
        oddSum += number;
    }
}
Console.WriteLine("Súčet párnych: " + evenSum + ", nepárnych: " + oddSum);
