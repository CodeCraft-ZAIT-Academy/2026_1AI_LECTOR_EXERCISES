// ===== 17 – Krokovanie v debuggeri (príbeh hry) =====
// Ukáž:       Nastav breakpoint (F9) na prvý if, spusti F5 a krokuj F10.
//             Pri každom if povedz NAHLAS, či bude podmienka pravdivá, a over v okne Locals.
// Skús zmeniť: health = 100, hasPotion = false, enemies = 0.

int health = 40;
bool hasPotion = true;
int enemies = 2;

// Časť 1: stav hráča
if (health <= 0)
{
    Console.WriteLine("Game over.");
}
else if (health < 50 && hasPotion)
{
    health = health + 30;
    hasPotion = false;
    Console.WriteLine("You drink a potion. Health: " + health);
}
else if (health < 50)
{
    Console.WriteLine("You are weak. You run away.");
}
else
{
    Console.WriteLine("You feel strong.");
}

// Časť 2: súboj
if (enemies > 0 && health >= 50)
{
    Console.WriteLine("You fight " + enemies + " enemies.");
}
else if (enemies > 0)
{
    Console.WriteLine("Too weak to fight.");
}
else
{
    Console.WriteLine("Level cleared!");
}
