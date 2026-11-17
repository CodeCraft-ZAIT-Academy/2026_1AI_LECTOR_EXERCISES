// ===== LIST 11 – Sort a Reverse =====
// Pojmy: Sort, Reverse, zmena pôvodného zoznamu, kópia pred triedením
// Skús zmeniť:
//   1. Zmeň čísla a predpovedz výsledok.
//   2. Zoraď zoznam zostupne (Sort a potom Reverse).
//   3. Zoraď mená podľa abecedy.

List<int> numbers = new List<int> { 4, 2, 9, 6 };
Console.WriteLine("Povodne: " + string.Join(", ", numbers));

// Chceme zachovať pôvodný zoznam? Spravíme kópiu PRED triedením
List<int> sorted = new List<int>(numbers);
sorted.Sort();
Console.WriteLine("Zoradene: " + string.Join(", ", sorted));
Console.WriteLine("Povodny zoznam: " + string.Join(", ", numbers));

sorted.Reverse();
Console.WriteLine("Zostupne: " + string.Join(", ", sorted));

List<string> names = new List<string> { "Cyril", "Anna", "Dana", "Boris" };
names.Sort();
Console.WriteLine("Mena: " + string.Join(", ", names));
