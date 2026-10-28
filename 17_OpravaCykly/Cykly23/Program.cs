// Úloha 23: Oprav program tak, aby fungoval správne.
// Očakávaný výstup:
//   Max: -1

// Najvyššia teplota (všetky sú záporné) má byť -1.
double[] temperatures = { -3.0, -8.5, -1.0 };
double max = 0;
foreach (double temperature in temperatures)
{
    if (temperature > max)
    {
        max = temperature;
    }
}
Console.WriteLine("Max: " + max);
