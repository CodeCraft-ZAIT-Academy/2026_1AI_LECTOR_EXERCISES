// ===== LIST 18 – Lotéria 6 z 49 =====
// Pojmy: Random, while, Contains (bez duplicít), Sort
// Skús zmeniť:
//   1. Zmeň na 5 z 35.
//   2. Vypíš aj počet pokusov, koľkokrát Random vrátil číslo, ktoré už v zozname bolo.
//   3. Nechaj hráča tipnúť 6 čísel (zbieraj ich do druhého listu) a spočítaj zhody.

Random random = new Random();
List<int> drawn = new List<int>();

while (drawn.Count < 6)
{
    int number = random.Next(1, 50);       // 1 až 49
    if (!drawn.Contains(number))           // iba nové čísla
    {
        drawn.Add(number);
    }
}

drawn.Sort();
Console.WriteLine("Dnesne tahanie: " + string.Join(", ", drawn));
