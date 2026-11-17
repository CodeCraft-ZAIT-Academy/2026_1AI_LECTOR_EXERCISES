// ===== LIST 06 – Prechádzanie listu =====
// Pojmy: foreach, for, ForEach(Console.WriteLine), string.Join
// Skús zmeniť:
//   1. Vypíš zoznam odzadu pomocou for (od Count - 1 do 0).
//   2. Vypíš len čísla väčšie ako 10.
//   3. Vypíš každé číslo s jeho indexom: "0: 5".

List<int> numbers = new List<int> { 5, 10, 15, 20 };

Console.WriteLine("--- foreach ---");
foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("--- for ---");
for (int i = 0; i < numbers.Count; i++)
{
    Console.WriteLine(i + ": " + numbers[i]);
}

Console.WriteLine("--- ForEach (z lekcie) ---");
numbers.ForEach(Console.WriteLine);

Console.WriteLine("--- string.Join ---");
Console.WriteLine(string.Join(", ", numbers));
