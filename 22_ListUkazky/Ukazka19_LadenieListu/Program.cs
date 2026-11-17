// ===== LIST 19 – Ladenie listu =====
// Postup: dvojklik vľavo pri čísle riadku (breakpoint) pri každom // STOP, spusti F5, krokuj F10.
// Úlohy (pozeraj okno Locals, rozbaľ premennú numbers):
//   STOP 1: Aký je Count a aký Capacity? Aké prvky sú v zozname?
//   STOP 2: Po riadku s Add: Count? Capacity? (Zmenila sa kapacita?)
//   STOP 3: Po Insert: na ktorom indexe je číslo 20? Čo sa stalo s ostatnými?
//   STOP 4: Po RemoveAt(0): aké prvky ostali?
//   STOP 5: Po Sort: v akom poradí sú prvky? Aký je sum po cykle?

List<int> numbers = new List<int> { 4, 2, 9, 6 };    // STOP 1

numbers.Add(7);                                       // STOP 2 (stlač F10 a pozri zmenu)
numbers.Insert(1, 20);                                // STOP 3
numbers.RemoveAt(0);                                  // STOP 4
numbers.Sort();                                       // STOP 5

int sum = 0;
foreach (int number in numbers)
{
    sum = sum + number;
}
Console.WriteLine("Zoznam: " + string.Join(", ", numbers));
Console.WriteLine("Sucet: " + sum);
