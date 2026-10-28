// ===== 08 – break a continue =====
// Ukáž:       break = ukonči celý cyklus. continue = preskoč zvyšok TOHTO prechodu a pokračuj ďalším.
// Skús zmeniť: číslo 5 v podmienke; potom vymeň break za continue a naopak.

Console.WriteLine("--- break pri i == 5");
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        break;
    }
    Console.WriteLine(i);
}

Console.WriteLine("--- continue pri i == 5");
for (int i = 0; i < 10; i++)
{
    if (i == 5)
    {
        continue;
    }
    Console.WriteLine(i);
}

Console.WriteLine("--- len nepárne čísla (continue)");
for (int i = 1; i <= 10; i++)
{
    if (i % 2 == 0)
    {
        continue;
    }
    Console.WriteLine(i);
}

Console.WriteLine("--- prvé párne číslo v poli (break)");
int[] numbers = { 3, 7, 9, 12, 15, 18 };
int firstEven = -1;
foreach (int number in numbers)
{
    if (number % 2 == 0)
    {
        firstEven = number;
        break;
    }
}
Console.WriteLine("Prvé párne: " + firstEven);
