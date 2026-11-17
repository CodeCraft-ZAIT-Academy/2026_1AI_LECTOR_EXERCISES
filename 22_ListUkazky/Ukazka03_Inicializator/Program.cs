// ===== LIST 03 – Inicializátor { } =====
// Pojmy: new List<int> { 4, 2, 9, 6 }, kopírovanie z poľa
// Skús zmeniť:
//   1. Zmeň čísla v zozname.
//   2. Skús zmeniť zložené zátvorky na okrúhle: new List<int>(4, 2, 9, 6). Čo hlási kompilátor?
//   3. Vytvor takto zoznam svojich troch obľúbených jedál.

List<int> numbers = new List<int> { 4, 2, 9, 6 };
Console.WriteLine("Cisla: " + string.Join(", ", numbers));

List<string> foods = new List<string> { "Pizza", "Halusky", "Palacinky" };
Console.WriteLine("Jedla: " + string.Join(", ", foods));

// List sa dá vytvoriť aj z existujúceho poľa
int[] array = { 7, 8, 9 };
List<int> fromArray = new List<int>(array);
fromArray.Add(10);                     // pole by nepovolilo pridať prvok, list áno
Console.WriteLine("Z pola: " + string.Join(", ", fromArray));
