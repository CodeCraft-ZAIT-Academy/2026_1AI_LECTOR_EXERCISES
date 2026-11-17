// ===== LIST 08 – Odstraňovanie v cykle =====
// Pojmy: zmena listu počas foreach = chyba, for odzadu pri RemoveAt
// Skús zmeniť:
//   1. Odkomentuj foreach a pozri chybu InvalidOperationException.
//   2. Prepíš cyklus tak, aby išiel od začiatku (i = 0; i++). Ktoré čísla ostanú v zozname?
//   3. Odstráň namiesto párnych čísel tie väčšie ako 4.

List<int> numbers = new List<int> { 1, 2, 4, 6, 7, 8 };
Console.WriteLine("Na zaciatku: " + string.Join(", ", numbers));

// foreach (int number in numbers)
// {
//     if (number % 2 == 0)
//     {
//         numbers.Remove(number);        // InvalidOperationException!
//     }
// }

// Odstraňujeme párne čísla: ideme ODZADU, aby sa nám indexy nepremiešali
for (int i = numbers.Count - 1; i >= 0; i--)
{
    if (numbers[i] % 2 == 0)
    {
        numbers.RemoveAt(i);
    }
}

Console.WriteLine("Po odstraneni parnych: " + string.Join(", ", numbers));
