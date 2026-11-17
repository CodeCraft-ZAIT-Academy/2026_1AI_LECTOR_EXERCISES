// ===== LIST 13 – Filtrovanie do nového listu =====
// Pojmy: nový prázdny list + Add v cykle, vyhnutie sa duplicitám cez Contains
// Skús zmeniť:
//   1. Vyber do nového zoznamu len čísla väčšie ako 5.
//   2. Odstráň duplicity: pridaj prvok do uniqueNumbers len ak ho tam ešte nie je.
//   3. Pri poli by si musel vopred poznať počet prvkov. Prečo je tu List výhodnejší?

List<int> numbers = new List<int> { 3, 8, 3, 12, 7, 8, 20, 3 };

List<int> evens = new List<int>();
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        evens.Add(number);
    }
}
Console.WriteLine("Parne: " + string.Join(", ", evens));

List<int> uniqueNumbers = new List<int>();
foreach (int number in numbers)
{
    if (!uniqueNumbers.Contains(number))
    {
        uniqueNumbers.Add(number);
    }
}
Console.WriteLine("Bez duplicit: " + string.Join(", ", uniqueNumbers));
