// ===== LIST 09 – Insert =====
// Pojmy: Insert(index, hodnota), posun prvkov, Add vs. Insert
// Skús zmeniť:
//   1. Vlož číslo 7 na úplný začiatok (index 0).
//   2. Vlož číslo na koniec cez Insert(numbers.Count, ...). Funguje to ako Add?
//   3. Skús Insert(10, 5) pri troch prvkoch. Čo sa stane?

List<int> numbers = new List<int> { 5, 10, 15 };
Console.WriteLine("Na zaciatku: " + string.Join(", ", numbers));

numbers.Insert(1, 20);                 // 20 bude na indexe 1, ostatné sa posunú
Console.WriteLine("Po Insert(1, 20): " + string.Join(", ", numbers));

numbers.Insert(0, 1);                  // na začiatok
Console.WriteLine("Po Insert(0, 1): " + string.Join(", ", numbers));

numbers.Add(99);                       // Add pridá na koniec
Console.WriteLine("Po Add(99): " + string.Join(", ", numbers));
