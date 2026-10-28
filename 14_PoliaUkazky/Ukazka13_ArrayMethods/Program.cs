// ===== 13 – Užitočné metódy triedy Array =====
// Ukáž:       trieda Array má hotové metódy na prácu s celým poľom (bez cyklov).
// Skús zmeniť: čísla v poli; hľadanú hodnotu v Array.IndexOf.

int[] numbers = { 40, 10, 30, 20, 50 };
Console.WriteLine("Pôvodné:   " + string.Join(", ", numbers));

Console.WriteLine("IndexOf 30: " + Array.IndexOf(numbers, 30));   // 2
Console.WriteLine("IndexOf 99: " + Array.IndexOf(numbers, 99));   // -1 = nenájdené

Array.Sort(numbers);
Console.WriteLine("Zoradené:  " + string.Join(", ", numbers));

Array.Reverse(numbers);
Console.WriteLine("Otočené:   " + string.Join(", ", numbers));

int[] firstThree = new int[3];
Array.Copy(numbers, firstThree, 3);
Console.WriteLine("Prvé tri:  " + string.Join(", ", firstThree));

Array.Clear(numbers);
Console.WriteLine("Vymazané:  " + string.Join(", ", numbers));
