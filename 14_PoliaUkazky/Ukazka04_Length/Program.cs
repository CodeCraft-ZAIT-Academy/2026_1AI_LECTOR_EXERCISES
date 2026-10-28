// ===== 04 – Dĺžka poľa a posledný prvok =====
// Ukáž:       Length je počet prvkov (nie posledný index!). Posledný index je Length - 1.
//             Prázdne pole má Length = 0 a nemá žiadny platný index.
// Skús zmeniť: pridaj do poľa ďalšie hodnoty – posledný prvok sa nájde sám.

int[] numbers = { 10, 20, 30, 40, 50 };
int length = numbers.Length;

Console.WriteLine("Length:          " + length);
Console.WriteLine("Posledný index:  " + (length - 1));
Console.WriteLine("Posledný prvok:  " + numbers[numbers.Length - 1]);
Console.WriteLine("Prostredný prvok: " + numbers[numbers.Length / 2]);

int[] empty = new int[0];
Console.WriteLine("Prázdne pole, Length = " + empty.Length);
