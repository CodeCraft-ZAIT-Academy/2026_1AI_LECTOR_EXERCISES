// ===== LIST 01 – Prvý List =====
// Pojmy: List<int>, new List<int>(), Add, Count, foreach
// Skús zmeniť:
//   1. Pridaj do listu ďalšie dve čísla.
//   2. Predpovedz Count pred spustením.
//   3. Skús vypísať numbers.Length. Čo hlási kompilátor? (Pre List sa používa Count.)

List<int> numbers = new List<int>();     // prázdny zoznam čísel

numbers.Add(5);
numbers.Add(10);
numbers.Add(15);

Console.WriteLine("Pocet prvkov: " + numbers.Count);

foreach (int number in numbers)
{
    Console.WriteLine(number);
}

Console.WriteLine(string.Join(", ", numbers));
