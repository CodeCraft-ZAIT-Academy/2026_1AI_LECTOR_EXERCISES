// ===== 03 – Cyklus foreach =====
// Ukáž:       foreach prejde všetky prvky poľa jeden po druhom, nepotrebuje index ani Length.
//             Keď potrebujeme index (poradie), použijeme for.
// Skús zmeniť: pole mien; pridaj ďalšie meno.

string[] names = { "John", "Jane", "Alex" };

foreach (string name in names)
{
    Console.WriteLine(name);
}

// for, keď potrebujeme poradie (index)
Console.WriteLine("--- s číslovaním");
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine((i + 1) + ". " + names[i]);
}

// foreach funguje aj na čísla a znaky
int[] numbers = { 10, 20, 30 };
int total = 0;
foreach (int number in numbers)
{
    total += number;
}
Console.WriteLine("Súčet: " + total);

foreach (char letter in "Hello")
{
    Console.Write(letter + "-");
}
Console.WriteLine();
