// ===== 02 – Cyklus for =====
// Ukáž:       for (inicializácia; podmienka; zmena) – všetko tri časti na jednom riadku.
//             Použijeme ho, keď vieme, koľkokrát chceme opakovať.
// Skús zmeniť: začiatok, koniec a krok. Čo vypíše for (int i = 10; i > 0; i -= 3)?

for (int i = 0; i < 5; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("--- od 1 do 5 (vrátane)");
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}

Console.WriteLine("--- po dvoch");
for (int i = 0; i <= 10; i += 2)
{
    Console.WriteLine(i);
}

Console.WriteLine("--- odpočítavanie");
for (int i = 5; i >= 1; i--)
{
    Console.WriteLine(i);
}
Console.WriteLine("Štart!");
