// ===== 04 – Súčet, priemer a počítanie v poli =====
// Ukáž:       "akumulátor": premenná pred cyklom (sum = 0), ktorá sa v cykle zväčšuje.
//             sum += x je skrátený zápis sum = sum + x.
//             Podobne počítame: koľko párnych čísel pole obsahuje.
// Skús zmeniť: čísla v poli. Pridaj počítanie čísel väčších ako 3.

int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;

for (int i = 0; i < numbers.Length; i++)
{
    sum += numbers[i];
}

Console.WriteLine("Súčet: " + sum);                                    // 15
Console.WriteLine("Priemer: " + (double)sum / numbers.Length);          // 3

int evens = 0;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        evens++;
    }
}
Console.WriteLine("Párnych čísel: " + evens);                           // 2
