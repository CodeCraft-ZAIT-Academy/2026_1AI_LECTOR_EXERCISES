// Úloha 21: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Sum: 15

// Súčet prvkov poľa má byť 15.
int[] numbers = { 1, 2, 3, 4, 5 };
int sum = 0;
foreach (int number in numbers)
{
    sum =+ number;
}
Console.WriteLine("Sum: " + sum);
