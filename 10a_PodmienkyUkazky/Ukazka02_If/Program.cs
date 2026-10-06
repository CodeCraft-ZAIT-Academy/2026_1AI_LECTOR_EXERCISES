// ===== 02 – Podmienka if =====
// Ukáž:       blok sa vykoná len vtedy, keď je podmienka pravdivá.
// Skús zmeniť: age na 15 – "You are an adult." zmizne, ale "Done." ostane.

int age = 20;

Console.WriteLine("Checking age...");

if (age >= 18)
{
    Console.WriteLine("You are an adult.");
}

Console.WriteLine("Done.");
