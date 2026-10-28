// ===== 13 – Bonus: súčet čísel, kým nezadáš 0 (interaktívna) =====
// Ukáž:       neznámy počet opakovaní → do-while alebo while (true) s break.
//             Porovnaj obe riešenia.
// Skús:       zadaj 5, 10, -3, 0.

// Riešenie 1: do-while
int sum = 0;
int number;
do
{
    Console.Write("Zadaj číslo (0 = koniec): ");
    number = int.Parse(Console.ReadLine());
    sum += number;
}
while (number != 0);
Console.WriteLine("Súčet: " + sum);
