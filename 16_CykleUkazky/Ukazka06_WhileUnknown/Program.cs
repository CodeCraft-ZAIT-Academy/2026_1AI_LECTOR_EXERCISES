// ===== 06 – while, keď nevieme počet opakovaní =====
// Ukáž:       for používame, keď vieme počet opakovaní. while, keď to dopredu nevieme (kým sa niečo nestane).
//             1) delenie dvoma, kým číslo nie je <= 1 (z lekcie),
//             2) počet cifier čísla (delíme desiatimi),
//             3) Collatzova postupnosť (párne /2, nepárne *3+1) – skončí vždy pri 1.
// Skús zmeniť: čísla number, n, c.

double number = 32;
int steps = 0;
while (number > 1)
{
    number /= 2;
    steps++;
}
Console.WriteLine("Delenie dvoma: výsledok " + number + ", krokov " + steps);   // 1, 5

int n = 12345;
int digits = 0;
while (n > 0)
{
    n /= 10;
    digits++;
}
Console.WriteLine("Počet cifier: " + digits);                                    // 5

int c = 6;
int collatzSteps = 0;
while (c != 1)
{
    if (c % 2 == 0)
    {
        c = c / 2;
    }
    else
    {
        c = 3 * c + 1;
    }
    collatzSteps++;
}
Console.WriteLine("Collatz pre 6: krokov " + collatzSteps);                      // 8
