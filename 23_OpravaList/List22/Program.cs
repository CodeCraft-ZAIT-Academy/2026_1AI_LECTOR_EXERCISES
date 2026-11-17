// Úloha 22: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Zoznam je prazdny

List<int> numbers = new List<int>();
int sum = 0;
foreach (int number in numbers)
{
    sum = sum + number;
}
Console.WriteLine("Priemer: " + sum / numbers.Count);
