// ===== 04 – else if: viac možností =====
// Ukáž:       podmienky sa kontrolujú zhora nadol, vykoná sa PRVÁ pravdivá vetva, zvyšok sa preskočí.
// Skús zmeniť: age na 5, 13, 17, 18, 40. Pri ktorých hodnotách sa mení výsledok?

int age = 20;

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}
else if (age >= 13)
{
    Console.WriteLine("You are a teenager.");
}
else
{
    Console.WriteLine("You are a kid.");
}
