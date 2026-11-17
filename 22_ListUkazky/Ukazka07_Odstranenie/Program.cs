// ===== LIST 07 – Odstraňovanie prvkov =====
// Pojmy: Remove (podľa hodnoty), RemoveAt (podľa indexu), Clear, návratová hodnota bool
// Skús zmeniť:
//   1. Čo urobí numbers.Remove(99), ak číslo 99 v zozname nie je?
//   2. Čo urobí RemoveAt(10), keď má zoznam len 3 prvky? (Skús to.)
//   3. Zober zoznam {1, 2, 1, 3, 1} a zavolaj Remove(1). Koľko jednotiek zmizne?

List<int> numbers = new List<int> { 5, 10, 15, 20, 25 };
Console.WriteLine("Na zaciatku: " + string.Join(", ", numbers));

numbers.Remove(10);                    // odstráni HODNOTU 10
Console.WriteLine("Po Remove(10): " + string.Join(", ", numbers));

numbers.RemoveAt(0);                   // odstráni prvok na INDEXE 0
Console.WriteLine("Po RemoveAt(0): " + string.Join(", ", numbers));

bool removed = numbers.Remove(99);     // 99 v zozname nie je
Console.WriteLine("Remove(99) vratilo: " + removed);

List<int> duplicates = new List<int> { 1, 2, 1, 3, 1 };
duplicates.Remove(1);                  // zmizne len PRVÁ jednotka
Console.WriteLine("Po Remove(1): " + string.Join(", ", duplicates));

numbers.Clear();
Console.WriteLine("Po Clear: pocet = " + numbers.Count);
