// ===== 16 – Galéria pascí v cykloch =====
// Ukáž:       správny kód je aktívny, chybná verzia je v komentári a vysvetlená.
//             Odkomentuj chybný variant (a správny zakomentuj), spusti a pozri, čo sa stane.
//             POZOR: pri nekonečnom cykle program zastavíš klávesom Shift+F5 (ladenie) alebo Ctrl+C (konzola).

// --- Pasca 1: o jedna vedľa (off-by-one) ---------------------------------
// ZLE:  for (int i = 1; i < 5; i++)    -> vypíše 1 2 3 4 (chýba 5)
for (int i = 1; i <= 5; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine("  (1 až 5)");

// --- Pasca 2: chýba zmena premennej ----------------------------------------
// ZLE:  int k = 0;
//       while (k < 3)
//       {
//           Console.WriteLine(k);     // nekonečný cyklus – k sa nikdy nezmení!
//       }
int k = 0;
while (k < 3)
{
    Console.Write(k + " ");
    k++;
}
Console.WriteLine("  (while s k++)");

// --- Pasca 3: bodkočiarka za for ------------------------------------------
// ZLE:  for (int i = 0; i < 3; i++);   -> cyklus riadi prázdny príkaz, blok { } sa vykoná len RAZ
//       {
//           Console.WriteLine("Ahoj");
//       }
for (int i = 0; i < 3; i++)
{
    Console.Write("Ahoj ");
}
Console.WriteLine("  (3x)");

// --- Pasca 4: <= Length pri poli -------------------------------------------
int[] numbers = { 10, 20, 30 };
// ZLE:  for (int i = 0; i <= numbers.Length; i++)   -> IndexOutOfRangeException pri i = 3
int total = 0;
for (int i = 0; i < numbers.Length; i++)
{
    total += numbers[i];
}
Console.WriteLine("Súčet = " + total);

// --- Pasca 5: foreach a zmena prvkov -----------------------------------------
// ZLE:  foreach (int number in numbers) { number = number * 2; }   -> chyba pri kompilácii (CS1656)
//       foreach (int number in numbers) { int doubled = number * 2; }   -> pole sa nezmení!
for (int i = 0; i < numbers.Length; i++)
{
    numbers[i] = numbers[i] * 2;
}
Console.WriteLine("Po zdvojnásobení: " + string.Join(", ", numbers));

// --- Pasca 6: premenná, ktorú nulujeme v cykle -------------------------------
// ZLE:  for (int i = 1; i <= 5; i++) { int sum = 0; sum += i; Console.WriteLine(sum); }   -> vypíše 1 2 3 4 5
int sum2 = 0;
for (int i = 1; i <= 5; i++)
{
    sum2 += i;
}
Console.WriteLine("1 + 2 + 3 + 4 + 5 = " + sum2);
