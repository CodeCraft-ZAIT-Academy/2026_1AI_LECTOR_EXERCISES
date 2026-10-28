// ===== 11 – Referenčné riešenie cvičenia: WeatherStats =====
// V lekcii sú metódy v triede WeatherStats. Tu sú zapísané ako obyčajné metódy v Program.cs.
// Ukáž:       priemer = súčet / počet. Maximum a minimum začíname PRVÝM prvkom poľa (nie nulou –
//             teploty môžu byť záporné!). Vstupné pole má vždy aspoň jednu hodnotu.
// Skús zmeniť: teploty; pridaj záporné; pole s jedným prvkom.

double[] temperatures = { 12.5, 15.0, 9.5, 18.0, 14.0, 7.5, 11.0 };
double[] cold = { -3.0, -8.5, -1.0 };

Console.WriteLine("Priemer: " + AverageTemperature(temperatures));   // 12.5
Console.WriteLine("Maximum: " + MaxTemperature(temperatures));       // 18
Console.WriteLine("Minimum:  " + MinTemperature(temperatures));      // 7.5
Console.WriteLine("Mráz – maximum: " + MaxTemperature(cold));        // -1
Console.WriteLine("Mráz – minimum: " + MinTemperature(cold));        // -8.5

static double AverageTemperature(double[] temperatures)
{
    double sum = 0;
    foreach (double temperature in temperatures)
    {
        sum += temperature;
    }

    return sum / temperatures.Length;
}

static double MaxTemperature(double[] temperatures)
{
    double max = temperatures[0];
    foreach (double temperature in temperatures)
    {
        if (temperature > max)
        {
            max = temperature;
        }
    }

    return max;
}

static double MinTemperature(double[] temperatures)
{
    double min = temperatures[0];
    foreach (double temperature in temperatures)
    {
        if (temperature < min)
        {
            min = temperature;
        }
    }

    return min;
}
