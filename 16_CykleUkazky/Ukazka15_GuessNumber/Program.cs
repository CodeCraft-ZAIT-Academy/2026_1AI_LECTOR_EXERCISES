// ===== 15 – Hra: hádaj číslo =====
// Ukáž:       počítač vymyslí číslo 1 – 100. Hráč hádá a dostane nápovedu "Viac!" / "Menej!".
//             Cyklus do-while sa opakuje, kým sa tip nerovná tajnému číslu.
//             Random.Shared.Next(1, 101) vráti náhodné celé číslo od 1 do 100 vrátane.
// Skús zmeniť: rozsah (1 - 1000); pridaj obmedzenie počtu pokusov (maxAttempts) s break.

int secret = Random.Shared.Next(1, 101);
int guess;
int attempts = 0;

do
{
    Console.Write("Tvoj tip (1 - 100): ");
    guess = int.Parse(Console.ReadLine());
    attempts++;

    if (guess < secret)
    {
        Console.WriteLine("Viac!");
    }
    else if (guess > secret)
    {
        Console.WriteLine("Menej!");
    }
}
while (guess != secret);

Console.WriteLine("Trafil si na " + attempts + ". pokus! Tajné číslo bolo " + secret + ".");
