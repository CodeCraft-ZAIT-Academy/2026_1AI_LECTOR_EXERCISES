// Úloha 30: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Priemer: 2.5

List<int> numbers = new List<int> { 1, 2, 3, 4 };
int sum = 0;
foreach (int number in numbers)
{
    sum = sum + number;
}
double average = sum / numbers.Count;
Console.WriteLine("Priemer: " + average);
