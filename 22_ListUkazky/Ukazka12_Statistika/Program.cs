// ===== LIST 12 – Súčet, priemer, minimum, maximum =====
// Pojmy: akumulátor v cykle, priemer cez (double), prvý prvok ako štart pre min/max
// Skús zmeniť:
//   1. Pridaj do zoznamu záporné číslo. Funguje min/max aj potom?
//   2. Zmeň (double)sum / numbers.Count na sum / numbers.Count. Aký je rozdiel?
//   3. Vypíš aj počet čísel väčších ako priemer.

List<int> numbers = new List<int> { 3, -2, 8, 5, 4, 2 };

int sum = 0;
int min = numbers[0];
int max = numbers[0];
foreach (int number in numbers)
{
    sum = sum + number;
    if (number < min)
    {
        min = number;
    }
    if (number > max)
    {
        max = number;
    }
}

Console.WriteLine("Pocet: " + numbers.Count);
Console.WriteLine("Sucet: " + sum);
Console.WriteLine("Priemer: " + (double)sum / numbers.Count);
Console.WriteLine("Minimum: " + min);
Console.WriteLine("Maximum: " + max);
